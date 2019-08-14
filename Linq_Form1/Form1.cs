using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq_Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }

        private void helpToolStripButton_Click(object sender, EventArgs e) 
        {
            Program.aboutForm.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'linq_Initial_DatabaseDataSet.Student_Table' table. You can move, or remove it, as needed.
            this.student_TableTableAdapter.Fill(this.linq_Initial_DatabaseDataSet.Student_Table);

        }

        private void Student_Data_GridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Student_Data_GridView1_SelectionChanged(object sender, EventArgs e)
        {
            var row_index = Student_Data_GridView1.CurrentCell.RowIndex;
            var rows = Student_Data_GridView1.Rows;
            var columncount = Student_Data_GridView1.ColumnCount;
            var cells = rows[row_index].Cells;
            string output_string = string.Empty;
            rows[row_index].Selected = true;

            for (int index = 0; index < columncount; index++)
            {
                output_string += cells[index].Value.ToString() + " ";
            }

            label1.Text = output_string;
        }
    }
}
