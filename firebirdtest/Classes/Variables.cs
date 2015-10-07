using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace InventoryManagement
{
    class Variables
    {
        //public static string DatabaseConnectString = "User=SYSDBA;" + "Password=masterkey;" + @"Database=" + "Omer" + @":D:\TEST.FDB;" + "DataSource=localhost;" + "Port=3050;" + "Dialect=3;" + "Charset=NONE;";
        //public static string DatabaseConnectString = global::InventoryManagement.Properties.Settings.Default.ConnectionString;//"User=SYSDBA;" +"Password=masterkey;" +@"Database=" + Dns.GetHostName() + @":D:\TEST.FDB;" +"DataSource=localhost;" +"Port=3050;" +"Dialect=3;" +"Charset=NONE;";
        // +"Role=;" +"Connection lifetime=15;" +"Pooling=true;" +"MinPoolSize=0;" +"MaxPoolSize=50;" +"Packet Size=8192;" +"ServerType=0";


        public static bool NotificationStatus { get; set; }

        public static bool Exit { get; set; }

        public static string NotificationMessageTitle { get; set; }

        public static string NotificationMessageText { get; set; }

        public static string PrinterName { get; set; }

        public static bool FormClosed { get; set; }

        public static string FormRefresh { get; set; }

        public static int DisplayTime { get; set; }
    }
}
