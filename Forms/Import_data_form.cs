using CefSharp;
using CefSharp.WinForms;
using HariOmImpex_LMS.Properties;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace HariOmImpex_LMS.Forms
{
    public partial class Import_data_form : Form
    {
        ChromiumWebBrowser browser;
        string jsObject = "";
        bool text_copied = true;

        public Import_data_form()
        {
            InitializeComponent();
            
            InitBrowser();



            
            
          

            //panel3.SuspendLayout();
            //browser = new ChromiumWebBrowser("google.com")
            //{
            //    Dock = DockStyle.Fill,
                
            //    //BackColor = SystemColors.ControlDark
                
            //};

            //this.panel3.Controls.Add(browser);

            //panel3.ResumeLayout();
            //panel3.Update();
            //panel3.Refresh();
        }

        public IWinFormsWebBrowser Browser { get; private set; }

        //public ChromiumWebBrowser browser;
        public void InitBrowser()
        {

            //Xpcom.Initialize("Firefox");
            //var geckoWebBrowser = new GeckoWebBrowser { Dock = DockStyle.Fill };
            //Form f = new Form();
            //f.Controls.Add(geckoWebBrowser);
            //geckoWebBrowser.Navigate("www.google.com");
            //Application.Run(f);

           

            if (!Cef.IsInitialized) // Check before init
            {
                CefSettings settings = new CefSettings();
                CefSharpSettings.LegacyJavascriptBindingEnabled = true;
                Cef.Initialize(settings);
                settings.SetOffScreenRenderingBestPerformanceArgs();

                
            }

            
            //MessageBox.Show(webControl1.Selection.Text);
            

            browser = new ChromiumWebBrowser("www.google.com");
            browser.AddressChanged += Browser_AddressChanged;
            browser.LoadingStateChanged += Browser_LoadingStateChanged;
            browser.TitleChanged += Browser_TitleChanged;
            Browser = browser;

            Browser.DownloadHandler = new downlo

            

            string downloadPath = @"C:\Users\SanjayR\Downloads" + downloadItem.SuggestedFileName;
            showDialog = false;
            MessageBox.Show("Downloaded");
            return true;


            this.panel3.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
            

            browser.Invalidate();
            //Cef.AddDisposable(browser);
        }

        private void Browser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            current_title = e.Title;
           

        }

        private void Browser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            if (!e.IsLoading)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    write_to_history(current_Address);
                }));

                toolStripStatusLabel1.Text = current_Address + " loaded.";
            }
            else
            { 
            
            }
            

            // toolStripComboBox1.Text = current_Address;
        }

        string current_Address = "";
        string current_title = "";
        private void Browser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            current_Address = e.Address;
            //current_title = 
           // global_functions.ex_bookmark_query("insert into history url values " + e.Address + ";");

            if (InvokeRequired)
            {
                // after we've done all the processing, 
                this.Invoke(new MethodInvoker(delegate {
                    toolStripComboBox1.Text = e.Address;
                }));

                


                return;
            }

            //address_changed = true;

        }

        void write_to_history(string url)
        {
            try
            {

                string text = "Data Source=" + global_vars.getBookmarks();
                string text2 = null;
                text2 = "insert into history (url) values(@url);";
                SQLiteConnection connection = new SQLiteConnection(text);
                try
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(text2, connection);
                    try
                    {
                        command.Parameters.AddWithValue("@url", current_Address);

                        if (command.ExecuteNonQuery() > 0)
                        {

                            //toolStripStatusLabel1.Text = "New user added..";
                           // global_functions.Entry_log(0, "add_new_bookmark - success", "");
                        }
                        else
                        {
                            //MessageBox.Show("No row inserted");
                        }
                    }
                    finally
                    {
                        command.Dispose();
                       load_history();
                    }
                }
                catch (Exception ex)
                {
                    //toolStripStatusLabel1.Text = "User cannot be added.. Please check the user details.";
                    global_functions.Entry_log(1, "add_new_client - " + ex.Message, ex.StackTrace);
                }
                finally
                {
                    ((IDisposable)connection)?.Dispose();
                }
                global_functions.Entry_log(0, "bookmar_add - success", "");
                // Close();
            }
            catch (Exception ex)
            {
                global_functions.Entry_log(1, "bookmark_add - " + ex.Message, ex.StackTrace);
            }
        }

        private void readDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        

        private void readTextToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Browser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            
           // 
            
        }

        private void Import_data_form_Load(object sender, EventArgs e)
        {
            //menuStrip1.Renderer = new ToolStripProfessionalRenderer(new MenuColorTable());
            menuStrip2.Renderer = new ToolStripProfessionalRenderer(new MenuColorTable());
            menuStrip1.CanOverflow = true;
            this.Invalidate();
            panel3.Invalidate();
            this.Refresh();

            Clipboard.Clear();
            load_bookmarks();


        }

        private void Import_data_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Cef.Shutdown();
            // settings.Dispose();
           // Cef.Shutdown();

            
            //webControl1.Dispose();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void goToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //browser.GetBrowser().Reload();
            //webControl1.Refresh();
        }

        private void forwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // browser.GetBrowser().GoForward();
            //webControl1.GoForward();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //browser.GetBrowser().GoBack();
            // webControl1.GoBack();
        }

        private void Import_data_form_SizeChanged(object sender, EventArgs e)
        {

        }

        private void invalidateToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Update();

            splitContainer1.Update();
            this.Update();
        }

        private void backToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            browser.GetBrowser().GoBack();
        }

        private void forwardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            browser.GetBrowser().GoForward();
        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Reloading page...";
            browser.GetBrowser().Reload();
        }

        private void goToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            browser.Load(toolStripComboBox1.Text);
        }

       

       
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
           
        }

        private void sharpClipboard1_ClipboardChanged(object sender, WK.Libraries.SharpClipboardNS.SharpClipboard.ClipboardChangedEventArgs e)
        {
            

            var content_type = WK.Libraries.SharpClipboardNS.SharpClipboard.ContentTypes.Text;
            if (e.ContentType == content_type && browser.Focused )
            {

                new custom_msgbox_form().ShowDialog();
            }

        }

        private void addAsAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        string site_name = "";
        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
           
           // bookmarks_settings.Default.SettingChanging += Default_SettingChanging;
        }

        private void Default_SettingChanging(object sender, System.Configuration.SettingChangingEventArgs e)
        {
            load_bookmarks();

        }

        void load_history()
        {
            toolStripComboBox1.Items.Clear();
            var history = global_functions.load_bookmarks("SELECT * FROM history ORDER BY ID DESC LIMIT 20;");

            foreach (DataRow row in history.Tables[0].Rows)
            {
                toolStripComboBox1.Items.Add(row[1].ToString());
            }


        }
       

        void load_bookmarks()
        {
            menuStrip1.Items.Clear();

           

            var bookmarks = global_functions.load_bookmarks("select * from bookmarks;");

            foreach (DataRow row in bookmarks.Tables[0].Rows)
            {
                ToolStripItem item = menuStrip1.Items.Add(row[1].ToString());
                item.Tag = row[1].ToString();
                item.Tag = new { ID = row[0].ToString(), URL = row[2].ToString()};
                item.Image = Resources.bookmark;
                item.Overflow = ToolStripItemOverflow.AsNeeded;
                item.AutoToolTip = true;
                item.ToolTipText = row[2].ToString();

                //item.BackColor = Color.Gainsboro;
                item.Click += Item_Click;
                item.MouseDown += Item_MouseDown;
            }

            toolStripStatusLabel1.Text = "Bookmarks loaded...";

        }

        string menuname = "";
        string menutag;
        string menuID;

        private void Item_MouseDown(object sender, MouseEventArgs e)
        {
            ToolStripItem item = sender as ToolStripMenuItem;

            menuname = item.Name;
            menutag = ((dynamic)item.Tag).URL;
            menuID = ((dynamic)item.Tag).ID;

            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip2.Show();
            
            }
        }

        //private static TagInfo GetTag(object sender)
        //{
        //    Button button = sender as Button;
        //    ToolStripItem tsi = sender as ToolStripItem;

        //    //if (button != null)
        //    //    return button.Tag;
        //    if (tsi != null)
        //    {
        //        var taginfo = (TagInfo)tsi.Tag;
        //        return taginfo;
        //    }
        //    else
        //        return null;
                

        //    throw new ArgumentException("Unexpected sender");
        //}

        private void Item_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripItem;
            browser.Load(((dynamic)item.Tag).URL);

            toolStripStatusLabel1.Text = "Opening " + ((dynamic)item.Tag).URL;
            //browser.Load();
            //throw new NotImplementedException();
        }

        string text = Path.GetDirectoryName(global_vars.getDatabasePath()) + "/bookmarks";
        private void bookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                string text = "Data Source=" + global_vars.getBookmarks();
                string text2 = null;
                text2 = "insert into bookmarks (title, url) values(@title, @url);";
                SQLiteConnection connection = new SQLiteConnection(text);
                try
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(text2, connection);
                    try
                    {

                        command.Parameters.AddWithValue("@title", current_title);
                        command.Parameters.AddWithValue("@url", current_Address);

                        if (command.ExecuteNonQuery() > 0)
                        {

                            toolStripStatusLabel1.Text = "Bookmark saved. ";
                            //toolStripStatusLabel1.Text = "New user added..";
                            global_functions.Entry_log(0, "add_new_bookmark - success", "");
                        }
                        else
                        {
                            MessageBox.Show("No row inserted");
                        }
                    }
                    finally
                    {
                        command.Dispose();
                        load_bookmarks();
                    }
                }
                catch (Exception ex)
                {
                    //toolStripStatusLabel1.Text = "User cannot be added.. Please check the user details.";
                    global_functions.Entry_log(1, "add_new_client - " + ex.Message, ex.StackTrace);
                }
                finally
                {
                    ((IDisposable)connection)?.Dispose();
                }
                global_functions.Entry_log(0, "bookmar_add - success", "");
               // Close();
            }
            catch (Exception ex)
            {
                global_functions.Entry_log(1, "bookmark_add - " + ex.Message, ex.StackTrace);
            }
            load_bookmarks();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripComboBox1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Import_data_form_Resize(object sender, EventArgs e)
        {
           // toolStripComboBox1.Width = this.Width - 500;
        }

        private void addAsContctDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var bookmarks = File.ReadAllLines(text + "/bookmark.txt");

            global_functions.ex_bookmark_query("delete from bookmarks where ID =" + menuID +";");
            toolStripStatusLabel1.Text = "Bookmark deleted... ";
            load_bookmarks();


        }
    }

    
}
