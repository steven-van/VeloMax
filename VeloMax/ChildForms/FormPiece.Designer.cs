namespace VeloMax.ChildForms
{
    partial class FormPiece
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewPiece = new System.Windows.Forms.DataGridView();
            this.dataIdPiece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPrixU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDateI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDateD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDelaiA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnOpenAddPiece = new FontAwesome.Sharp.IconButton();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPiece)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPiece
            // 
            this.dataGridViewPiece.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.dataGridViewPiece.AllowUserToAddRows = false;
            this.dataGridViewPiece.AllowUserToDeleteRows = false;
            this.dataGridViewPiece.AllowUserToResizeColumns = false;
            this.dataGridViewPiece.AllowUserToResizeRows = false;
            this.dataGridViewPiece.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewPiece.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPiece.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPiece.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPiece.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataIdPiece,
            this.dataDesc,
            this.dataCategorie,
            this.dataPrixU,
            this.dataStock,
            this.dataDateI,
            this.dataDateD,
            this.dataDelaiA,
            this.btnUpdate,
            this.btnDelete});
            this.dataGridViewPiece.GridColor = System.Drawing.Color.White;
            this.dataGridViewPiece.Location = new System.Drawing.Point(105, 122);
            this.dataGridViewPiece.MultiSelect = false;
            this.dataGridViewPiece.Name = "dataGridViewPiece";
            this.dataGridViewPiece.ReadOnly = true;
            this.dataGridViewPiece.RowHeadersVisible = false;
            this.dataGridViewPiece.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewPiece.RowTemplate.Height = 28;
            this.dataGridViewPiece.ShowEditingIcon = false;
            this.dataGridViewPiece.Size = new System.Drawing.Size(1044, 422);
            this.dataGridViewPiece.TabIndex = 13;
            this.dataGridViewPiece.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPiece_CellClick);
            // 
            // dataIdPiece
            // 
            this.dataIdPiece.DataPropertyName = "idPiece";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataIdPiece.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataIdPiece.HeaderText = "idPiece";
            this.dataIdPiece.Name = "dataIdPiece";
            this.dataIdPiece.ReadOnly = true;
            this.dataIdPiece.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataDesc
            // 
            this.dataDesc.DataPropertyName = "description";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDesc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataDesc.HeaderText = "description";
            this.dataDesc.Name = "dataDesc";
            this.dataDesc.ReadOnly = true;
            // 
            // dataCategorie
            // 
            this.dataCategorie.DataPropertyName = "categorie";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataCategorie.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataCategorie.HeaderText = "categorie";
            this.dataCategorie.Name = "dataCategorie";
            this.dataCategorie.ReadOnly = true;
            // 
            // dataPrixU
            // 
            this.dataPrixU.DataPropertyName = "prixU";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPrixU.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataPrixU.HeaderText = "prixU";
            this.dataPrixU.Name = "dataPrixU";
            this.dataPrixU.ReadOnly = true;
            // 
            // dataStock
            // 
            this.dataStock.DataPropertyName = "stock";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataStock.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataStock.HeaderText = "stock";
            this.dataStock.Name = "dataStock";
            this.dataStock.ReadOnly = true;
            // 
            // dataDateI
            // 
            this.dataDateI.DataPropertyName = "dateI";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDateI.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataDateI.HeaderText = "dateI";
            this.dataDateI.Name = "dataDateI";
            this.dataDateI.ReadOnly = true;
            // 
            // dataDateD
            // 
            this.dataDateD.DataPropertyName = "dateD";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDateD.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataDateD.HeaderText = "dateD";
            this.dataDateD.Name = "dataDateD";
            this.dataDateD.ReadOnly = true;
            // 
            // dataDelaiA
            // 
            this.dataDelaiA.DataPropertyName = "delaiA";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDelaiA.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataDelaiA.HeaderText = "delaiA";
            this.dataDelaiA.Name = "dataDelaiA";
            this.dataDelaiA.ReadOnly = true;
            // 
            // btnUpdate
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.btnUpdate.DefaultCellStyle = dataGridViewCellStyle9;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.HeaderText = "";
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ReadOnly = true;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseColumnTextForButtonValue = true;
            this.btnUpdate.Width = 150;
            // 
            // btnDelete
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.btnDelete.DefaultCellStyle = dataGridViewCellStyle10;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.HeaderText = "";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseColumnTextForButtonValue = true;
            this.btnDelete.Width = 150;
            // 
            // btnOpenAddPiece
            // 
            this.btnOpenAddPiece.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenAddPiece.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(174)))), ((int)(((byte)(124)))));
            this.btnOpenAddPiece.FlatAppearance.BorderSize = 0;
            this.btnOpenAddPiece.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenAddPiece.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenAddPiece.ForeColor = System.Drawing.Color.White;
            this.btnOpenAddPiece.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnOpenAddPiece.IconColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOpenAddPiece.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOpenAddPiece.Location = new System.Drawing.Point(105, 25);
            this.btnOpenAddPiece.Name = "btnOpenAddPiece";
            this.btnOpenAddPiece.Size = new System.Drawing.Size(173, 65);
            this.btnOpenAddPiece.TabIndex = 14;
            this.btnOpenAddPiece.Text = "Ajouter une pièce";
            this.btnOpenAddPiece.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenAddPiece.UseVisualStyleBackColor = false;
            this.btnOpenAddPiece.Click += new System.EventHandler(this.btnOpenAddPiece_Click_1);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearch.BackColor = System.Drawing.Color.White;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(855, 55);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(294, 35);
            this.textBoxSearch.TabIndex = 18;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // FormPiece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1255, 629);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridViewPiece);
            this.Controls.Add(this.btnOpenAddPiece);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPiece";
            this.Text = "FormPiece";
            this.Load += new System.EventHandler(this.FormPiece_Load);
            this.Shown += new System.EventHandler(this.FormPiece_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPiece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPiece;
        private FontAwesome.Sharp.IconButton btnOpenAddPiece;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataIdPiece;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPrixU;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDateI;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDateD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDelaiA;
        private System.Windows.Forms.DataGridViewButtonColumn btnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}