#region Author Info
// Author : Eshwar Chandra Bharadwaj
// Tool : Generic ExcelReader 
// Version : 1.0
// Date : 31 January 2008
// Description : This part of the source provides the UI for the tool.
// TextBoxes : FilenameTextBox is used to get the name of the excel file.
//             SheetTextBox is used to get the name of the excel sheet
//                  of the excel file from where data is to be read.
// RadioChoice : This is to choose either to give the Range Cells Manually
//                  Example : RangeStartCell : A2
//                            RangeEndCell   : I20
//  
//                  Indicate that certain cell in the excel sheet
//                  contains the information about the startcell and endcell
//                  of the range to be read from sheet in the format 
//                  startcell:endcell 
//                  Example : ExcelRangeCell : A1
//                  And in the Excel sheet - 
//                  Cell A1 contains Information "A2:I20" meaning
//                  Range's StartCell = A2
//                  Range's EndCell   = I20
// This is a free source which can be used by anyone in any form.

#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ExcelReader
{
    public partial class ExcelTool : Form
    {
        ExcelReader.eshExcel excelObj;
        public ExcelTool()
        {
            InitializeComponent();
            excelObj = new eshExcel();
        }

        private void ExcelRead_Click(object sender, EventArgs e)
        {
            try
            {
                excelObj.OpenFile(FileNameTextBox.Text, "");
                excelObj.GetExcelsheets();
                if (!excelObj.OpenReqExcelWorksheet(SheetNameTextBox.Text))
                {
                    throw (new Exception("Exception: Excel Sheet not found"));
                }
                {
                    Variables.Range = excelObj.GetRange(RangeStartCellTextBox.Text, RangeEndCellTextBox.Text);
//                    WriteToExcelDataTextBox(Range);
                }
                excelObj.CloseFile();

                //FileNameLabel.Visible = false;
                //FileNameTextBox.Visible = false;
                //WorkSheetLabel.Visible = false;
                //SheetNameTextBox.Visible = false;
                //ExcelRead.Visible = false;

                //BackLabel.Visible = true;
                //BackLabel.Dock = DockStyle.Bottom;
                //ExcelDataTextBox.Visible = true;
                //ExcelDataTextBox.Multiline = true;
                //ExcelDataTextBox.Dock = DockStyle.Fill;
                //ExcelDataTextBox.WordWrap = false;
                //ExcelDataTextBox.AcceptsTab = true;
                //ExcelDataTextBox.ScrollBars = ScrollBars.Both;
            }
            catch (IOException ie)
            {
                MessageBox.Show(ie.Message);
            }
            catch (Exception ee)
            {
                if (ee.Message == "Unknown error while opening the file")
                {
                    MessageBox.Show(ee.Message);
                }
                else
                {
                    MessageBox.Show(ee.Message);
                    excelObj.CloseFile();
                }
            }
            this.Close();
        }        


        private void WriteToExcelDataTextBox(string[][] data)
        {
            foreach ( string[] line in data)
            {                
                foreach (string element in line)
                {
                    ExcelDataTextBox.Text += element;
                    ExcelDataTextBox.Text += "\t\t\t";
                }
                ExcelDataTextBox.Text += Environment.NewLine;
            }
            
        }

        private void BackLabel_Click(object sender, EventArgs e)
        {
            FileNameLabel.Visible = true;
            FileNameTextBox.Visible = true;
            WorkSheetLabel.Visible = true;
            SheetNameTextBox.Visible = true;
            ExcelRead.Visible = true;
            
            ExcelDataTextBox.Visible = false;
            BackLabel.Visible = false;
        }

        private void RangeEndCellTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                ExcelRead_Click(sender, new EventArgs());
        }

        private void ExcelRangeCellTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                ExcelRead_Click(sender, new EventArgs());
        }

        private void ExcelTool_Load(object sender, EventArgs e)
        {
            FileNameTextBox.Text = Variables.FileName;
            SheetNameTextBox.Text = "Sheet1";

            RangeStartCellLabel.Visible = true;
            RangeStartCellTextBox.Visible = true;
            RangeEndCellLabel.Visible = true;
            RangeEndCellTextBox.Visible = true;

        }

        private void SheetNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                    SendKeys.Send("{TAB}");
            }
        }              
    }
}