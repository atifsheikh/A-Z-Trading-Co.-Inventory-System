using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Data;

namespace firebirdtest.Classes
{
    public class RandomAlgos
    {
        public static void CleanUpGridView(DataSet VendorDataSet, System.Windows.Forms.DataGridView dataGridViewObject)
        {
            dataGridViewObject.DataSource = VendorDataSet.Tables[0];
            try
            {
                if (dataGridViewObject.Columns.Count > 0)
                {
                    dataGridViewObject.Columns["ID"].Visible = false;
                }
                if (VendorDataSet.Tables.Count > 0)
                {
                    //after populating dgv, do the follwing:
                    int cleanCount = VendorDataSet.Tables[0].Rows.Count;
                    while (dataGridViewObject.Rows.Count > cleanCount)
                    {
                        dataGridViewObject.Rows[cleanCount].Visible = false;
                        cleanCount++;
                    }
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationStatus = true;
                Variables.NotificationMessageTitle = "Grid CleanUp Have Issues.";
                Variables.NotificationMessageText = ex.Message;
            }
        }

        public static Dictionary<string, Regex> RegexDic = new Dictionary<string, Regex>(); // To avoid creating regex multiple times.

        public static Regex ReturnRegex(string regex)
        {
            if (RegexDic.ContainsKey(regex)) { var r = RegexDic[regex]; return r; }
            else { var matchTimeout = TimeSpan.FromMilliseconds(20); var rgx = new Regex(regex, RegexOptions.Singleline | RegexOptions.Compiled); RegexDic[regex] = rgx; return rgx; }
        }

        public static string Group1(string page, string regex)
        {
            var r = ReturnRegex(regex);
            var match = r.Match(page);
            return match.Groups[1].ToString();
        }
        public static string Group2(string page, string regex)
        {
            var r = ReturnRegex(regex);
            var match = r.Match(page);
            return match.Groups[2].ToString();
        }
        public static List<string> AllGroups(string page, string regex)
        {
            List<string> matches = new List<string>();
            var r = ReturnRegex(regex);
            foreach (Match ItemMatch in r.Matches(page))
            {
                matches.Add(ItemMatch.Groups[1].ToString());
            }
            return matches;
        }

        public static object[] originalList = new object[1];
        public static IEnumerable<object> newList = originalList;
        public static System.Windows.Forms.ComboBox comboKeyPressed(System.Windows.Forms.ComboBox combo)
        {
            try
            {
                try
                {
                    if(combo.Items.Count < 0)
                        combo.DroppedDown = false;
                }
                catch (Exception ex)
                {
                    Variables.NotificationMessageTitle = "RandomAlgo";
                    Variables.NotificationMessageText = ex.Message;
                    Variables.NotificationStatus = true;
                    return combo;
                }
                originalList = (object[])combo.Tag;
                if (originalList == null || originalList.Length < combo.Items.Count)
                {
                    // backup original list
                    originalList = new object[combo.Items.Count];
                    combo.Items.CopyTo(originalList, 0);
                    combo.Tag = originalList;
                }

                try
                {
                    // prepare list of matching items
                    string s = combo.Text.ToLower();
                    newList = originalList;
                    if (s.Length > 0)
                    {
                        newList = originalList.Where(item => item.ToString().ToLower().Contains(s));
                    }

                    // clear list (loop through it, otherwise the cursor would move to the beginning of the textbox...)
                    while (combo.Items.Count >= 0)
                    {
                        try
                        {
                            if (combo.Items.Count > 0)
                                combo.Items.RemoveAt(0);
                            else
                                break;
                        }
                        catch (Exception ex)
                        {
                            Variables.NotificationMessageTitle = "RandomAlgo";
                            Variables.NotificationMessageText = ex.Message;
                            Variables.NotificationStatus = true;
                            return combo;
                        }
                    }


                    //            combo.Text = inputText;
                    try
                    {
                    // re-set list
                        if (newList.ToArray().Length > 0)
                        {
                            combo.Items.AddRange(newList.ToArray());
                            combo.DroppedDown = true;
                        }
                        //else if (combo.DroppedDown != false)
                        //    combo.DroppedDown = false;
                    }
                    catch (Exception ex)
                    {
                        Variables.NotificationMessageTitle = "RandomAlgo";
                        Variables.NotificationMessageText = ex.Message;
                        Variables.NotificationStatus = true;
                        return combo;
                    }

                    
                }
                catch (Exception ex)
                {
                    Variables.NotificationMessageTitle = "RandomAlgos.cs";
                    Variables.NotificationMessageText = ex.Message;
                    Variables.NotificationStatus = true;
                    return combo;
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = "RandomAlgos.cs";
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
                return combo;
            }
            return combo;
        }

        internal static void AddDataInSalesFile(string SrNo, string ItemCode, string ItemName, string Ctn, string Qty, string Quant, string UnitPrice, string SubTotal, string CustomerName, string BalanceNew, string Total, string textBox8, string textBox7)
        {
            try
            {
                // Compose a string that consists of three lines.
                string lines = SrNo + ";" + ItemCode + ";" + ItemName + ";" + Ctn + ";" + Qty + ";" + Quant + ";" + UnitPrice + ";" + SubTotal + "\r\n<>\r\n" + CustomerName + ";" + BalanceNew + ";" + Total + ";" + textBox8 + ";" + textBox7 + ";\r\n";
                // Write the string to a file.
                System.IO.StreamWriter file = new System.IO.StreamWriter("Sales.txt", true);
                file.WriteLine(lines);

                file.Close();
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = "RandomAlgos.cs";
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }
        }

        internal static void RestoreOldSlaesDataInGrid(System.Windows.Forms.DataGridView BillDetailDataGridView, System.Windows.Forms.ComboBox CustomerName_txt, System.Windows.Forms.TextBox BalanceNew_txt, System.Windows.Forms.TextBox Total_txt, System.Windows.Forms.TextBox textBox8, System.Windows.Forms.TextBox textBox7, System.Windows.Forms.TextBox CustomerBalance_txt)
        {
            if (File.Exists("Sales.txt") == false)
                return;
            ///////////
            string lines = "";
            string[] row = new string[1];
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader("Sales.txt");
                while (lines != null)
                {
                    lines = file.ReadLine();
                    //                string[] DataRows 
                    if (lines != null && lines != "" && lines.StartsWith("<>") == false)
                    {
                        row = lines.Split(';');//{ DataRows[0], DataRows[1], DataRows[2], DataRows[3], DataRows[4], DataRows[5], DataRows[6], DataRows[7]};
                        //row[row.Length - 1].Remove(0);
                        BillDetailDataGridView.Rows.Add(row);
                        Total_txt.Text = (Convert.ToDecimal(Total_txt.Text) + Convert.ToDecimal(row[7])).ToString(); 
                    }
                    else if (lines != null && lines.StartsWith("<>") == true)
                    {
                        lines = file.ReadLine();
                        row = lines.Split(';');
                    }
                }
                file.Close();
                CustomerName_txt.Text = row[0];

                BalanceNew_txt.Text = (Convert.ToDecimal(Total_txt.Text)).ToString();// + Convert.ToDecimal(CustomerBalance_txt.Text)).ToString();
                textBox8.Text = row[3];
                textBox7.Text = row[4];
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = "RandomAlgos.cs";
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }
        }

        internal static void DeleteSalesFile()
        {
            try
            {
                File.Delete("Sales.txt");
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = "RandomAlgos.cs";
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }
        }

        internal static void AddDataInConsignmentFile(string SrNo, string ItemName, string Description, string QtyPerBox, string Ctn, string TQuantity, string Price, string SubTotal, string ConsignmentNumber, string textBox8, string textBox7, string CostAmount)
        {
            try
            {
                // Compose a string that consists of three lines.
                string lines = SrNo + ";" + ItemName + ";" + Description + ";" + Ctn + ";" + QtyPerBox + ";" + TQuantity + ";" + Price + ";" + SubTotal + "\r\n<>\r\n" + ConsignmentNumber + ";" + textBox8 + ";" + textBox7 + ";" + CostAmount + ";\r\n";
                // Write the string to a file.
                System.IO.StreamWriter file = new System.IO.StreamWriter("Consignment.txt", true);
                file.WriteLine(lines);

                file.Close();
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = "RandomAlgos.cs";
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }
        }

        internal static void RestoreOldConsignmentDataInGrid(System.Windows.Forms.DataGridView BillDetailDataGridView, System.Windows.Forms.TextBox CustomerName_txt, System.Windows.Forms.TextBox Total_txt, System.Windows.Forms.TextBox textBox8, System.Windows.Forms.TextBox textBox7)
        {
            if (File.Exists("Consignment.txt") == false)
                return;
            ///////////
            string lines = "";
            string[] row = new string[1];
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader("Consignment.txt");
                while (lines != null)
                {
                    lines = file.ReadLine();
                    //                string[] DataRows 
                    if (lines != null && lines != "" && lines.StartsWith("<>") == false)
                    {
                        row = lines.Split(';');//{ DataRows[0], DataRows[1], DataRows[2], DataRows[3], DataRows[4], DataRows[5], DataRows[6], DataRows[7]};
                        //row[row.Length - 1].Remove(0);
                        BillDetailDataGridView.Rows.Add(row);
                        Total_txt.Text = (Convert.ToDecimal(Total_txt.Text) +Convert.ToDecimal(row[3])).ToString();
                    }
                    else if (lines != null && lines.StartsWith("<>") == true)
                    {
                        lines = file.ReadLine();
                        row = lines.Split(';');
                    }
                }
                file.Close();
                CustomerName_txt.Text = row[0];
                textBox8.Text = row[1];
                textBox7.Text = row[2];
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = "RandomAlgos.cs";
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }
        }

        internal static void DeleteConsignmentFile()
        {
            try
            {
                File.Delete("Consignment.txt");
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageTitle = "RandomAlgos.cs";
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationStatus = true;
            }
        }
    }
}