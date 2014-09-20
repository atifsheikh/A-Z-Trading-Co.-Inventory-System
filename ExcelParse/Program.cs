#region Author Info
// Author : Eshwar Chandra Bharadwaj
// Tool : Generic ExcelReader 
// Version : 1.0
// Date : 31 January 2008
// Description : This tool is a wrapper around the Office COM component
// The current capability of the tool is to read the Data from an Excel sheet
//    and give a string array representing the data where each cell is a string
// The class eshExcel is the wrapper which abstracts the complex function calls
//    and the initializing parameters rewuired for accessing an excel sheet.
// Even the exceptions are abstracted so that error messages are more user friendly.
// This is a free source which can be used by anyone in any form.

#endregion


using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Office = Microsoft.Office.Core;
using System.Diagnostics;
using System.Windows.Forms;

namespace ExcelReader
{
    static class Program
    {        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ExcelTool());
        }
    }

    /// <summary>
    /// Utility class to read an excel sheet data into memory
    /// 
    /// </summary>
    public class eshExcel
    {
        #region DATA MEMBERS 
        private Microsoft.Office.Interop.Excel.Application excelApplication = null;
        private Microsoft.Office.Interop.Excel.Workbook excelWorkbook = null;
        private Microsoft.Office.Interop.Excel.Sheets excelSheets = null;
        private Microsoft.Office.Interop.Excel.Worksheet excelWorksheet = null;

        // to represent values that are missing/not applicable while passing parameters
        private static object esh_missing = System.Reflection.Missing.Value;

        private static object esh_visible = true;
        private static object esh_true = true;
        private static object esh_false = false;

        // to set the application visible or invisible
        private static object esh_app_visible = false;

        // used in the closingof the application
        private object esh_filename = null;

        #endregion
        
        #region OPEN WORKBOOK VARIABLES

        private object esh_update_links = 0;
        private object esh_read_only = esh_true;
        private object esh_format = 1;
        private object esh_password = esh_missing;
        private object esh_write_res_password = esh_missing;
        private object esh_ignore_read_only_recommend = esh_true;
        private object esh_origin = esh_missing;
        private object esh_delimiter = esh_missing;
        private object esh_editable = esh_false;
        private object esh_notify = esh_false;
        private object esh_converter = esh_missing;
        private object esh_add_to_mru = esh_false;
        private object esh_local = esh_false;
        private object esh_corrupt_load = esh_false;
        
        #endregion
        
        #region CLOSE WORKBOOK VARIABLES

        private object esh_save_changes = esh_false;
        private object esh_route_workbook = esh_false;

        #endregion

        #region EXCEL OBJECT CONSTRUCTORS

        /// <summary>
        /// public default constructor for Excel Object used for reading the excel sheet.
        /// 
        /// Eshwar Date : 31 January 2008
        /// </summary>
        public eshExcel()
        {
            this.InitExcel();
        }

        /// <summary>
        /// Creating the excel object keeping the application visible or invisible.
        /// </summary>
        /// <param name="visibility"></param>
        public eshExcel(bool visibility)
        {
            esh_app_visible = visibility;
            this.InitExcel();
        }

        #endregion
        #region destructor

        ~eshExcel()
        {
            this.StopExcel();
        }

        #endregion
        #region INIT EXCEL APPL
        /// <summary>
        /// starting the excel application
        /// </summary>
        private void InitExcel()
        {
            if (excelApplication == null)
            {
                excelApplication = new Microsoft.Office.Interop.Excel.ApplicationClass();
            }
            excelApplication.Visible = (bool)esh_app_visible;
        }

        #endregion

        #region STOP EXCEL APPL

        private void StopExcel()
        {
            if (this.excelApplication != null)
            {
                Process[] pProcess = System.Diagnostics.Process.GetProcessesByName("Excel");
                pProcess[0].Kill();
            }
        }

        #endregion


        #region OPEN EXCEL WORKBOOK
        /// <summary>
        /// opening the workBook from the excel file.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public void OpenFile(string filename, string password)
        {
            esh_filename = filename;
            if (password.Length > 0)
            {
                esh_password = password;
            }
            try
            {
                this.excelWorkbook = this.excelApplication.Workbooks.Open(filename,
                        esh_update_links, esh_read_only, esh_format, esh_password, esh_write_res_password,
                        esh_ignore_read_only_recommend, esh_origin, esh_delimiter, esh_editable, esh_notify,
                        esh_converter, esh_add_to_mru, esh_local, esh_corrupt_load);
            }            
            catch (Exception ee)
            {
                if ((ee.Message).Contains("could not be found"))
                {
                    throw (new FileNotFoundException(ee.Message));
                }
                else
                {
                    throw (new Exception("Unknown error while opening the file"));
                }
            }
            
        }

        #endregion

        public void CloseFile()
        {
            this.excelWorkbook.Close(esh_save_changes, esh_filename, esh_route_workbook);            
        }

        #region GET EXCEL SHEETS FROM WORKBOOK

        public void GetExcelsheets()
        {
            if (this.excelWorkbook != null)
            {
                this.excelSheets = this.excelWorkbook.Worksheets;
            }
        }

        #endregion

        #region OPEN REQUIRED EXCEL SHEET

        public bool OpenReqExcelWorksheet(string worksheetName)
        {
            bool sheet_found = false;

            if (this.excelSheets != null)
            {
                for (int i = 1; i <= this.excelSheets.Count; ++i)
                {
                    this.excelWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)excelSheets.get_Item((object)i);
                    if (this.excelWorksheet.Name == worksheetName)
                    {
                        ((Microsoft.Office.Interop.Excel._Worksheet)excelWorksheet).Activate();
                        sheet_found = true;
                        return sheet_found;
                    }

                }
            }
            return sheet_found;
        }

        #endregion

        #region GET RANGE 
        public string[][] GetRange(string startRange)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Range currentRangeCells = this.excelWorksheet.get_Range(startRange, System.Reflection.Missing.Value);
                string range = currentRangeCells.Cells.Value2 as string;
                char[] splitter = { ':' };
                string[] rangeArray = range.Split(splitter, 2);
                string[][] stringArray = GetRange(rangeArray[0], rangeArray[1]);
                return stringArray;
            }
            catch (Exception e)
            {
                if (e.Message.Contains("Exception:"))
                {
                    throw (e);
                }
                else
                {
                    throw (new Exception("Exception: Range Extraction"));
                }
            }
        }

        public string[][] GetRange(string startRange, string endRange)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Range currentRangeCells = this.excelWorksheet.get_Range(startRange, endRange);
                System.Array dataArray = (System.Array)currentRangeCells.Cells.Value2;
                string[][] stringArray = this.ToStringArray(dataArray);
                return stringArray;
            }
            catch (Exception e)
            {
                if (e.Message.Contains("Exception: Conversion to string array"))
                {
                    throw (e);
                }
                else
                {
                    throw (new Exception("Exception: Range Extraction"));
                }
            }

        }

        #endregion

        #region TO STRING ARRAY
        /// <summary>
        /// Converting the data values retrieved from the rangecells to string values.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private string[][] ToStringArray(System.Array data)
        {
            try
            {
                string[][] sArray = new string[data.GetUpperBound(0)][];
                for (int i = data.GetLowerBound(0); i <= data.GetUpperBound(0); ++i)
                {
                    sArray[i - 1] = new string[data.GetUpperBound(1)];
                    for (int j = data.GetLowerBound(1); j <= data.GetUpperBound(1); ++j)
                    {
                        if (data.GetValue(i, j) == null)
                        {
                            sArray[i - 1][j - 1] = "-----";
                        }
                        else
                        {
                            sArray[i - 1][j - 1] = data.GetValue(i, j).ToString();
                        }
                    }
                }
                return sArray;
            }
            catch 
            {
                throw (new Exception("Exception: Conversion to string array"));
            }
        }
        #endregion
        
    }
}