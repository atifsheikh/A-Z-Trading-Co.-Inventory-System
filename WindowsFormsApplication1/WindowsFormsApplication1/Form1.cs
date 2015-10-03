using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportPath = "CustomerBill.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Invoice", invoice.GetBillDetail()));


            ReportParameter[] param = new ReportParameter[6];
            param[0] = new ReportParameter("CustomerName", "Atif");
            param[1] = new ReportParameter("CustomerBusinessName", "Atif");
            param[2] = new ReportParameter("CustomerPhone", "Atif");
            param[3] = new ReportParameter("CustomerBalance", "0");
            param[4] = new ReportParameter("InvoiceDate", DateTime.Now.ToString());
            param[5] = new ReportParameter("InvoiceNumber", "0");

            this.reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.Dock = DockStyle.Fill;
            this.reportViewer1.RefreshReport();
        }
    }

    public class Invoice
    {
        private List<BillDetail> b_Details;

        public Invoice()
        {
            b_Details = new List<BillDetail>();
            b_Details.Add(new BillDetail("Notebook", "model",30, 1, 30));
            b_Details.Add(new BillDetail("Pen", "model", 15, 2, 30));
            b_Details.Add(new BillDetail("Pencil","model",10,3, 30));
            
        }

        public List<BillDetail> GetBillDetail()
        {
            return b_Details;
        }
    }
    
    public class BillDetail
    {
        public BillDetail(string Code, string model, int t_quantity, int price, int subtotal)
        {
            NAME = Code;
            T_QUANTITY = t_quantity;
            MODEL = model;
            PRICE = price;
            SUBTOTAL = subtotal;
        }

        public string NAME { get; set; }
        public string MODEL { get; set; }
        public int T_QUANTITY { get; set; }
        public int CTN { get; set; }
        public int PRICE { get; set; }
        public int SUBTOTAL { get; set; }
    }

    public class InvoiceDetails
    {
        public List<BillDetail> BillDetail { get; set; }
        //public Customer Customer { get; set; }
        //public Bill Bill { get; set; }
    }
    //public class Customer
    //{
    //    public int ID { get; set; }
    //    public string NAME { get; set; }
    //    public string EMAIL { get; set; }
    //    public string PHONE { get; set; }
    //    public string ADDRESS { get; set; }
    //    public int AMOUNT { get; set; }
    //    public int OPENING_BALANCE { get; set; }
    //    public int BALANCE_LIMIT { get; set; }
    //}

    //public class Bill
    //{
    //    public int ID { get; set; }
    //    public string NAME { get; set; }
    //    public string DATED { get; set; }
    //    public int AMOUNT { get; set; }
    //    public string REMARKS { get; set; }
    //    public int CUSTOMER_BALANCE { get; set; }
    //    public int TOTAL_CTN { get; set; }
    //}

}