using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalculationOrder_Click(object sender, EventArgs e)
        {
            calculationCargoUC1.BringToFront();
        }

        private void btnPersonalAccount_Click(object sender, EventArgs e)
        {
            personalAccountUC1.BringToFront();
        }
    }
}
