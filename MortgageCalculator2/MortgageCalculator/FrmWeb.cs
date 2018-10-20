using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MortgageCalculator
{
    public partial class FrmWeb : Form
    {
       
        public FrmWeb()
        {
            
            InitializeComponent();
            //WebBrowser.Navigate("http://www.google.com");
            
            
        }

        public class BrowserTab : TabPage
        {
            WebBrowser wb = new WebBrowser();

            public BrowserTab()
            {
                wb.SetBounds(0, 0, 600, 300);
                wb.Url = new Uri("http://google.com");

                this.Controls.Add(wb);
            }

            
        }

        private void LoadForm_(object sender, EventArgs e)
        {
            
            //this.Text = "My web Browser";
            //this.TxtUrl.Text = "www.google.com";
            //webBrowser.Navigate(TxtUrl.Text);
        
        
        
        
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {

            //WebBrowser.Navigate(TxtUrl.Text);
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            //WebBrowser.GoHome();
        }

        private void BtnTab_Click(object sender, EventArgs e)
        {
            TabPage tb = new TabPage();
            WebBrowser wb = new WebBrowser();
            wb.Dock = DockStyle.Fill;
            wb.Navigate("www.google.com");

            tabControl1.TabPages.Add(tb);
            tb.Controls.Add(wb);
        }

        private void BtnApply_Click_1(object sender, EventArgs e)
        {
            wb.navigate(TxtUrl
        }


        
         



    }
}
