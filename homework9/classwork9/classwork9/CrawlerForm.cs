using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classwork9
{
    public partial class CrawlerForm : Form
    {
        Crawler Crawler;
        public CrawlerForm()
        {
            InitializeComponent();
        }

        private void crawlBtn_Click(object sender, EventArgs e)
        {
            if (websiteTxt.Text != null)
            {
                Crawler = new Crawler(websiteTxt.Text);
                bindingSource1.DataSource = Crawler;
                Crawler.Crawl();
                bindingSource1.ResetBindings(false);
            }
            else return;
        }

        private void CrawlerForm_Load(object sender, EventArgs e)
        {
            websiteTxt.Text = "请在此处输入要爬取的网址";
        }
    }
}
