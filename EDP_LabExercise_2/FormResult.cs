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
    public partial class FormResult : Form
    {
        public string op;
        public int[,] tableA_data;
        public int[,] tableB_data;
        public int[,] result_data;
        public int rVal;
        public int cVal;
        public FormResult(int[,] tableA_data, int[,] tableB_data, string op, int rVal, int cVal)
        {
            InitializeComponent();
            this.rVal = rVal;
            this.cVal = cVal;
            this.op = op;
            resultTable.ColumnCount = cVal;
            resultTable.RowCount = rVal;
            this.tableA_data = new int[this.rVal, this.cVal];
            this.tableB_data = new int[this.rVal, this.cVal];
            for (int i = 0; i < rVal; i++)
            {
                for (int j = 0; j < cVal; j++)
                {
                    this.tableA_data[i, j] = tableA_data[i, j];
                    this.tableB_data[i, j] = tableB_data[i, j];
                }
            }
            Solve();
        }
        public void Solve()
        {
            switch (this.op)
            {
                case "add": SolveAddition(); break;
                case "subt": SolveSubtraction(); break;
                case "mul": SolveMultiplication(); break;
                case "tpA": Transpose("tpA"); break;
                case "tpB": Transpose("tpB"); break;
                default: GetDeterminant(); break;
            }
        }
        public void SolveAddition()
        {
            this.result_data = new int[this.rVal, this.cVal];
            for (int i = 0; i < this.rVal; i++)
            {
                for (int j = 0; j < this.cVal; j++)
                {
                    int n = this.tableA_data[i, j];
                    int m = this.tableB_data[i, j];
                    this.result_data[i, j] = n + m;
                }
            }
            ShowResult();
        }
        public void SolveSubtraction()
        {
            this.result_data = new int[this.rVal, this.cVal];
            for (int i = 0; i < this.rVal; i++)
            {
                for (int j = 0; j < this.cVal; j++)
                {
                    int n = this.tableA_data[i, j];
                    int m = this.tableB_data[i, j];
                    this.result_data[i, j] = n - m;
                }
            }
            ShowResult();
        }
        public void SolveMultiplication()
        {
            this.result_data = new int[this.rVal, this.cVal];
            for (int i = 0; i < this.rVal; i++)
            {
                for (int j = 0; j < this.cVal; j++)
                {
                    int n = this.tableA_data[i, j];
                    int m = this.tableB_data[i, j];
                    this.result_data[i, j] = n * m;
                }
            }
            ShowResult();
        }
        public void Transpose(string n)
        {
            resultTable.ColumnCount = this.rVal;
            resultTable.RowCount = this.cVal;
            int temp = this.rVal;
            this.rVal = this.cVal;
            this.cVal = temp;
            this.result_data = new int[this.rVal, this.cVal];
            if(n == "tpA")
            {
                for (int i = 0; i < this.rVal; i++)
                {
                    for (int j = 0; j < this.cVal; j++)
                    {
                        this.result_data[i, j] = this.tableA_data[j, i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < this.rVal; i++)
                {
                    for (int j = 0; j < this.cVal; j++)
                    {
                        this.result_data[i, j] = this.tableB_data[j, i];
                    }
                }
            }
            ShowResult();
        }
        public void GetDeterminant()
        {
            resultTable.Visible = false;
            if (this.rVal == 1 && this.cVal == 1)
            {
                deterA.Text = Convert.ToString(tableA_data[0,0]);
                deterB.Text = Convert.ToString(tableB_data[0,0]);
            }
            else
            {
                double[,] mA = new double[this.rVal, this.cVal];
                double[,] mB = new double[this.rVal, this.cVal];

                for(int i = 0; i < this.rVal; i++)
                {
                    for(int j = 0; j < this.cVal; j++)
                    {
                        mA[i, j] = Convert.ToDouble(tableA_data[i, j]);
                        mB[i, j] = Convert.ToDouble(tableB_data[i, j]);
                    }
                }

                int a = Convert.ToInt32(Determinant(mA,this.rVal));
                int b = Convert.ToInt32(Determinant(mB,this.cVal));

                deterA.Text = Convert.ToString(a);
                deterB.Text = Convert.ToString(b);
            }
        }
        public static double Determinant(double[,] A, int N)
        {
            double c, r = 1;
            for (int i = 0; i < N; i++)
            {
                for (int k = i + 1; k < N; k++)
                {
                    c = A[k, i] / A[i, i];
                    for (int j = i; j < N; j++)
                        A[k, j] = A[k, j] - c * A[i, j];
                }
            }
            for (int i = 0; i < N; i++)
                r *= A[i, i];
            return r;
        }
        public void ShowResult()
        {
            for (int i = 0; i < rVal; i++)
            {
                for (int j = 0; j < cVal; j++)
                {
                    resultTable.Rows[i].Cells[j].Value = this.result_data[i, j];
                }
            }
            resultTable.DefaultCellStyle.SelectionBackColor = resultTable.DefaultCellStyle.BackColor;
            resultTable.DefaultCellStyle.SelectionForeColor = resultTable.DefaultCellStyle.ForeColor;
            resultTable.ClearSelection();
        }
    }
}
