using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Development
{
    public partial class Import : Form
    {
        public Import()
        {
            InitializeComponent();
        }

        private void dataGridStudentView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Import_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\BIPIN\source\repos\Application_Development\data.txt");
            string[] values;


            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(',');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                dataGridStudentView.Rows.Add(row);
            }
        }
    }
}
