using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADO.NET.DataBindingSimple.P05ex2
{
    public partial class DataBinding : Form
    {
        public DataBinding()
        {
            InitializeComponent();
        }

        private BindingSource productsBindingSource;

        private void DataBinding_Load(object sender, EventArgs e)
        {
            
            productsTableAdapter.Fill(northwindDataSet.Products);

            productsBindingSource = new BindingSource(northwindDataSet, "Products");

            ProductIDTextBox.DataBindings.Add("Text", productsBindingSource, "ProductID");
            ProductNameTextBox.DataBindings.Add("Text", productsBindingSource, "ProductName");
        }

        private void PreviousButto_Click(object sender, EventArgs e)
        {
            productsBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveNext();
        }
    }
}
