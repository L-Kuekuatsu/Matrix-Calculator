namespace EDP_LabExercise_2
{
    partial class Form1
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
            this.tableA = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rowVal = new System.Windows.Forms.NumericUpDown();
            this.columnVal = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableB = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clrMtxB = new System.Windows.Forms.Button();
            this.clrMtxA = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.operations = new System.Windows.Forms.ComboBox();
            this.solveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnVal)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableB)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableA
            // 
            this.tableA.AllowUserToAddRows = false;
            this.tableA.AllowUserToDeleteRows = false;
            this.tableA.AllowUserToResizeColumns = false;
            this.tableA.AllowUserToResizeRows = false;
            this.tableA.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.tableA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableA.ColumnHeadersVisible = false;
            this.tableA.Location = new System.Drawing.Point(6, 10);
            this.tableA.MultiSelect = false;
            this.tableA.Name = "tableA";
            this.tableA.RowHeadersVisible = false;
            this.tableA.RowHeadersWidth = 20;
            this.tableA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableA.Size = new System.Drawing.Size(502, 112);
            this.tableA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(599, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Columns";
            // 
            // rowVal
            // 
            this.rowVal.Location = new System.Drawing.Point(639, 109);
            this.rowVal.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.rowVal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowVal.Name = "rowVal";
            this.rowVal.ReadOnly = true;
            this.rowVal.Size = new System.Drawing.Size(35, 20);
            this.rowVal.TabIndex = 3;
            this.rowVal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowVal.ValueChanged += new System.EventHandler(this.rowVal_ValueChanged);
            // 
            // columnVal
            // 
            this.columnVal.Location = new System.Drawing.Point(639, 135);
            this.columnVal.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.columnVal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.columnVal.Name = "columnVal";
            this.columnVal.ReadOnly = true;
            this.columnVal.Size = new System.Drawing.Size(35, 20);
            this.columnVal.TabIndex = 4;
            this.columnVal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.columnVal.ValueChanged += new System.EventHandler(this.columnVal_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableB);
            this.panel2.Location = new System.Drawing.Point(12, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 132);
            this.panel2.TabIndex = 8;
            // 
            // tableB
            // 
            this.tableB.AllowUserToAddRows = false;
            this.tableB.AllowUserToDeleteRows = false;
            this.tableB.AllowUserToResizeColumns = false;
            this.tableB.AllowUserToResizeRows = false;
            this.tableB.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.tableB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableB.ColumnHeadersVisible = false;
            this.tableB.Location = new System.Drawing.Point(6, 10);
            this.tableB.MultiSelect = false;
            this.tableB.Name = "tableB";
            this.tableB.RowHeadersVisible = false;
            this.tableB.RowHeadersWidth = 20;
            this.tableB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableB.Size = new System.Drawing.Size(502, 112);
            this.tableB.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "MATRIX B";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "MATRIX A";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableA);
            this.panel1.Location = new System.Drawing.Point(12, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 132);
            this.panel1.TabIndex = 10;
            // 
            // clrMtxB
            // 
            this.clrMtxB.Location = new System.Drawing.Point(226, 194);
            this.clrMtxB.Name = "clrMtxB";
            this.clrMtxB.Size = new System.Drawing.Size(94, 23);
            this.clrMtxB.TabIndex = 12;
            this.clrMtxB.Text = "Clear Matrix B";
            this.clrMtxB.UseVisualStyleBackColor = true;
            this.clrMtxB.Click += new System.EventHandler(this.clrMtxB_Click);
            // 
            // clrMtxA
            // 
            this.clrMtxA.Location = new System.Drawing.Point(226, 146);
            this.clrMtxA.Name = "clrMtxA";
            this.clrMtxA.Size = new System.Drawing.Size(94, 23);
            this.clrMtxA.TabIndex = 13;
            this.clrMtxA.Text = "Clear Matrix A";
            this.clrMtxA.UseVisualStyleBackColor = true;
            this.clrMtxA.Click += new System.EventHandler(this.clrMtxA_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(582, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "OPERATIONS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // operations
            // 
            this.operations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operations.FormattingEnabled = true;
            this.operations.Items.AddRange(new object[] {
            "Addition",
            "Subtraction",
            "Multipliation",
            "Transpose Matrix A",
            "Transpose Matrix B",
            "Get Determinant"});
            this.operations.Location = new System.Drawing.Point(566, 219);
            this.operations.MaxDropDownItems = 5;
            this.operations.Name = "operations";
            this.operations.Size = new System.Drawing.Size(132, 21);
            this.operations.TabIndex = 15;
            // 
            // solveBtn
            // 
            this.solveBtn.Location = new System.Drawing.Point(596, 246);
            this.solveBtn.Name = "solveBtn";
            this.solveBtn.Size = new System.Drawing.Size(75, 23);
            this.solveBtn.TabIndex = 16;
            this.solveBtn.Text = "Solve";
            this.solveBtn.UseVisualStyleBackColor = true;
            this.solveBtn.Click += new System.EventHandler(this.solveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 351);
            this.Controls.Add(this.solveBtn);
            this.Controls.Add(this.operations);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clrMtxA);
            this.Controls.Add(this.clrMtxB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.columnVal);
            this.Controls.Add(this.rowVal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Basic Matrix Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.tableA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnVal)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown rowVal;
        private System.Windows.Forms.NumericUpDown columnVal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tableB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clrMtxB;
        private System.Windows.Forms.Button clrMtxA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox operations;
        private System.Windows.Forms.Button solveBtn;
        private System.Windows.Forms.DataGridView tableA;
    }
}

