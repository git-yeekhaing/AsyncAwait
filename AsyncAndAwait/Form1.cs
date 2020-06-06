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

        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            int calc = await CalculateValueAsync();
            lblResult.Text = calc.ToString();
        }

        public async Task<int> CalculateValueAsync()
        {
            await Task.Delay(5000);
            return 123;
        }
    }
}
