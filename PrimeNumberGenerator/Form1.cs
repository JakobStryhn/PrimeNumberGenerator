using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumberGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numUDStart.Maximum = (int) numUDEnd.Value - 1;
            Generator generator = new Generator();
            lblPrimeCount.Text = "Prime Number Count: " + 0;
        }

        private void btnSeq_Click(object sender, EventArgs e)
        {
            var uicontext = TaskScheduler.FromCurrentSynchronizationContext();
            Task.Factory.StartNew(() =>
            {
                return Generator.getPrimesSequential((long)numUDStart.Value, (long)numUDEnd.Value, this);
            })
                .ContinueWith((res) =>
            {
                lblPrimeCount.Text = "Prime Number Count: " + res.Result.Count;
                lbPrimeNumbers.DataSource = res.Result;
            }, uicontext);
        }

        private void btnParallel_Click(object sender, EventArgs e)
        {
            var uicontext = TaskScheduler.FromCurrentSynchronizationContext();
            Task.Factory.StartNew(() =>
            {
                return Generator.getPrimesParallel((long)numUDStart.Value, (long)numUDEnd.Value, this);
            }).ContinueWith((res) =>
            {
                lblPrimeCount.Text = "Prime Number Count: " + res.Result.Count;
                lbPrimeNumbers.DataSource = res.Result;
            }, uicontext);
        }

        private void numUD_ValueChanged(object sender, EventArgs e)
        {
            numUDStart.Maximum = (int)numUDEnd.Value - 1;
        }

        public void TimestampsUpdate(long start, long end, string processType, long timestamp)
        {
            if (label1.InvokeRequired)
            {
                label1.Invoke(new MethodInvoker(delegate
                {
                    label1.Text = label1.Text + Environment.NewLine
                    + start + "-" + end + " " + processType + " took " + ": " + TimeSpan.FromMilliseconds(timestamp).TotalSeconds + " seconds.";
                }
                ));
            }
        }
    }
}
