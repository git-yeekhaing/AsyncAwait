using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AsyncAndAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var calc = CalculateValueAsync();
            calc.ContinueWith(t =>
            {
                lblResult.Text = t.Result.ToString();
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        public Task<int> CalculateValueAsync()
        {
            return Task.Factory.StartNew(() =>
            {
                Thread.Sleep(5000);
                return 123;
            });
        }

        public int CalculateValue()
        {
            Thread.Sleep(5000);
            return 123;
        }
    }
}
