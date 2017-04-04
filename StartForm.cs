using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class StartForm : Form
    {
        private FormCollection startForm;
        public FormCollection Forms
        {
            set
            {
                startForm = value;
            }
        }
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            startForm.SelectForm.Show();
        }

        private void OpenOrder_Click(object sender, EventArgs e)
        {
            if (startForm.ProductInfoForm.LoadFile())
            {
                this.Hide();
                startForm.ProductInfoForm.Show();
            }
        }

        private void ExitButton_click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
