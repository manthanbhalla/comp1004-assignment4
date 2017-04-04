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
    public partial class SelectForm : Form
    {
        private Dictionary<String, String> selectedComputerInfo = new Dictionary<string, string>();
        private FormCollection forms;
        public FormCollection Forms
        {
            set
            {
                forms = value;
            }
        }


        public SelectForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // If user clicks a header, return and do nothing
            if (dataGridView1.SelectedRows.Count <= 0) { return; }

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            DataGridViewColumnCollection columns = dataGridView1.Columns;

            for (int i = 0; i < columns.Count; ++i)
            {
                //populate dictionary with the row using the column names as keys
                selectedComputerInfo[columns[i].HeaderText] = row.Cells[i].Value.ToString();
            }

            String selectedComputer = selectedComputerInfo["manufacturer"];
            selectedComputer += selectedComputerInfo["model"];
            selectedComputer += " Priced at: $" + selectedComputerInfo["cost"];

            SelectedComputerTextBox.Text = selectedComputer;
            NextButton.Enabled = true;
        }


        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputerDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputerDataSet.products);

        }

        private void CancelButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            forms.ProductInfoForm.SelectedComputerInfo = selectedComputerInfo;
            forms.ProductInfoForm.Show();
        }

        public void SetRow(int index)
        {
            dataGridView1.Rows[index - 1].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[index - 1].Cells[0];
        }

        public Dictionary<String, String> GetSelected()
        {
            return selectedComputerInfo;
        }
    }
}
