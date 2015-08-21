using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using System.Windows.Forms;
using System.Net;

namespace firebirdtest
{
    class DatabaseCalls
    {
            public static string POST(string url, string attributes)
            {
                string response = "";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Credentials = CredentialCache.DefaultCredentials;
                request.Method = "POST";
                Stream postStream = request.GetRequestStream();
                var bytes1 = System.Text.Encoding.UTF8.GetBytes(attributes);
                postStream.Write(bytes1, 0, bytes1.Length);
                postStream.Close();

                // Get the response.
                WebResponse response1 = request.GetResponse();
                Stream dataStream = response1.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);

                response = reader.ReadToEnd();

                reader.Close();
                response1.Close();
                return response;
            }
            public static string GET(string url)
            {
                string response = "";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Credentials = CredentialCache.DefaultCredentials;
                request.Method = "GET";
                WebResponse response1 = request.GetResponse();
                Stream dataStream = response1.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);

                response = reader.ReadToEnd();

                reader.Close();
                response1.Close();
                return response;
            }

            public static string PUT(string url, string attributes)
            {
                string response = "";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Credentials = CredentialCache.DefaultCredentials;
                request.Method = "PUT";
                Stream postStream = request.GetRequestStream();
                var bytes1 = System.Text.Encoding.UTF8.GetBytes(attributes);
                postStream.Write(bytes1, 0, bytes1.Length);
                postStream.Close();

                // Get the response.
                WebResponse response1 = request.GetResponse();
                Stream dataStream = response1.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);

                response = reader.ReadToEnd();

                reader.Close();
                response1.Close();
                return response;
            }


        internal static string GetVendors()
        {
            return POST("http://localhost:8080/ThePrimeBaby/GetVendor","");
        }
            
        internal static string AddVendor(string Name, string address, string phone, string email, int ballance_limit, int opening_balance)
        {
            return POST("http://localhost:8080/ThePrimeBaby/AddVendor/" + Name + "/" + address + "/" + phone + "/" + email, "");
        }

        //Customer

        internal static string AddCustomer(string Name, string address, string phone, string email, int ballance_limit, int opening_balance)
        {
            try
            {
                FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);

                myConnection1.Open();

                //4. create a new DataSet
                DataSet myDataSet = new DataSet();

                //5. Declare an Adapter to interface with our Table in Firebird
                FbDataAdapter myDataAdapter = new FbDataAdapter("Select MAX(ID) from Customers", myConnection1);

                //6. Fill the Dataset
                myDataAdapter.Fill(myDataSet);
                int MaxCustomerID = 0;
                try
                {
                    MaxCustomerID = Convert.ToInt32(myDataSet.Tables[0].Rows[0].ItemArray[0]);
                }
                catch (Exception ex)
                {
                    try
                    {
                        MaxCustomerID = 0;
                    }
                    catch (Exception ex1)
                    {
                        myConnection1.Close();
                        return ex1.Message.ToString();
                    }
                }
                //myConnection1.Close();

                try
                {

                    FbTransaction myTransaction = myConnection1.BeginTransaction();

                    FbCommand myCommand = new FbCommand();

                    myCommand.CommandText = "INSERT INTO CUSTOMERS (ID, NAME, ADDRESS, EMAIL, BALANCE_LIMIT,OPENING_BALANCE ,AMOUNT ,PHONE)VALUES(@ID, @NAME, @ADDRESS, @EMAIL, @BALANCE_LIMIT,@OPENING_BALANCE ,@AMOUNT ,@PHONE)";
                    myCommand.Connection = myConnection1;
                    myCommand.Transaction = myTransaction;


                    myCommand.Parameters.Add("@ID", FbDbType.Integer).Value = ++MaxCustomerID;
                    myCommand.Parameters.Add("@NAME", FbDbType.VarChar).Value = Name;
                    myCommand.Parameters.Add("@ADDRESS", FbDbType.Integer).Value = address;
                    myCommand.Parameters.Add("@EMAIL", FbDbType.Integer).Value = email;
                    myCommand.Parameters.Add("@BALANCE_LIMIT", FbDbType.Integer).Value = ballance_limit;
                    myCommand.Parameters.Add("@OPENING_BALANCE", FbDbType.Integer).Value = opening_balance;
                    myCommand.Parameters.Add("@AMOUNT", FbDbType.Integer).Value = opening_balance;
                    myCommand.Parameters.Add("@PHONE", FbDbType.VarChar).Value = phone;
                    myCommand.ExecuteNonQuery();
                    myTransaction.Commit();
                    myCommand.Dispose();
                    myConnection1.Close();
                    return "Customer Added with ID = " + MaxCustomerID.ToString();
                }
                catch (Exception ex)
                {
                    myConnection1.Close();
                    return ex.Message.ToString();
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            }
            return null;
        }

        internal static string ModifyCustomer(string Find, string Replace)
        {
            try
            {
                FbConnection deleteConnection = new FbConnection(Variables.DatabaseConnectString);
                deleteConnection.Open();

                FbTransaction deleteTransaction = deleteConnection.BeginTransaction();
                FbCommand deleteCommand = new FbCommand("Update Customers set Name = '" + Replace + "' where Name = " + "'" + Find + "'", deleteConnection, deleteTransaction);

                deleteCommand.ExecuteNonQuery();
                deleteTransaction.Commit();
                deleteConnection.Close();
                return "Customer Name Modified to " + Find;
            }
            catch (Exception x)
            {
                return x.Message.ToString();
            }
        }

        internal static string ModifyCustomer(string FindID, string ReplaceName, string ReplaceAddress, string ReplacePhone, string ReplaceEmail, decimal ReplaceOpening_balance, decimal CalculatedAmount)
        {
            FbConnection ModifyItemConnection = new FbConnection(Variables.DatabaseConnectString);
            try
            {
                ModifyItemConnection.Open();
                FbTransaction myTransaction = ModifyItemConnection.BeginTransaction();

                FbCommand myCommand = new FbCommand();
                myCommand.CommandText = "Update CUSTOMERS set ID = @ID , NAME = @NAME , ADDRESS = @ADDRESS , EMAIL= @EMAIL , OPENING_BALANCE = @OPENING_BALANCE,PHONE=@PHONE, AMOUNT = @AMOUNT where ID = @ID";
                myCommand.Connection = ModifyItemConnection;
                myCommand.Transaction = myTransaction;


                myCommand.Parameters.Add("@ID", FbDbType.Integer).Value = FindID;
                myCommand.Parameters.Add("@NAME", FbDbType.VarChar).Value = ReplaceName;
                myCommand.Parameters.Add("@ADDRESS", FbDbType.Integer).Value = ReplaceAddress;
                myCommand.Parameters.Add("@EMAIL", FbDbType.Integer).Value = ReplaceEmail;
                myCommand.Parameters.Add("@OPENING_BALANCE", FbDbType.Integer).Value = ReplaceOpening_balance;
                myCommand.Parameters.Add("@PHONE", FbDbType.VarChar).Value = ReplacePhone;
                myCommand.Parameters.Add("@AMOUNT", FbDbType.VarChar).Value = CalculatedAmount;
                myCommand.ExecuteNonQuery();
                myTransaction.Commit();
                myCommand.Dispose();
                ModifyItemConnection.Close();
                return "Customer modified = " + FindID.ToString() + " Modified...";
            }
            catch (FbException ex)
            {
                ModifyItemConnection.Close();
                return ex.Message.ToString();
            }
        }

        internal static string ModifyCustomer(int CustomerID, decimal NewBalance)
        {
            try
            {
                FbConnection deleteConnection = new FbConnection(Variables.DatabaseConnectString);
                deleteConnection.Open();

                FbTransaction deleteTransaction = deleteConnection.BeginTransaction();
                FbCommand deleteCommand = new FbCommand("Update Customers set AMOUNT = '" + NewBalance + "' where ID = " + "'" + CustomerID + "'", deleteConnection, deleteTransaction);

                deleteCommand.ExecuteNonQuery();
                deleteTransaction.Commit();
                deleteConnection.Close();
                return "Customer Balance Updated to " + NewBalance;
            }
            catch (Exception x)
            {
                return x.Message.ToString();
            }
        }

        internal static string DeleteCustomer(string Name)
        {
            try
            {
                FbConnection deleteConnection = new FbConnection(Variables.DatabaseConnectString);
                deleteConnection.Open();

                FbTransaction deleteTransaction = deleteConnection.BeginTransaction();
                FbCommand deleteCommand = new FbCommand("Delete From Customers where Name = " + "'" + Name + "'", deleteConnection, deleteTransaction);

                deleteCommand.ExecuteNonQuery();
                deleteTransaction.Commit();
                deleteConnection.Close();
                return "Customer Deleted";
            }
            catch (Exception x)
            {
                return x.Message.ToString();
            }
        }

        internal static DataSet GetCustomers()
        {
            try
            {
            FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
            myConnection1.Open();

            DataSet myDataSet = new DataSet();

            FbDataAdapter myDataAdapter = new FbDataAdapter("Select * from Customers", myConnection1);

            myDataAdapter.Fill(myDataSet);
            myConnection1.Close();

            return myDataSet;
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            }
            return null;
        }

        internal static DataSet GetCustomer(String Name)
        {
            try
            {
                FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
                myConnection1.Open();

                DataSet myDataSet = new DataSet();

                FbDataAdapter myDataAdapter = new FbDataAdapter("Select * from Customers Where NAME = '" + Name + "'", myConnection1);

                myDataAdapter.Fill(myDataSet);
                myConnection1.Close();

                return myDataSet;
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            }
            return null;
        }

        internal static string GetCustomerName(int ID)
        {
            try
            {
                FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
                myConnection1.Open();

                DataSet myDataSet = new DataSet();

                FbDataAdapter myDataAdapter = new FbDataAdapter("Select NAME from CUSTOMERS WHERE ID = '" + ID.ToString() + "'", myConnection1);

                myDataAdapter.Fill(myDataSet);
                myConnection1.Close();
                if (myDataSet.Tables[0].Rows[0].ItemArray[0].ToString() == "")
                    return "";
                return myDataSet.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            }
            return null;
        }

        internal static DataSet GetCustomer(int ID)
        {
            try
            {
                FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
                myConnection1.Open();

                DataSet myDataSet = new DataSet();

                FbDataAdapter myDataAdapter = new FbDataAdapter("Select * from CUSTOMERS WHERE ID = '" + ID.ToString() + "'", myConnection1);

                myDataAdapter.Fill(myDataSet);
                myConnection1.Close();

                return myDataSet;
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            }
            return null;
        }

        //Item
        internal static string AddItem(string Name, String Model, int QTY_Box, decimal Price, decimal CostPrice, String ImagePath, string ItemCategory)
        {
            try
            {
                if (ImagePath == null || ImagePath == "")
                    ImagePath = "A-Z.png";
                FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
                myConnection1.Open();
                DataSet myDataSet = new DataSet();
                FbDataAdapter myDataAdapter = new FbDataAdapter("Select MAX(ID) from Item", myConnection1);
                myDataAdapter.Fill(myDataSet);
                int MaxItemID = 0;
                try
                {
                    MaxItemID = Convert.ToInt32(myDataSet.Tables[0].Rows[0].ItemArray[0]);
                }
                catch (Exception ex)
                {
                    try
                    {
                        MaxItemID = 0;
                    }
                    catch (Exception ex1)
                    {
                        myConnection1.Close();
                        return ex1.Message.ToString();
                    }
                }
                myConnection1.Close();

                byte[] content = null;
                MemoryStream _image1 = new MemoryStream();
                using (FileStream fileStream = File.OpenRead(ImagePath))
                {
                    _image1.SetLength(fileStream.Length);
                    fileStream.Read(_image1.GetBuffer(), 0, (int)fileStream.Length);
                }
                try
                {
                    myConnection1.Open();
                    FbTransaction myTransaction = myConnection1.BeginTransaction();

                    FbCommand myCommand = new FbCommand();

                    myCommand.CommandText = "INSERT INTO ITEM (ID, CODE, MODEL, QTY_BOX, PRICE,IMAGE, CATEGORYNAME,T_QUANTITY)VALUES(@ID, @CODE, @MODEL ,@QTY_BOX ,@PRICE ,@IMAGE,@CATEGORYNAME ,@T_QUANTITY)";
                    myCommand.Connection = myConnection1;
                    myCommand.Transaction = myTransaction;


                    myCommand.Parameters.Add("@ID", FbDbType.Integer).Value = ++MaxItemID;
                    myCommand.Parameters.Add("@CODE", FbDbType.VarChar).Value = Name;
                    myCommand.Parameters.Add("@MODEL", FbDbType.VarChar).Value = Model;
                    myCommand.Parameters.Add("@QTY_BOX", FbDbType.Integer).Value = QTY_Box;
                    myCommand.Parameters.Add("@PRICE", FbDbType.Decimal).Value = Price;
                    myCommand.Parameters.Add("@COSTPRICE", FbDbType.Decimal).Value = CostPrice;
                    if (_image1 != null)
                        content = _image1.ToArray();
                    myCommand.Parameters.Add("@IMAGE", FbDbType.Binary).Value = content;
                    myCommand.Parameters.Add("@CATEGORYNAME", FbDbType.VarChar).Value = "Toys";
                    myCommand.Parameters.Add("@T_QUANTITY", FbDbType.Integer).Value = 0;
                    myCommand.ExecuteNonQuery();
                    myTransaction.Commit();
                    myCommand.Dispose();
                    myConnection1.Close();
                    return "Item Added with ID = " + MaxItemID.ToString();
                }
                catch (FbException ex)
                {
                    myConnection1.Close();
                    return ex.Message.ToString();
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            }
            return null;
        }

        internal static string DeleteItem(string Name)
        {
            try
            {
                FbConnection deleteConnection = new FbConnection(Variables.DatabaseConnectString);
                deleteConnection.Open();

                FbTransaction deleteTransaction = deleteConnection.BeginTransaction();
                FbCommand deleteCommand = new FbCommand("Delete From Item where Name = " + "'" + Name + "'", deleteConnection, deleteTransaction);

                deleteCommand.ExecuteNonQuery();
                deleteTransaction.Commit();
                deleteConnection.Close();
                return "Item Deleted";
            }
            catch (Exception x)
            {
                return x.Message.ToString();
            }
        }

        internal static string ModifyItems(string FindName, string ReplaceName)
        {
            try
            {
                FbConnection deleteConnection = new FbConnection(Variables.DatabaseConnectString);
                deleteConnection.Open();

                FbTransaction deleteTransaction = deleteConnection.BeginTransaction();
                FbCommand deleteCommand = new FbCommand("Update Item set Name = '" + ReplaceName + "' where Name = " + "'" + FindName + "'", deleteConnection, deleteTransaction);

                deleteCommand.ExecuteNonQuery();
                deleteTransaction.Commit();
                deleteConnection.Close();
                return "Item Modified to " + FindName;
            }
            catch (Exception x)
            {
                return x.Message.ToString();
            }
        }

        internal static string ModifyItems(string FindID, string ReplaceName, string ReplaceModel, string ReplaceQuantity, string ReplacePrice, string ReplaceCostPrice, System.Windows.Forms.PictureBox ReplaceImage, string ItemCategory, int T_Quantity)
        {
            try
            {
                byte[] content = null;
                MemoryStream _image1 = new MemoryStream();
                if (ReplaceImage.ImageLocation != null && ReplaceImage.ImageLocation != "")
                {
                    using (FileStream fileStream = File.OpenRead(ReplaceImage.ImageLocation))
                    {
                        _image1.SetLength(fileStream.Length);
                        fileStream.Read(_image1.GetBuffer(), 0, (int)fileStream.Length);
                    }
                }
                else
                {
                    string ImagePath = "A-Z.png";
                    using (FileStream fileStream = File.OpenRead(ImagePath))
                    {
                        _image1.SetLength(fileStream.Length);
                        fileStream.Read(_image1.GetBuffer(), 0, (int)fileStream.Length);
                    }
                }
                FbConnection ModifyItemConnection = new FbConnection(Variables.DatabaseConnectString);
                try
                {
                    ModifyItemConnection.Open();
                    FbTransaction myTransaction = ModifyItemConnection.BeginTransaction();

                    FbCommand myCommand = new FbCommand();
                    myCommand.CommandText = "Update Item set Price = @PRICE , CODE = @NAME , Model = @MODEL,Qty_Box= @QTY_BOX , IMAGE = @IMAGE, CATEGORYNAME = @CATEGORYNAME,T_QUANTITY = @T_QUANTITY where ID = @ID";
                    myCommand.Connection = ModifyItemConnection;
                    myCommand.Transaction = myTransaction;


                    myCommand.Parameters.Add("@ID", FbDbType.Integer).Value = FindID;
                    myCommand.Parameters.Add("@NAME", FbDbType.VarChar).Value = ReplaceName;
                    myCommand.Parameters.Add("@MODEL", FbDbType.Integer).Value = ReplaceModel;
                    myCommand.Parameters.Add("@QTY_BOX", FbDbType.Integer).Value = ReplaceQuantity;
                    myCommand.Parameters.Add("@PRICE", FbDbType.Decimal).Value = ReplacePrice;
                    myCommand.Parameters.Add("@COSTPRICE", FbDbType.Decimal).Value = ReplaceCostPrice;
                    if (_image1 != null)
                        content = _image1.ToArray();
                    myCommand.Parameters.Add("@IMAGE", FbDbType.Binary).Value = content;
                    myCommand.Parameters.Add("@CATEGORYNAME", FbDbType.VarChar).Value = ItemCategory;
                    myCommand.Parameters.Add("@T_QUANTITY", FbDbType.Integer).Value = T_Quantity;
                    myCommand.ExecuteNonQuery();
                    myTransaction.Commit();
                    myCommand.Dispose();
                    ModifyItemConnection.Close();
                    return "Item modified " + FindID.ToString() + " Modified...";
                }
                catch (FbException ex)
                {
                    ModifyItemConnection.Close();
                    return ex.Message.ToString();
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            }
            return null;
        }

        internal static DataSet GetItems()
        {
            FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
            DataSet myDataSet = new DataSet();
            try
            {

                myConnection1.Open();


                FbDataAdapter myDataAdapter = new FbDataAdapter("Select * from Item", myConnection1);
                myDataAdapter.Fill(myDataSet);
                //myDataSet.Tables[0].Columns["NAME"].ColumnName = "Item Code";
                myConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myConnection1.Close();
                return null;
            }
            return myDataSet;
        }

        internal static DataSet GetItems(String ItemField)
        {
            try
            {
                FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
                myConnection1.Open();

                DataSet myDataSet = new DataSet();

                FbDataAdapter myDataAdapter = new FbDataAdapter("Select " + ItemField + " from Item", myConnection1);

                myDataAdapter.Fill(myDataSet);
                myConnection1.Close();

                return myDataSet;
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            }
            return null;
        }

        internal static DataSet GetCategory()
        {
            try
            {
                FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
                myConnection1.Open();

                DataSet myDataSet = new DataSet();

                FbDataAdapter myDataAdapter = new FbDataAdapter("Select CATEGORYNAME from ITEMCATEGORY", myConnection1);

                myDataAdapter.Fill(myDataSet);
                myConnection1.Close();

                return myDataSet;
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            }
            return null;
        }

        internal static string AddCategory(System.Windows.Forms.ComboBox ItemCategory_txt)
        {
            FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
            try
            {
                myConnection1.Open();
                FbTransaction myTransaction = myConnection1.BeginTransaction();
                FbCommand myCommand = new FbCommand();

                myCommand.CommandText = "INSERT INTO ITEMCATEGORY (CATEGORYNAME)VALUES(@CATEGORYNAME)";
                myCommand.Connection = myConnection1;
                myCommand.Transaction = myTransaction;


                myCommand.Parameters.Add("@CATEGORYNAME", FbDbType.VarChar).Value = ItemCategory_txt.Text;
                myCommand.ExecuteNonQuery();
                myTransaction.Commit();
                myCommand.Dispose();
                myConnection1.Close();
                return "Category added " + ItemCategory_txt.Text.ToString() + " Added ";
            }
            catch (Exception ex)
            {
                myConnection1.Close();
                return ex.Message.ToString();
            }
        }

        internal static DataSet GetItemDetails(string FindTable, string FindString)
        {
            FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
            DataSet myDataSet = new DataSet();
            try
            {

                myConnection1.Open();


                FbDataAdapter myDataAdapter = new FbDataAdapter("Select * from Item where " + FindTable + " = '" + FindString + "'", myConnection1);
                myDataAdapter.Fill(myDataSet);
                //myDataSet.Tables[0].Columns["NAME"].ColumnName = "Item Code";
                myConnection1.Close();
            }
            catch (Exception ex)
            {
                myConnection1.Close();
                return null;
            }
            return myDataSet;
        }

        internal static string AddItemQutantity(string ItemName, int ItemQuantity)
        {
            try
            {
                FbConnection deleteConnection = new FbConnection(Variables.DatabaseConnectString);
                deleteConnection.Open();

                FbTransaction deleteTransaction = deleteConnection.BeginTransaction();
                FbCommand deleteCommand = new FbCommand("Update Item set T_QUANTITY = " + ItemQuantity + " where CODE = " + "'" + ItemName + "'", deleteConnection, deleteTransaction);

                deleteCommand.ExecuteNonQuery();
                deleteTransaction.Commit();
                deleteConnection.Close();
                return "Item Quantity Modified to " + ItemQuantity.ToString();
            }
            catch (Exception x)
            {
                return x.Message.ToString();
            }
        }

        internal static DataSet GetItemHistory(string ItemCode)
        {
            try
            {
                FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
                myConnection1.Open();

                DataSet myDataSet = new DataSet();

                FbDataAdapter myDataAdapter = new FbDataAdapter("Select * from ITEMHISTORY where ITEM_CODE = '" + ItemCode + "'", myConnection1);

                myDataAdapter.Fill(myDataSet);
                myConnection1.Close();

                return myDataSet;
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            }
            return null;
        }

        internal static DataSet GetItemSaleHistory(string p)
        {
            try
            {
                FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
                myConnection1.Open();

                DataSet myDataSet = new DataSet();
                FbDataAdapter myDataAdapter = new FbDataAdapter("SELECT SALE.ID, SALE.QTY, SALE.BILL_ID, SALE.ITEM_CODE, SALE.ITEM_NAME, SALE.PCS_CTN, SALE.T_QUANTITY, SALE.UNITPRICE, SALE.SUBTOTAL, CUSTOMERS.NAME , BILL.DATED from SALE,CUSTOMERS,BILL where ITEM_CODE = '" + p + "' AND CUSTOMERS.ID = SALE.CUSTOMER_ID AND SALE.BILL_ID > 0 AND SALE.BILL_ID = BILL.ID", myConnection1);

                myDataAdapter.Fill(myDataSet);
                myConnection1.Close();

                return myDataSet;
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            }
            return null;
        }

        internal static DataSet GetItemShipmentHistory(string p)
        {
            try
            {
                FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
                myConnection1.Open();

                DataSet myDataSet = new DataSet();


                FbDataAdapter myDataAdapter = new FbDataAdapter("Select a.ID, a.SHIP_ID, a.ITEM_CODE, a.T_QUANTITY, a.QTY_PER_BOX, a.MODEL, a.CTN, a.PRICE, a.SUBTOTAL ,b.SHIP_DATE from SHIPMENT_DETAIL a,SHIPMENT b where ITEM_CODE = '" + p + "' AND a.SHIP_ID = b.ID", myConnection1);

                myDataAdapter.Fill(myDataSet);
                myConnection1.Close();

                return myDataSet;
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            }
            return null;
        }

        internal static DataSet GetItemsForSale()
        {
            try
            {
                FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
                myConnection1.Open();

                DataSet myDataSet = new DataSet();

                FbDataAdapter myDataAdapter = new FbDataAdapter("SELECT a.ID, a.QTY_BOX, a.PRICE, ((a.SHIPMENTQUANTITY+a.SALEQUANTITY)) as Quantity, ((a.SHIPMENTQUANTITY+a.SALEQUANTITY)/a.QTY_BOX) as CTN_LEFT, a.CODE, a.MODEL FROM ITEMINVENTORY a where ((a.SHIPMENTQUANTITY+a.SALEQUANTITY)/a.QTY_BOX) > 0", myConnection1);

                myDataAdapter.Fill(myDataSet);
                myConnection1.Close();

                return myDataSet;
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            }
            return null;


            throw new NotImplementedException();
        }

        internal static DataSet GetItemsForBill()
        {
            try
            {
                FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
                myConnection1.Open();

                DataSet myDataSet = new DataSet();

                FbDataAdapter myDataAdapter = new FbDataAdapter("SELECT a.ID, a.QTY_BOX, a.PRICE, a.SHIPCTN, a.SALECTN, a.MODEL, a.CODE FROM ITEMINVENTORY a where (a.SHIPCTN-a.SALECTN) > 0", myConnection1);
                myDataAdapter.Fill(myDataSet);
                myConnection1.Close();

                return myDataSet;
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            }
            return null;


            throw new NotImplementedException();
        }

        internal static int GetItemCount(string ItemCode)
        {
            FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
            try
            {
                myConnection1.Open();

                DataSet myDataSet = new DataSet();

                FbDataAdapter myDataAdapter = new FbDataAdapter("SELECT SALECTN, SHIPCTN, SALEQUANTITY, SHIPMENTQUANTITY FROM ITEMINVENTORY WHERE (CODE = '" + ItemCode + "')", myConnection1);
                //"Select SALEQUANTITY,SHIPMENTQUANTITY from ITEMINVENTORY where CODE = '" + p + "'", myConnection1);

                myDataAdapter.Fill(myDataSet);
                myConnection1.Close();//=Fields!SHIPCTN.Value- Fields!SALECTN.Value
                return Convert.ToInt32(myDataSet.Tables[0].Rows[0]["SHIPCTN"]) - Convert.ToInt32(myDataSet.Tables[0].Rows[0]["SALECTN"]);
            }
            catch (Exception ex)
            {
                myConnection1.Close();
                return 0;
            }
        }

        internal static string ModifyItemPrice(string ItemName, decimal ItemPrice)
        {
            try
            {
                FbConnection deleteConnection = new FbConnection(Variables.DatabaseConnectString);
                deleteConnection.Open();

                FbTransaction deleteTransaction = deleteConnection.BeginTransaction();
                FbCommand deleteCommand = new FbCommand("Update Item set PRICE = " + ItemPrice + " where CODE = " + "'" + ItemName + "'", deleteConnection, deleteTransaction);

                deleteCommand.ExecuteNonQuery();
                deleteTransaction.Commit();
                deleteConnection.Close();
                return "Item Price Modified to " + ItemPrice.ToString();
            }
            catch (Exception x)
            {
                return x.Message.ToString();
            }
        }

        internal static DataSet GetInventoryDetails()
        {
            try
            {
                FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
                myConnection1.Open();

                DataSet ItemDataSet = new DataSet();
                FbDataAdapter ItemDataAdapter = new FbDataAdapter("Select * from ITEM", myConnection1);
                ItemDataAdapter.Fill(ItemDataSet);
                ItemDataSet.Tables[0].Columns.Add("Total Quantity", typeof(string));
                ItemDataSet.Tables[0].Columns[7].SetOrdinal(2);

                DataSet SaleDataSet = new DataSet();
                FbDataAdapter SaleDataAdapter = new FbDataAdapter("Select ITEM_CODE, QTY from SALE", myConnection1);// WHERE ITEM_CODE = '" + asdf.ItemArray[1] + "'", myConnection1);
                SaleDataAdapter.Fill(SaleDataSet);

                DataSet ShipmentDataSet = new DataSet();
                FbDataAdapter ShipmentDataAdapter = new FbDataAdapter("Select ITEM_CODE, T_QUANTITY from SHIPMENT_DETAIL", myConnection1);// WHERE ITEM_CODE = '" + asdf.ItemArray[1] + "'", myConnection1);
                ShipmentDataAdapter.Fill(ShipmentDataSet);
                myConnection1.Close();

                for (int loop = 0; loop < ItemDataSet.Tables[0].Rows.Count; loop++)// DataRow ItemDataRow in ItemDataSet.Tables[0].Rows)
                {
                    string SalesCount = "0";
                    foreach (DataRow SalesRow in SaleDataSet.Tables[0].Rows)
                    {
                        if (SalesRow["ITEM_CODE"].Equals(ItemDataSet.Tables[0].Rows[loop]["CODE"]))
                            SalesCount = SalesRow["QTY"].ToString();
                    }

                    string ShipmentCount = "0";
                    foreach (DataRow ShipmentRow in ShipmentDataSet.Tables[0].Rows)
                    {
                        if (ShipmentRow["ITEM_CODE"].Equals(ItemDataSet.Tables[0].Rows[loop]["CODE"]))
                            ShipmentCount = ShipmentRow["T_QUANTITY"].ToString();
                    }

                    int TotalCount = Convert.ToInt32(ShipmentCount) - Convert.ToInt32(SalesCount);
                    ItemDataSet.Tables[0].Rows[loop]["Total Quantity"] = TotalCount.ToString();
                }
                return ItemDataSet;
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            }
            return null;
        }

        //Consignments
        internal static DataSet GetConsignments()
        {
            try
            {
                FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
                myConnection1.Open();

                DataSet myDataSet = new DataSet();

                FbDataAdapter myDataAdapter = new FbDataAdapter("Select * from SHIPMENT", myConnection1);

                myDataAdapter.Fill(myDataSet);
                myConnection1.Close();

                return myDataSet;
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            }
            return null;
        }

        internal static string AddConsignment(string ConsignmentNumber, DateTime ConsignmentDate)
        {
            FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
            try
            {
                myConnection1.Open();
                FbTransaction myTransaction = myConnection1.BeginTransaction();

                FbCommand myCommand = new FbCommand();

                myCommand.CommandText = "INSERT INTO SHIPMENT(ID, SHIP_DATE, DESCRIPTION)VALUES(@ID, @SHIP_DATE, @DESCRIPTION)";
                myCommand.Connection = myConnection1;
                myCommand.Transaction = myTransaction;


                myCommand.Parameters.Add("@ID", FbDbType.VarChar).Value = ConsignmentNumber;
                myCommand.Parameters.Add("@SHIP_DATE", FbDbType.Date).Value = ConsignmentDate;
                myCommand.Parameters.Add("@DESCRIPTION", FbDbType.VarChar).Value = "None";
                myCommand.ExecuteNonQuery();
                myTransaction.Commit();
                myCommand.Dispose();
                myConnection1.Close();
                return "Consignment Added with ID = " + ConsignmentNumber.ToString();
            }
            catch (FbException ex)
            {
                myConnection1.Close();
                return ex.Message.ToString();
            }
        }

        internal static string ModifyConsignment(string FindID, DateTime ConsignmentDate, string ConsignmentDesc)
        {
            FbConnection ModifyConsignmentConnection = new FbConnection(Variables.DatabaseConnectString);
            try
            {
                ModifyConsignmentConnection.Open();
                FbTransaction myTransaction = ModifyConsignmentConnection.BeginTransaction();

                FbCommand myCommand = new FbCommand();
                myCommand.CommandText = "Update SHIPMENT set ID = @ID , SHIP_DATE = @SHIP_DATE , DESCRIPTION = @DESCRIPTION";
                myCommand.Connection = ModifyConsignmentConnection;
                myCommand.Transaction = myTransaction;


                myCommand.Parameters.Add("@ID", FbDbType.Integer).Value = FindID;
                myCommand.Parameters.Add("@SHIP_DATE", FbDbType.VarChar).Value = ConsignmentDate;
                myCommand.Parameters.Add("@DESCRIPTION", FbDbType.Integer).Value = ConsignmentDesc;
                myCommand.ExecuteNonQuery();
                myTransaction.Commit();
                myCommand.Dispose();
                ModifyConsignmentConnection.Close();
                return "Consignment added " + FindID.ToString() + " Modified...";
            }
            catch (FbException ex)
            {
                ModifyConsignmentConnection.Close();
                return ex.Message.ToString();
            }
        }
        
        internal static DataSet GetConsignmentDetails()
        {
            try
            {
                FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
                myConnection1.Open();

                DataSet myDataSet = new DataSet();

                FbDataAdapter myDataAdapter = new FbDataAdapter("Select * from SHIPMENT_DETAIL", myConnection1);

                myDataAdapter.Fill(myDataSet);
                myConnection1.Close();

                return myDataSet;
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            }
            return null;
        }

        internal static string AddConsignmentDetail(string ItemName, string ShipID, int T_QUANTITY, int QTY_PER_BOX, string MODEL, int CTN, decimal PRICE, decimal SUBTOTAL)
        {
            FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
            try
            {
                myConnection1.Open();
                //4. create a new DataSet
                DataSet myDataSet = new DataSet();

                //5. Declare an Adapter to interface with our Table in Firebird
                FbDataAdapter myDataAdapter = new FbDataAdapter("Select MAX(ID) from SHIPMENT_DETAIL", myConnection1);

                //6. Fill the Dataset
                myDataAdapter.Fill(myDataSet);
                int MaxCustomerID = 0;
                try
                {
                    MaxCustomerID = Convert.ToInt32(myDataSet.Tables[0].Rows[0].ItemArray[0]);
                }
                catch (Exception ex)
                {
                    try
                    {
                        MaxCustomerID = 0;
                    }
                    catch (Exception ex1)
                    {
                        myConnection1.Close();
                        return ex1.Message.ToString();
                    }
                }
                FbTransaction myTransaction = myConnection1.BeginTransaction();
                FbCommand myCommand = new FbCommand();

                myCommand.CommandText = "INSERT INTO SHIPMENT_DETAIL (ID, SHIP_ID ,ITEM_CODE ,T_QUANTITY , QTY_PER_BOX ,MODEL ,CTN, PRICE ,SUBTOTAL)VALUES(@ID, @SHIP_ID , @ITEM_CODE , @T_QUANTITY , @QTY_PER_BOX , @MODEL , @CTN, @PRICE,@SUBTOTAL)";
                myCommand.Connection = myConnection1;
                myCommand.Transaction = myTransaction;

                myCommand.Parameters.Add("@ID", FbDbType.VarChar).Value = ++MaxCustomerID;
                myCommand.Parameters.Add("@SHIP_ID", FbDbType.VarChar).Value = ShipID;
                myCommand.Parameters.Add("@ITEM_CODE", FbDbType.VarChar).Value = ItemName;
                myCommand.Parameters.Add("@T_QUANTITY", FbDbType.Integer).Value = T_QUANTITY;
                myCommand.Parameters.Add("@QTY_PER_BOX", FbDbType.Integer).Value = QTY_PER_BOX;
                myCommand.Parameters.Add("@MODEL", FbDbType.VarChar).Value = MODEL;
                myCommand.Parameters.Add("@CTN", FbDbType.Integer).Value = CTN;
                myCommand.Parameters.Add("@PRICE", FbDbType.Decimal).Value = PRICE;
                myCommand.Parameters.Add("@SUBTOTAL", FbDbType.Decimal).Value = SUBTOTAL;

                myCommand.ExecuteNonQuery();
                myTransaction.Commit();
                myCommand.Dispose();
                myConnection1.Close();
                return "Consignment added with id " + MaxCustomerID;
            }
            catch (Exception ex)
            {
                myConnection1.Close();
                return ex.Message.ToString();
            }
        }

        //Bill
        internal static int GetNewBillNumber()
        {
            try
            {
                FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
                myConnection1.Open();
                DataSet myDataSet = new DataSet();
                FbDataAdapter myDataAdapter = new FbDataAdapter("Select MAX(ID) from BILL", myConnection1);
                myDataAdapter.Fill(myDataSet);
                myConnection1.Close();
                if (myDataSet.Tables[0].Rows[0].ItemArray[0].ToString() == "")
                    return 0;
                return Convert.ToInt32(myDataSet.Tables[0].Rows[0].ItemArray[0].ToString());
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            }
            return 0;
        }

        internal static string AddBill(int BillNumber, int CustomerID, DateTime BillDate, decimal BillTotal, decimal CustomerBalance, string Remarks)
        {
            FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
            myConnection1.Open();
            try
            {
                FbTransaction myTransaction = myConnection1.BeginTransaction();
                FbCommand myCommand = new FbCommand();

                myCommand.CommandText = "INSERT INTO BILL (ID, CUSTOMER_ID, DATED, AMOUNT,REMARKS, CUSTOMER_BALANCE)VALUES(@ID, @CUSTOMER_ID, @DATED, @AMOUNT,@REMARKS, @CUSTOMER_BALANCE)";
                myCommand.Connection = myConnection1;
                myCommand.Transaction = myTransaction;

                myCommand.Parameters.Add("@ID", FbDbType.Integer).Value = BillNumber;
                myCommand.Parameters.Add("@CUSTOMER_ID", FbDbType.Integer).Value = CustomerID;
                myCommand.Parameters.Add("@DATED", FbDbType.Date).Value = BillDate;
                myCommand.Parameters.Add("@AMOUNT", FbDbType.Decimal).Value = BillTotal;
                myCommand.Parameters.Add("@REMARKS", FbDbType.Decimal).Value = Remarks;
                myCommand.Parameters.Add("@CUSTOMER_BALANCE", FbDbType.Decimal).Value = CustomerBalance;


                myCommand.ExecuteNonQuery();
                myTransaction.Commit();
                myCommand.Dispose();
                myConnection1.Close();
                string result = ModifyCustomer(CustomerID, CustomerBalance);
                if (result.StartsWith("Customer Balance Updated to") != true)
                    return result;
                return "Bill Added with ID = " + BillNumber.ToString();
            }
            catch (Exception ex)
            {
                myConnection1.Close();
                return ex.Message.ToString();
            }
        }

        internal static DataSet GetBills()
        {
            try
            {
                FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
                myConnection1.Open();

                DataSet myDataSet = new DataSet();

                FbDataAdapter myDataAdapter = new FbDataAdapter("SELECT a.ID, b.NAME, a.DATED, a.AMOUNT, a.REMARKS, a.CUSTOMER_BALANCE,a.CUSTOMER_ID  FROM BILL a,CUSTOMERS b where a.CUSTOMER_ID = b.ID ORDER BY ID DESC", myConnection1);//"Select * from BILL ORDER BY ID DESC", myConnection1);

                myDataAdapter.Fill(myDataSet);
                myConnection1.Close();

                return myDataSet;
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            }
            return null;
        }

        internal static DataSet GetBill(string BillNumber)
        {
            try
            {
                FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
                myConnection1.Open();

                DataSet myDataSet = new DataSet();

                FbDataAdapter myDataAdapter = new FbDataAdapter("Select * from BILL where ID = '" + BillNumber + "'", myConnection1);

                myDataAdapter.Fill(myDataSet);
                myConnection1.Close();

                return myDataSet;
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            }
            return null;
        }

        internal static string DeleteBill(string BillNumber)
        {
            try
            {
                FbConnection deleteConnection = new FbConnection(Variables.DatabaseConnectString);
                deleteConnection.Open();
                FbTransaction deleteTransaction = deleteConnection.BeginTransaction();
                FbCommand deleteCommand = new FbCommand("Update BILL set AMOUNT = '" + 0 + "' where ID = " + "'" + BillNumber + "'", deleteConnection, deleteTransaction);
                deleteCommand.ExecuteNonQuery();
                deleteTransaction.Commit();
                deleteConnection.Close();
                return "Bill Deleted...";
            }
            catch (Exception x)
            {
                return x.Message.ToString();
            }
        }

        internal static string DeleteBillDetails(string BillNumber)
        {
            try
            {
                FbConnection deleteConnection = new FbConnection(Variables.DatabaseConnectString);
                deleteConnection.Open();

                FbTransaction deleteTransaction = deleteConnection.BeginTransaction();
                FbCommand deleteCommand = new FbCommand("Delete From SALE where BILL_ID = " + "'" + BillNumber + "'", deleteConnection, deleteTransaction);

                deleteCommand.ExecuteNonQuery();
                deleteTransaction.Commit();
                deleteConnection.Close();
                return "Bill detail Deleted...";
            }
            catch (Exception x)
            {
                return x.Message.ToString();
            }
        }

        internal static DataSet GetBillsbyCustomer(string CustomerID)
        {
            try
            {
                FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
                myConnection1.Open();

                DataSet myDataSet = new DataSet();

                FbDataAdapter myDataAdapter = new FbDataAdapter("Select * from BILL where CUSTOMER_ID = '" + CustomerID + "'", myConnection1);

                myDataAdapter.Fill(myDataSet);
                myConnection1.Close();

                return myDataSet;
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            }
            return null;
        }

        internal static string ModifyBillAmmount(int BillNumber, decimal CustomerBalance)
        {
            try
            {
                FbConnection deleteConnection = new FbConnection(Variables.DatabaseConnectString);
                deleteConnection.Open();
                FbTransaction deleteTransaction = deleteConnection.BeginTransaction();
                FbCommand deleteCommand = new FbCommand("Update BILL set AMOUNT = '" + CustomerBalance.ToString() + "',CUSTOMER_BALANCE = '" + CustomerBalance.ToString() + "' where ID = " + "'" + BillNumber.ToString() + "'", deleteConnection, deleteTransaction);
                deleteCommand.ExecuteNonQuery();
                deleteTransaction.Commit();
                deleteConnection.Close();
                return "Bill Modified...";
            }
            catch (Exception x)
            {
                return x.Message.ToString();
            }
        }

        internal static DataSet GetBillDetails(string BillNumber)
        {
            try
            {
                FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
                myConnection1.Open();

                DataSet myDataSet = new DataSet();

                FbDataAdapter myDataAdapter = new FbDataAdapter("Select * from BILL where ID = '" + BillNumber + "'", myConnection1);

                myDataAdapter.Fill(myDataSet);
                myConnection1.Close();

                return myDataSet;
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            }
            return null;
        }

        //Sale
        internal static string AddSale(decimal UnitPrice, int QTY, int BILL_ID, decimal SUBTOTAL, String ITEM_CODE, string ITEM_NAME, int PCS_CTN, int QUANT, int CUSTOMER_ID)
        {
            try
            {
                FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);

                myConnection1.Open();

                //4. create a new DataSet
                DataSet myDataSet = new DataSet();

                //5. Declare an Adapter to interface with our Table in Firebird
                FbDataAdapter myDataAdapter = new FbDataAdapter("Select MAX(ID) from SALE", myConnection1);

                //6. Fill the Dataset
                myDataAdapter.Fill(myDataSet);
                int MaxSaleID = 0;
                try
                {
                    MaxSaleID = Convert.ToInt32(myDataSet.Tables[0].Rows[0].ItemArray[0]);
                }
                catch (Exception ex)
                {
                    try
                    {
                        MaxSaleID = 0;
                    }
                    catch (Exception ex1)
                    {
                        myConnection1.Close();
                        return ex1.Message.ToString();
                    }
                }
                try
                {
                    FbTransaction myTransaction = myConnection1.BeginTransaction();
                    FbCommand myCommand = new FbCommand();

                    myCommand.CommandText = "INSERT INTO SALE (ID, QTY ,BILL_ID ,ITEM_CODE ,ITEM_NAME, PCS_CTN, T_Quantity, UNITPRICE, SUBTOTAL, CUSTOMER_ID)VALUES(@ID, @QTY ,@BILL_ID ,@ITEM_CODE ,@ITEM_NAME, @PCS_CTN, @QUANT, @UNITPRICE, @SUBTOTAL, @CUSTOMER_ID)";
                    myCommand.Connection = myConnection1;
                    myCommand.Transaction = myTransaction;

                    myCommand.Parameters.Add("@ID", FbDbType.Integer).Value = ++MaxSaleID;
                    myCommand.Parameters.Add("@QTY", FbDbType.Integer).Value = QTY;
                    myCommand.Parameters.Add("@BILL_ID", FbDbType.Integer).Value = BILL_ID;
                    myCommand.Parameters.Add("@ITEM_CODE", FbDbType.VarChar).Value = ITEM_CODE;
                    myCommand.Parameters.Add("@ITEM_NAME", FbDbType.VarChar).Value = ITEM_NAME;
                    myCommand.Parameters.Add("@PCS_CTN", FbDbType.Integer).Value = PCS_CTN;
                    myCommand.Parameters.Add("@QUANT", FbDbType.Integer).Value = (QUANT * (-1));
                    myCommand.Parameters.Add("@UNITPRICE", FbDbType.Decimal).Value = UnitPrice;
                    myCommand.Parameters.Add("@SUBTOTAL", FbDbType.Decimal).Value = SUBTOTAL;
                    myCommand.Parameters.Add("@CUSTOMER_ID", FbDbType.Integer).Value = CUSTOMER_ID;

                    myCommand.ExecuteNonQuery();
                    myTransaction.Commit();
                    myCommand.Dispose();
                    myConnection1.Close();
                    return "Sale Added with ID = " + MaxSaleID.ToString();
                }
                catch (Exception ex)
                {
                    Variables.NotificationMessageTitle = "Database Calls";
                    Variables.NotificationMessageText = "Add the admin Bill and Customer";
                    Variables.NotificationStatus = true;
                    myConnection1.Close();
                    return ex.Message.ToString();
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            }
            return null;
        }

        internal static DataSet GetSale(string Bill_ID)
        {
            try
            {
                FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
                myConnection1.Open();

                DataSet myDataSet = new DataSet();

                FbDataAdapter myDataAdapter = new FbDataAdapter("Select * from SALE WHERE BILL_ID = '" + Bill_ID + "'", myConnection1);

                myDataAdapter.Fill(myDataSet);
                myConnection1.Close();

                return myDataSet;
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            }
            return null;
        }

        internal static string AddVoucherPayment(int CustomerID, DateTime BillDate, Decimal BillTotal, string Remarks, Decimal CustomerBalance)
        {
            int VoucherID = GetNewVoucherNumber();

            FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
            myConnection1.Open();
            try
            {
                FbTransaction myTransaction = myConnection1.BeginTransaction();
                FbCommand myCommand = new FbCommand();

                myCommand.CommandText = "INSERT INTO BILL (ID, CUSTOMER_ID, DATED , AMOUNT, REMARKS, CUSTOMER_BALANCE)VALUES(@ID, @CUSTOMER_ID, @VOUCHER_DATE, @AMOUNT, @REMARKS, @CUSTOMER_BALANCE)";
                myCommand.Connection = myConnection1;
                myCommand.Transaction = myTransaction;

                myCommand.Parameters.Add("@ID", FbDbType.Integer).Value = VoucherID;
                myCommand.Parameters.Add("@CUSTOMER_ID", FbDbType.Integer).Value = CustomerID;
                myCommand.Parameters.Add("@VOUCHER_DATE", FbDbType.Date).Value = BillDate;
                myCommand.Parameters.Add("@AMOUNT", FbDbType.Decimal).Value = BillTotal;
                myCommand.Parameters.Add("@REMARKS", FbDbType.VarChar).Value = Remarks;
                myCommand.Parameters.Add("@CUSTOMER_BALANCE", FbDbType.Decimal).Value = CustomerBalance;

                myCommand.ExecuteNonQuery();
                myTransaction.Commit();
                myCommand.Dispose();
                myConnection1.Close();
                string result = ModifyCustomer(CustomerID, CustomerBalance);
                if (result.StartsWith("Customer Balance Updated to") != true)
                    return result;
                return "Voucher Added with ID = " + VoucherID.ToString();
            }
            catch (Exception ex)
            {
                myConnection1.Close();
                return ex.Message.ToString();
            }
        }

        internal static int GetNewVoucherNumber()
        {
            try
            {
                FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
                myConnection1.Open();
                DataSet myDataSet = new DataSet();
                FbDataAdapter myDataAdapter = new FbDataAdapter("Select MIN(ID) from BILL", myConnection1);
                myDataAdapter.Fill(myDataSet);
                myConnection1.Close();
                if (myDataSet.Tables[0].Rows[0].ItemArray[0].ToString() == "")
                    return 0;
                return Convert.ToInt32(myDataSet.Tables[0].Rows[0].ItemArray[0].ToString()) - 1;
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            }
            return 0;
        }

        internal static DataSet GetLedger(string CustomerID)
        {
            try
            {
                FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
                myConnection1.Open();

                DataSet myDataSet = new DataSet();
                FbDataAdapter myDataAdapter = new FbDataAdapter();
                if (CustomerID == "All")
                    myDataAdapter = new FbDataAdapter("Select * from BILL", myConnection1);
                else
                    myDataAdapter = new FbDataAdapter("Select * from BILL WHERE CUSTOMER_ID = '" + CustomerID + "'", myConnection1);

                myDataAdapter.Fill(myDataSet);


                //if (CustomerID == "All")
                //    myDataAdapter = new FbDataAdapter("Select * from BILL", myConnection1);
                //else
                //    myDataAdapter = new FbDataAdapter("Select * from BILL WHERE CUSTOMER_ID = '" + CustomerID + "' ", myConnection1);

                //myDataAdapter.Fill(myDataSet);



                myConnection1.Close();

                return myDataSet;
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            }
            return null;
        }

        internal static DataSet GetVouchers()
        {
            try
            {
                FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
                myConnection1.Open();

                DataSet myDataSet = new DataSet();

                FbDataAdapter myDataAdapter = new FbDataAdapter("Select * from BILL", myConnection1);

                myDataAdapter.Fill(myDataSet);
                myConnection1.Close();

                return myDataSet;
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            }
            return null;
        }

        internal static string ModifyVoucher(int ID, decimal UpdateAmount, decimal UpdateCUSTOMER_BALANCE)
        {
            try
            {
                FbConnection deleteConnection = new FbConnection(Variables.DatabaseConnectString);
                deleteConnection.Open();
                FbTransaction deleteTransaction = deleteConnection.BeginTransaction();
                FbCommand deleteCommand = new FbCommand("Update BILL set AMOUNT = '" + UpdateAmount + "',CUSTOMER_BALANCE = '" + UpdateCUSTOMER_BALANCE + "' where ID = " + "'" + ID + "'", deleteConnection, deleteTransaction);
                deleteCommand.ExecuteNonQuery();
                deleteTransaction.Commit();
                deleteConnection.Close();
                return "Customer Balance Updated to " + UpdateAmount.ToString();
            }
            catch (Exception x)
            {
                return x.Message.ToString();
            }
        }

        internal static decimal GetCurrentRowBalance(string CustomerID, string Billnumber)
        {
            decimal CalulateBalance = 0;
            DataSet _BillDataSet = GetBill(Billnumber);
            try
            {
                if (_BillDataSet.Tables[0].Rows.Count == 0)
                {
                    DataSet _BillbyCustomerDataSet = GetBillsbyCustomer(CustomerID);
                    foreach (DataRow BillRow in _BillbyCustomerDataSet.Tables[0].Rows)
                    {
                        CalulateBalance += Convert.ToInt32(BillRow["AMOUNT"]);
                    }
                }
                else
                {
                    DataSet _BillbyCustomerDataSet = GetBillsbyCustomer(CustomerID);
                    foreach (DataRow BillRow in _BillbyCustomerDataSet.Tables[0].Rows)
                    {
                        CalulateBalance += Convert.ToInt32(BillRow["AMOUNT"]);
                        if (Convert.ToInt32(Billnumber) == Convert.ToInt32(BillRow["ID"]))
                        {
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            } return CalulateBalance;
            //            throw new NotImplementedException();
        }

        internal static DataSet Get_Ctn_Bill()
        {
            try
            {
                FbConnection myConnection1 = new FbConnection(Variables.DatabaseConnectString);
                myConnection1.Open();

                DataSet myDataSet = new DataSet();
                FbDataAdapter myDataAdapter = new FbDataAdapter();
                myDataAdapter = new FbDataAdapter("Select * from CTN_BILL_SUM", myConnection1);
                myDataAdapter.Fill(myDataSet);
                myConnection1.Close();
                return myDataSet;
            }
            catch (Exception ex)
            {
                Variables.NotificationMessageText = ex.Message;
                Variables.NotificationMessageTitle = "DB Call";
                Variables.NotificationStatus = true;
            }
            return null;
        }
    }
}
