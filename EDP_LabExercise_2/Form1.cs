using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDP_LabExercise_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tableA.ColumnCount = 1;
            tableB.ColumnCount = 1;
            tableA.RowCount = 1;
            tableB.RowCount = 1;
            tableA.Rows[0].Cells[0].Value = 0;
            tableB.Rows[0].Cells[0].Value = 0;
            tableA.DefaultCellStyle.SelectionBackColor = tableA.DefaultCellStyle.BackColor;
            tableA.DefaultCellStyle.SelectionForeColor = tableA.DefaultCellStyle.ForeColor;
            tableB.DefaultCellStyle.SelectionBackColor = tableB.DefaultCellStyle.BackColor;
            tableB.DefaultCellStyle.SelectionForeColor = tableB.DefaultCellStyle.ForeColor;
        }

        private void rowVal_ValueChanged(object sender, EventArgs e)
        {
            tableA.RowCount = Convert.ToInt32(rowVal.Value);
            tableB.RowCount = Convert.ToInt32(rowVal.Value);
            rowDefaultValue();
        }

        private void columnVal_ValueChanged(object sender, EventArgs e)
        {
            tableA.ColumnCount = Convert.ToInt32(columnVal.Value);
            tableB.ColumnCount = Convert.ToInt32(columnVal.Value);
            columnDefaultValue();
        }

        private void clrMtxB_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(rowVal.Value); i++)
            {
                for (int j = 0; j < Convert.ToInt32(columnVal.Value); j++)
                {
                    tableB.Rows[i].Cells[j].Value = 0;
                }
            }
            tableB.ClearSelection();
        }

        private void clrMtxA_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(rowVal.Value); i++)
            {
                for (int j = 0; j < Convert.ToInt32(columnVal.Value); j++)
                {
                    tableA.Rows[i].Cells[j].Value = 0;
                }
            }
            tableA.ClearSelection();
        }

        private void solveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int rVal = Convert.ToInt32(rowVal.Value);
                int cVal = Convert.ToInt32(columnVal.Value);
                int[,] tableA_data = new int[rVal, cVal];
                int[,] tableB_data = new int[rVal, cVal];
                for (int i = 0; i < rVal; i++)
                {
                    for (int j = 0; j < cVal; j++)
                    {
                        tableA_data[i, j] = Convert.ToInt32(tableA.Rows[i].Cells[j].Value);
                        tableB_data[i, j] = Convert.ToInt32(tableB.Rows[i].Cells[j].Value);
                    }
                }
                string op = "default";
                switch (operations.SelectedIndex)
                {
                    case 0: op = "add"; break;
                    case 1: op = "subt"; break;
                    case 2: op = "mul"; break;
                    case 3: op = "tpA"; break;
                    case 4: op = "tpB"; break;
                    case 5: op = "deter"; break;
                    default: MessageBox.Show("Select an Operation!"); break;
                }
                if (op != "default")
                {
                    if(op == "deter" && rowVal.Value != columnVal.Value)
                    {
                        MessageBox.Show("The row and column must be equal to solve the Determinant");
                    }
                    else
                    {
                        FormResult fr = new FormResult(tableA_data, tableB_data, op, rVal, cVal);
                        fr.Show();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Input Properly!");
            }
        }
        public void rowDefaultValue()
        {
            int n = Convert.ToInt32(rowVal.Value);
            int m = Convert.ToInt32(columnVal.Value);
            for (int i = 0; i < m; i++)
            {
                tableA.Rows[n-1].Cells[i].Value = 0;
                tableB.Rows[n-1].Cells[i].Value = 0;
            }
        }
        public void columnDefaultValue()
        {
            int n = Convert.ToInt32(rowVal.Value);
            int m = Convert.ToInt32(columnVal.Value);
            for (int i = 0; i < n; i++)
            {
                tableA.Rows[i].Cells[m-1].Value = 0;
                tableB.Rows[i].Cells[m-1].Value = 0;
            }
        }
    }
}