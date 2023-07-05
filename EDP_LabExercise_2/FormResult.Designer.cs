namespace EDP_LabExercise_2
{
    partial class FormResult
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultTable = new System.Windows.Forms.DataGridView();
            this.deterA = new System.Windows.Forms.Label();
            this.deterB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultTable
            // 
            this.resultTable.AllowUserToAddRows = false;
            this.resultTable.AllowUserToDeleteRows = false;
            this.resultTable.AllowUserToResizeColumns = false;
            this.resultTable.AllowUserToResizeRows = false;
            this.resultTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.resultTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.resultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultTable.ColumnHeadersVisible = false;
            this.resultTable.Location = new System.Drawing.Point(12, 12);
            this.resultTable.MultiSelect = false;
            this.resultTable.Name = "resultTable";
            this.resultTable.ReadOnly = true;
            this.resultTable.RowHeadersVisible = false;
            this.resultTable.RowHeadersWidth = 20;
            this.resultTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultTable.Size = new System.Drawing.Size(502, 112);
            this.resultTable.TabIndex = 1;
            // 
            // deterA
            // 
            this.deterA.AutoSize = true;
            this.deterA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deterA.Location = new System.Drawing.Point(206, 7);
            this.deterA.Name = "deterA";
            this.deterA.Size = new System.Drawing.Size(50, 16);
            this.deterA.TabIndex = 2;
            this.deterA.Text = "label1";
            // 
            // deterB
            // 
            this.deterB.AutoSize = true;
            this.deterB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deterB.Location = new System.Drawing.Point(206, 7);
            this.deterB.Name = "deterB";
            this.deterB.Size = new System.Drawing.Size(50, 16);
            this.deterB.TabIndex = 3;
            this.deterB.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Determinant of Matrix A : ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.deterA);
            this.panel1.Location = new System.Drawing.Point(95, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 31);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.deterB);
            this.panel2.Location = new System.Drawing.Point(95, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 31);
            this.panel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Determinant of Matrix B : ";
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 136);
            this.Controls.Add(this.resultTable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormResult";
            this.Text = "Result";
            ((System.ComponentModel.ISupportInitialize)(this.resultTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView resultTable;
        private System.Windows.Forms.Label deterA;
        private System.Windows.Forms.Label deterB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}