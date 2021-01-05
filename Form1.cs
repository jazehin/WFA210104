using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA210104
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTime start = dtpStart.Value, end = dtpEnd.Value;
            TimeSpan timeSpan = end.Subtract(start);
            if (end >= start) lblValue.Text = $"{timeSpan.Days} nap";
            else lblValue.Text = "Érvénytelen formátum.";

            //if (dtpEnd.Value < dtpStart.Value) MessageBox.Show("A végérték nagyobb, mint a kezdőérték!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now.AddMinutes(1);
        }
    }
}
