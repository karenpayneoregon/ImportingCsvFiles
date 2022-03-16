using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidatingFilesApplicationCore.Classes
{
    /// <summary>
    /// Code to address a Microsoft Q&A forum question
    /// </summary>
    public static class DataGridViewHelpers
    {
        private static readonly List<string> columnNames = new List<string>()
        {
            "cdatetime", 
            "district", 
            "latitude", 
            "longitude"
        };

        public static async Task FormatColumns(this DataGridView sender)
        {
            foreach (var name in columnNames)
            {
                sender.Columns[name].HeaderCell.Style.BackColor = 
                    Color.FromArgb(153, 255, 51);

                sender.Columns[name].HeaderCell.Style.Font = 
                    new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);

                sender.Columns[name].ToolTipText = "Hello";

                await Task.Delay(1);
            }

            sender.ColumnHeadersDefaultCellStyle.Alignment = 
                DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
