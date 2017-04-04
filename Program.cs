using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{

    public struct FormCollection
    {
        public StartForm StartForm;
        public SelectForm SelectForm;
        public ProductInfoForm ProductInfoForm;
        public OrderForm OrderForm;
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormCollection forms = new FormCollection();

            forms.StartForm = new StartForm();
            forms.SelectForm = new SelectForm();
            forms.ProductInfoForm = new ProductInfoForm();
            forms.OrderForm = new OrderForm();

            forms.StartForm.Forms = forms;
            forms.SelectForm.Forms = forms;
            forms.ProductInfoForm.ProductForms = forms;
            forms.OrderForm.OrderForms = forms;

            Application.Run(forms.StartForm);
        }
    }
}
