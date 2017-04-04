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
    public partial class OrderForm : Form
    {
        private Dictionary<String, String> selectedComputerInfo = new Dictionary<string, string>();
        private FormCollection orderform;
        public FormCollection OrderForms
        {
            set
            {
                orderform = value;
            }
        }
        public OrderForm()
        {
            InitializeComponent();
        }

        private void printButton(object sender, EventArgs e)
        {
            MessageBox.Show("Your order receipt is sent for printing");
        }

        private void Backbutton(object sender, EventArgs e)
        {

        }

        private void fileButton(object sender, EventArgs e)
        {

        }

        private void aboutButton(object sender, EventArgs e)
        {
            //show about box
           // AboutBox aboutBox = new AboutBox();
           // aboutBox.Show();
        }
        //Helper method
        private void helper(Control parent)
        {
            selectedComputerInfo = orderform.SelectForm.GetSelected();
            string name;
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox)
                {
                    name = c.Name.Substring(0, c.Name.Length - 7);
                    c.Text = selectedComputerInfo.ContainsKey(name) ? selectedComputerInfo[name] : "";
                }
                else if (c is GroupBox)
                {
                    helper(c);
                }
            }
            //Format value in the price fields
            double d;
            if (Double.TryParse(costBox.Text, out d))
            {
                costBox.Text = d.ToString("C");
                SalesTaxBox.Text = (d * 0.13).ToString("C");
                TotalBox.Text = (d * 1.13).ToString("C");
            }
            if (productImages.ContainsKey(modelBox.Text))
            {
                pictureBox.Image = productImages[modelBox.Text];
            }
        }

        private void backButton(object sender, EventArgs e)
        {
            this.Hide();
            orderform.ProductInfoForm.Show();
        }

        private void finishButton(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your business.\n\nYour order will be processed in 7-10 business days.");
            Application.Exit();
        }

        private void cancelButton(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
