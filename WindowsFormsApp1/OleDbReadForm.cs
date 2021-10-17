using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidatingFilesApplication.Classes;

namespace ValidatingFilesApplication
{
    public partial class OleDbReadForm : Form
    {
        private readonly DataTable _table;

        public OleDbReadForm()
        {
            InitializeComponent();
        }
        public OleDbReadForm(DataTable table)
        {
            InitializeComponent();

            _table = table;

            foreach (var column in table.Columns.Cast<DataColumn>())
            {
                Console.WriteLine(column.ColumnName);
            }

            Console.WriteLine();
            Console.WriteLine(table.Rows.Count);
            Shown += OnShown;
        }

        /// <summary>
        /// Populate data
        ///     DataGridView ScrollBars is set to ScrollBars.None in the designer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnShown(object sender, EventArgs e)
        {
            // ensure button is not grey out
            await Task.Delay(1);

            dataGridView1.DataSource = _table;

            try
            {
                dataGridView1.SuspendLayout();

                // forum question
                //await dataGridView1.FormatColumns();

                await dataGridView1.ExpandColumnsAsync();
            }
            catch (Exception)
            {
                // ignored fringe case, user closed form before finishing ExpandColumnsAsync
            }
            finally
            {
                dataGridView1.ResumeLayout();
                dataGridView1.ScrollBars = ScrollBars.Both;
            }
            
        }
    }
}
