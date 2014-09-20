using System;
using System.Collections.Generic;
using System.Text;

namespace ExcelReader
{
    public class Variables
    {
        //public static string FileName
        public static string FileName { get; set; }

        public static string WorkSheetName { get; set; }

        public static string[][] Range { get; set; }

        public static int RangeCurrentIndex { get; set; }
    }
}
