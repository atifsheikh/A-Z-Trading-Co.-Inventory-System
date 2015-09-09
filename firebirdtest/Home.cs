using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using firebirdtest.UI;
using System.IO;

namespace firebirdtest
{
    public partial class Home : Form
    {
        public Home()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Home.Home_pnl.Visible = false;
                AddCustomer _AddCustomer = new AddCustomer();
                _AddCustomer.MdiParent = this;
                _AddCustomer.WindowState = FormWindowState.Maximized;
                _AddCustomer.Show();
                _AddCustomer.Focus();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    Customer_Strip.Show(Cursor.Position);// e.Location);
                }
                else
                    this.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    Consignment_strip.Show(Cursor.Position);// e.Location);
                }
                else
                    this.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    Inventory_Strio.Show(Cursor.Position);// e.Location);
                }
                else
                    this.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    Sales_Strip.Show(Cursor.Position);// e.Location);
                }
                else
                    this.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    Leadger_Strip.Show(Cursor.Position);// e.Location);
                }
                else
                    this.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            try
            {
                Variables.Exit = true;
                Application.Exit();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        public AddCustomer _AddCustomer = new AddCustomer();

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_AddCustomer.IsDisposed)
                    _AddCustomer = new AddCustomer();
                Home.Home_pnl.Visible = false;
                _AddCustomer.MdiParent = this;
                _AddCustomer.WindowState = FormWindowState.Maximized;
                _AddCustomer.Show();
                _AddCustomer.Focus();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                addCustomerToolStripMenuItem_Click(sender, e);
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        AddItem _AddItems = new AddItem();
        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            try
            {
                if (_AddItems.IsDisposed)
                    _AddItems = new AddItem();
                Home.Home_pnl.Visible = false;
                _AddItems.MdiParent = this;
                _AddItems.WindowState = FormWindowState.Maximized;
                _AddItems.Show();
                _AddItems.Focus();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            try
            {
                Home.Home_pnl.Visible = false;
                EditItem _EditItem = new EditItem();
                _EditItem.MdiParent = this;
                _EditItem.WindowState = FormWindowState.Maximized;
                _EditItem.Show();
                _EditItem.Focus();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void addConsignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Home.Home_pnl.Visible = false;
                AddConsignment _AddConsignment = new AddConsignment();
                _AddConsignment.MdiParent = this;
                _AddConsignment.WindowState = FormWindowState.Maximized;
                _AddConsignment.Show();
                _AddConsignment.Focus();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void addConsignmentDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Home.Home_pnl.Visible = false;
                AddConsignmentDetail _AddConsignmentDetail = new AddConsignmentDetail();
                _AddConsignmentDetail.MdiParent = this;
                _AddConsignmentDetail.WindowState = FormWindowState.Maximized;
                _AddConsignmentDetail.Show();
                _AddConsignmentDetail.Focus();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        AddBill _AddBill = new AddBill();
        private void addSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_LedgerReports!=null&&!_LedgerReports.IsDisposed)
                    _LedgerReports.Dispose();
                if (_LedgerStatement != null && !_LedgerStatement.IsDisposed)
                    _LedgerStatement.Dispose();
                if (_ListConsignmentDetails!= null && !_ListConsignmentDetails.IsDisposed)
                    _ListConsignmentDetails.Dispose();
                if (_ListConsignments!= null && !_ListConsignments.IsDisposed)
                    _ListConsignments.Dispose();
                if (_ListCustomers!= null && !_ListCustomers.IsDisposed)
                    _ListCustomers.Dispose();
                if (_ListInventory!= null && !_ListInventory.IsDisposed)
                    _ListInventory.Dispose();
                if (_AddConsignmentAdvanced!= null && !_AddConsignmentAdvanced.IsDisposed)
                    _AddConsignmentAdvanced.Dispose();
                if (_AddCustomer!= null && !_AddCustomer.IsDisposed)
                    _AddCustomer.Dispose();
                if (_AddItems!= null && !_AddItems.IsDisposed)
                    _AddItems.Dispose();
                if (_DebitorSummary!= null && !_DebitorSummary.IsDisposed)
                    _DebitorSummary.Dispose();           
                if (_DeleteBill!= null && !_DeleteBill.IsDisposed)
                    _DeleteBill.Dispose();
                if (_ItemHistoryReport != null && !_ItemHistoryReport.IsDisposed)
                    _ItemHistoryReport.Dispose();


                if (_AddBill.IsDisposed)
                    _AddBill = new AddBill();

                Home.Home_pnl.Visible = false;

                _AddBill.MdiParent = this;
                _AddBill.WindowState = FormWindowState.Maximized; 
                _AddBill.Show();
                _AddBill.Focus();
                
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void ReopenAddBill()
        {
            try
            {
                if (_AddBill.IsDisposed == false)
                {
                    _AddBill.Close();
                    _AddBill = new AddBill();
                }
                else
                    return;
                Home.Home_pnl.Visible = false;

                _AddBill.MdiParent = this;
                _AddBill.WindowState = FormWindowState.Maximized;
                _AddBill.Show();
                _LedgerStatement.Focus();
                //_AddBill.Focus();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void reportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                Home.Home_pnl.Visible = false;
                UI.BillPrint _asdf = new UI.BillPrint();
                _asdf.MdiParent = this;
                _asdf.WindowState = FormWindowState.Maximized;
                _asdf.Show();
                _asdf.Focus();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        ListCustomers _ListCustomers = new ListCustomers();
        private void listCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_ListCustomers.IsDisposed)
                    _ListCustomers = new ListCustomers();

                Home.Home_pnl.Visible = false;
                _ListCustomers.MdiParent = this;
                _ListCustomers.WindowState = FormWindowState.Maximized;
                _ListCustomers.Show();
                _ListCustomers.Focus();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        ListConsignments _ListConsignments;
        private void listConsignmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Home.Home_pnl.Visible = false;
                _ListConsignments = new ListConsignments();
                _ListConsignments.MdiParent = this;
                _ListConsignments.WindowState = FormWindowState.Maximized;
                _ListConsignments.Show();
                _ListConsignments.Focus();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        ListConsignmentDetails _ListConsignmentDetails = new ListConsignmentDetails();
        private void listConsignmentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_ListConsignmentDetails.IsDisposed)
                    _ListConsignmentDetails = new ListConsignmentDetails();
                Home.Home_pnl.Visible = false;
                _ListConsignmentDetails.MdiParent = this;
                _ListConsignmentDetails.WindowState = FormWindowState.Maximized;
                _ListConsignmentDetails.Show();
                _ListConsignmentDetails.Focus();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        AddConsignmentAdvanced _AddConsignmentAdvanced = new AddConsignmentAdvanced();
        private void addConsignmentShortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_AddConsignmentAdvanced.IsDisposed)
                    _AddConsignmentAdvanced = new AddConsignmentAdvanced();
                Home.Home_pnl.Visible = false;
                _AddConsignmentAdvanced.MdiParent = this;
                _AddConsignmentAdvanced.WindowState = FormWindowState.Maximized;
                _AddConsignmentAdvanced.Show();
                _AddConsignmentAdvanced.Focus();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        UI.BillPrint _BillPrint = new UI.BillPrint();
        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_BillPrint.IsDisposed)
                    _BillPrint = new BillPrint();
                Home.Home_pnl.Visible = false;
                _BillPrint.MdiParent = this;
                _BillPrint.WindowState = FormWindowState.Maximized;
                _BillPrint.Show();
                _BillPrint.Focus();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void toolStripMenuItem24_Click_1(object sender, EventArgs e)
        {
            try
            {
                Home.Home_pnl.Visible = false;
                ListItems _ListItems = new ListItems();
                _ListItems.MdiParent = this;
                _ListItems.WindowState = FormWindowState.Maximized;
                _ListItems.Show();
                _ListItems.Focus();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        ListInventory _ListInventory = new ListInventory();
        private void listInventoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (_ListInventory.IsDisposed)
                    _ListInventory = new ListInventory();
                Home.Home_pnl.Visible = false;
                _ListInventory.MdiParent = this;
                _ListInventory.WindowState = FormWindowState.Maximized;
                _ListInventory.Show();
                _ListInventory.Focus();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        LedgerStatement _LedgerStatement = new LedgerStatement();
        private void statementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _AddBill.Dispose();
                _AddBill.Close();
            }
            catch (Exception ex)
            { }

            try
            {
                if (_LedgerStatement.IsDisposed)
                    _LedgerStatement = new LedgerStatement();
                Home.Home_pnl.Visible = false;

                _LedgerStatement.MdiParent = this;
                _LedgerStatement.WindowState = FormWindowState.Maximized;
                _LedgerStatement.Show();
                _LedgerStatement.Focus();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            try
            {
                addConsignmentShortToolStripMenuItem_Click(sender, e);
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                Home.Home_pnl.Visible = false;
                ListInventory _ListInventory = new ListInventory();
                _ListInventory.MdiParent = this;
                _ListInventory.WindowState = FormWindowState.Maximized;
                _ListInventory.Show();
                _ListInventory.Focus();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                addSaleToolStripMenuItem_Click(sender, e);
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                statementToolStripMenuItem_Click(sender, e);
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            try
            {
                this.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            try
            {
                addCustomerToolStripMenuItem_Click(sender, e);
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            try
            {
                Home.Home_pnl.Visible = false;
                if (_AddConsignmentAdvanced.IsDisposed)
                    _AddConsignmentAdvanced = new AddConsignmentAdvanced();

                _AddConsignmentAdvanced.MdiParent = this;
                _AddConsignmentAdvanced.WindowState = FormWindowState.Maximized;
                _AddConsignmentAdvanced.Show();
                _AddConsignmentAdvanced.Focus();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            try
            {
                listInventoryToolStripMenuItem_Click_1(sender, e);
                //Home.Home_pnl.Visible = false;
                //ListInventory _ListInventory = new ListInventory();
                //_ListInventory.MdiParent = this;
                //_ListInventory.Show();
                //_ListInventory.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                Home.Home_pnl.Visible = false;
                AddBill _AddBill = new AddBill();
                _AddBill.MdiParent = this;
                _AddBill.WindowState = FormWindowState.Maximized;
                _AddBill.Show();
                _AddBill.Focus();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            try
            {
                Home.Home_pnl.Visible = false;
                LedgerStatement _LedgerStatement = new LedgerStatement();
                _LedgerStatement.MdiParent = this;
                _LedgerStatement.WindowState = FormWindowState.Maximized;
                _LedgerStatement.Show();
                _LedgerStatement.Focus();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        DebitorSummary _DebitorSummary = new DebitorSummary();
        private void debitorSummeryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_DebitorSummary.IsDisposed == true)
                    _DebitorSummary = new DebitorSummary();
                Home.Home_pnl.Visible = false;
                _DebitorSummary.MdiParent = this;
                _DebitorSummary.WindowState = FormWindowState.Maximized;
                _DebitorSummary.Show();
                _DebitorSummary.Focus();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        DeleteBill _DeleteBill = new DeleteBill();
        private void deleteBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_DeleteBill.IsDisposed)
                    _DeleteBill = new DeleteBill();
                Home.Home_pnl.Visible = false;

                _DeleteBill.MdiParent = this;
                _DeleteBill.WindowState = FormWindowState.Maximized;
                _DeleteBill.Show();
                _DeleteBill.Focus();

            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void NotificationsTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                //for refresh
                if (Variables.FormRefresh != null&& Variables.FormRefresh != "")
                {
                    switch (Variables.FormRefresh)
                    {
                        case "ListConsignmentDetails":
                            Variables.FormRefresh = "";
                            listConsignmentDetailsToolStripMenuItem_Click(sender, e);
                            break;
                        case "BillPrint":
                            Variables.FormRefresh = "";
                            reportToolStripMenuItem_Click(sender, e);
                            break;
                        case "AddCustomer":
                            Variables.FormRefresh = "";
                            addCustomerToolStripMenuItem_Click(sender, e);
                            break;
                        case "LedgerReports":
                            Variables.FormRefresh = "";
                            leadgerReportToolStripMenuItem_Click(sender, e);
                            break;
                        case "AddItem":
                            Variables.FormRefresh = "";
                            toolStripMenuItem20_Click(sender, e);
                            break;
                        case "AddConsignmentAdvanced":
                            Variables.FormRefresh = "";
                            addConsignmentShortToolStripMenuItem_Click(sender, e);
                            break;
                        case "AddBill/Leadger":
                            Variables.FormRefresh = "";
                            ReopenAddBill();
                            break;
                        case "AddBill":
                            Variables.FormRefresh = "";
                            addSaleToolStripMenuItem_Click(sender, e);
                            break;
                        case "DeleteBill":
                            Variables.FormRefresh = "";
                            deleteBillToolStripMenuItem_Click(sender, e);
                            break;
                        case "LedgerStatement":
                            Variables.FormRefresh = "";
                            statementToolStripMenuItem_Click(sender, e);
                            break;
                        case "ListInventory":
                            Variables.FormRefresh = "";
                            listInventoryToolStripMenuItem_Click_1(sender, e);
                            break;
                        case "DebitorSummary":
                            Variables.FormRefresh = "";
                            debitorSummeryToolStripMenuItem_Click(sender, e);
                            break;


                            
                        default:
                            break;

                    }
                }
                //

                if (Variables.NotificationStatus)
                {
                    Variables.NotificationStatus = false;
                    if (!Variables.NotificationMessageText.Equals("Cannot find table 0."))
                    {
                        if (Variables.NotificationMessageText != "")
                        {
                            if (Variables.DisplayTime == null || Variables.DisplayTime == 0)
                            {
                                notifyIcon1.ShowBalloonTip(1000, Variables.NotificationMessageTitle, Variables.NotificationMessageText, ToolTipIcon.Info);
                            }
                            else
                            {
                                notifyIcon1.ShowBalloonTip(Variables.DisplayTime, Variables.NotificationMessageTitle, Variables.NotificationMessageText, ToolTipIcon.Info);
                                Variables.DisplayTime = 0;
                            }
                            Variables.NotificationMessageText = "";
                        }
                        else
                            notifyIcon1.ShowBalloonTip(1000, Variables.NotificationMessageTitle, "some empty message poped", ToolTipIcon.Info);
                    }
                }
                if (Variables.FormClosed == true)
                {
                    Variables.FormClosed = false;
                    if (MdiChildren.Length == 0)
                    {
                        var point = Home.Home_pnl.Location;
                        point.X = 0;
                        //point.Y++;
                        Home.Home_pnl.Location = point;
                        Home.Home_pnl.Visible = true;
                        //Home.Home_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)                            | System.Windows.Forms.AnchorStyles.Left)                            | System.Windows.Forms.AnchorStyles.Right)));
                    }
                }
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info);
            }
        }

        private void Home_Load_1(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon("favicon.ico");
                this.Icon = ico;
            }
            catch (Exception ex)
            { }
            try
            {
                notifyIcon1.ContextMenuStrip = MainMenuStrip.ContextMenuStrip;
                if (File.Exists("HomeBG.jpg") == true)
                {
                    Home_pnl.BackgroundImage = Image.FromFile(Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "HomeBG.jpg"));
                    Home_pnl.BackgroundImageLayout = ImageLayout.Zoom;
                }
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = true;
                this.WindowState = FormWindowState.Maximized;
                notifyIcon1.ContextMenuStrip = MainMenuStrip;
                notifyIcon1.ContextMenuStrip.Show(MousePosition);
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void addConsignmentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                addConsignmentShortToolStripMenuItem_Click(sender, e);

            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void listConsignmentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                listConsignmentDetailsToolStripMenuItem_Click(sender, e);
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            try
            {
                addCustomerToolStripMenuItem_Click(sender, e);
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                listCustomerToolStripMenuItem_Click(sender, e);
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void toolStripMenuItem22_Click_1(object sender, EventArgs e)
        {
            try
            {
                toolStripMenuItem20_Click(sender, e);
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                addSaleToolStripMenuItem_Click(sender, e);
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void invoiceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                addSaleToolStripMenuItem_Click(sender, e);
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                reportToolStripMenuItem_Click(sender, e);
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            try
            {
                deleteBillToolStripMenuItem_Click(sender, e);
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void leadgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                statementToolStripMenuItem_Click(sender, e);
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Variables.Exit = true;
                Application.Exit();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (Variables.Exit == false)
                {
                    e.Cancel = true;
                    this.WindowState = FormWindowState.Minimized;
                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }
        }

        LedgerReports _LedgerReports = new LedgerReports();
        private void leadgerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_LedgerReports.IsDisposed == true)
                    _LedgerReports = new LedgerReports();
                var point = Home_pnl.Location;
                point.X += 2000;
//                point.Y += 40;
                Home_pnl.Anchor = System.Windows.Forms.AnchorStyles.None;
                Home_pnl.Location = point;
                _LedgerReports.MdiParent = this;
                _LedgerReports.WindowState = FormWindowState.Maximized;
                _LedgerReports.Show();
                _LedgerReports.Focus();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }

        }

        private void databaseAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ItemFileBrowser_Dialogue = new OpenFileDialog();
            //ItemFileBrowser_Dialogue.ShowDialog();
            //if (ItemFileBrowser_Dialogue.FileName != "")
            //    Variables.DatabaseConnectString = "User=SYSDBA; Password=masterkey;Database=CyberKryptos-PC-9:" + ItemFileBrowser_Dialogue.FileName + " ;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;";
        }

        ItemHistoryView _ItemHistoryReport = new ItemHistoryView();
        private void itemHistoryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_ItemHistoryReport.IsDisposed == true)
                    _ItemHistoryReport = new ItemHistoryView();
                Home.Home_pnl.Visible = false;
                _ItemHistoryReport.MdiParent = this;
                _ItemHistoryReport.WindowState = FormWindowState.Maximized;
                _ItemHistoryReport.Show();
                _ItemHistoryReport.Focus();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }

        }

        public AddVendor _AddVendor = new AddVendor();

        private void addVendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_AddVendor.IsDisposed)
                    _AddVendor = new AddVendor();
                Home.Home_pnl.Visible = false;
                _AddVendor.MdiParent = this;
                _AddVendor.WindowState = FormWindowState.Maximized;
                _AddVendor.Show();
                _AddVendor.Focus();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, this.Name, ex.Message, ToolTipIcon.Info); ;
            }

        }
    }
}
//
//this.MdiChildren.Length