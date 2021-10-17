using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StackOverFlowQuestion.Classes;

/*
 * 
 */
namespace StackOverFlowQuestion
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _itemsBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();

            _itemsBindingSource.DataSource = Operations.MockedItems;
            dataGridView1.DataSource = _itemsBindingSource;
            bindingNavigator1.BindingSource = _itemsBindingSource;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (_itemsBindingSource.Current is null) return;
    
            if (Dialogs.Question("Remove current?"))
            {
                _itemsBindingSource.RemoveCurrent();
            }

        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            if (_itemsBindingSource.Count >0)
            {
                Operations.Export((List<Item>)_itemsBindingSource.DataSource, "SomeFile.csv");
            }
        }
    }
}
