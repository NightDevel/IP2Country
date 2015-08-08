using System;
using System.Windows.Forms;
using System.Web;
using System.Net;

namespace CountryFromIP
{
    public partial class Form1 : Form
    {
        private const string API = "http://ip-api.com/csv/";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = getCountry(textBox1.Text);
        }

        private string getCountry(string ip)
        {
            string response = new WebClient().DownloadString(API + ip);
            return response.StartsWith("fail,") ? "N/A" : response.Split(',')[1].Replace("\"","");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}