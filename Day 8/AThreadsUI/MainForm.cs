using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AThreadsUI
{
    public partial class MainForm : Form
    {
        const string qotdUrl = "https://nvp-functions.azurewebsites.net/api/qotd";

        public MainForm()
        {
            InitializeComponent();
        }

        private void GetQotd()
        {
            WebClient client = new WebClient();
            var result = client.DownloadString(qotdUrl);

            Invoke((Action)(() => tbQotD.Text = result));
        }

        private void bGetQotD_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(GetQotd);
            t.Start();
        }
    }
}
