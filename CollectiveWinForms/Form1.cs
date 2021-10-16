using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollectiveWinForms.Classes;

namespace CollectiveWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SequenceButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var value in SequenceExtensions.Sequence(0,100,2))
            {
                listBox1.Items.Add($"{value:D3}");
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
        }
    }
}
