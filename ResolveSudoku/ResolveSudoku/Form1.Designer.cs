namespace ResolveSudoku
{
    partial class FormResolve
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnResolve = new System.Windows.Forms.Button();
            this.DgvSukodu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSukodu)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnResolve
            // 
            this.BtnResolve.Location = new System.Drawing.Point(273, 275);
            this.BtnResolve.Name = "BtnResolve";
            this.BtnResolve.Size = new System.Drawing.Size(198, 23);
            this.BtnResolve.TabIndex = 1;
            this.BtnResolve.Text = "Resolve Sudoku";
            this.BtnResolve.UseVisualStyleBackColor = true;
            this.BtnResolve.Click += new System.EventHandler(this.BtnResolve_Click);
            // 
            // DgvSukodu
            // 
            this.DgvSukodu.AllowUserToAddRows = false;
            this.DgvSukodu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSukodu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvSukodu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSukodu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvSukodu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvSukodu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvSukodu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvSukodu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSukodu.ColumnHeadersVisible = false;
            this.DgvSukodu.EnableHeadersVisualStyles = false;
            this.DgvSukodu.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DgvSukodu.Location = new System.Drawing.Point(273, 80);
            this.DgvSukodu.Name = "DgvSukodu";
            this.DgvSukodu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvSukodu.RowHeadersVisible = false;
            this.DgvSukodu.RowHeadersWidth = 45;
            this.DgvSukodu.RowTemplate.ReadOnly = true;
            this.DgvSukodu.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSukodu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DgvSukodu.Size = new System.Drawing.Size(198, 189);
            this.DgvSukodu.TabIndex = 2;
            this.DgvSukodu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSukodu_CellContentClick);
            // 
            // FormResolve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvSukodu);
            this.Controls.Add(this.BtnResolve);
            this.Name = "FormResolve";
            this.Text = "ResolveSudoku";
            ((System.ComponentModel.ISupportInitialize)(this.DgvSukodu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnResolve;
        private System.Windows.Forms.DataGridView DgvSukodu;
    }
}

