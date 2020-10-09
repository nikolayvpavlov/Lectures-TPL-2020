using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DThreadsUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bGetUltimateAnswer_Click(object sender, EventArgs e)
        {
            Thread worker = new Thread(() =>
            {
                DeepThought thought = new DeepThought();
                int answer = thought.ComputeTheUltimateAnswer();
                MessageBox.Show("Answer is: " + answer.ToString());
            });
            worker.Start();
            //worker.Join();  This will block the current thread.
        }
    }
}
