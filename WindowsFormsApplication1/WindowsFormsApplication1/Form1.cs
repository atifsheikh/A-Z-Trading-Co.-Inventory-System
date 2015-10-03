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
            b_Details.Add(new BillDetail(0, "Notebook", 2, 4, "model", 1, 15, 15)); 
            b_Details.Add(new BillDetail(1, "Pen", 6, 8, "model", 1, 25, 25));
            b_Details.Add(new BillDetail(2,"Pencil",10,12,"model",1,30, 30));
            
        }

        public List<BillDetail> GetBillDetail()
        {
            return b_Details;
        }


        public InvoiceDetails InvoiceDetails { get; set; }

        internal InvoiceDetails GetInvoiceDetails()
        {
            return InvoiceDetails;
        }
    }
    
    public class BillDetail
    {
        public BillDetail(int id, string name, int t_quantity, int qty_per_box, string model, int ctn, int price, int subtotal)
        {
            ID = id;
            NAME = name;
            T_QUANTITY = t_quantity;
            QTY_PER_BOX = qty_per_box;
            MODEL = model;
            CTN = ctn;
            PRICE = price;
            SUBTOTAL = subtotal;
        }

        public int ID { get; set; }
        public string NAME { get; set; }
        public string MODEL { get; set; }
        public int T_QUANTITY { get; set; }
        public int QTY_PER_BOX { get; set; }
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