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
    public partial class ProductInfoForm : Form
    {
        private Dictionary<String, String> selectedComputerInfo = new Dictionary<string, string>();
        private FormCollection productforms;
        public FormCollection ProductForms
        {
            set
            {
                productforms = value;
            }
        }

        public Dictionary<String, String> SelectedComputerInfo
        {
            set
            {
                selectedComputerInfo = value;
                helper(this);
            }
        }
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void selectButton(object sender, EventArgs e)
        {
            this.Hide();
            productforms.SelectForm.Show();
        }

        private void cancelButton(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nextButton(object sender, EventArgs e)
        {
            this.Hide();
            productforms.OrderForm.Show();
        }
        //Helper method
        private void helper(Control parent)
        {
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
            //Value is to be formatted in the cost box
            double d;
            if (Double.TryParse(costTextBox.Text, out d))
            {
                costTextBox.Text = d.ToString("C");
            }
        }
        // The productID of the selected item is used to be store in the file 
        private bool loadedFile = false;
        public bool fileLoading()
        {
            productforms.SelectForm.Show();
            productforms.SelectForm.Hide();
            openToolStripMenuItem.PerformClick();
            return loadedFile;
        }
        private void openButton(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FileName = "order.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                String value = streamReader.ReadLine();
                int index;
                if (Int32.TryParse(value, out index))
                {
                    try
                    {
                        productforms.SelectForm.SetRow(index);
                        SelectedComputerInfo = productforms.SelectForm.GetSelected();
                        loadedFile = true;
                    }
                    catch
                    {
                        MessageBox.Show("Saved file is corrupted");
                    }
                }
                streamReader.Close();
            }
        }

        private void saveButton(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FileName = "order.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);
                streamWriter.WriteLine(productIDTextBox.Text);
                streamWriter.Close();
            }
        }
    }
}
