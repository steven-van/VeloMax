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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewFournisseur = new System.Windows.Forms.DataGridView();
            this.btnOpenAddFournisseur = new FontAwesome.Sharp.IconButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFournisseur)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFournisseur
            // 
            this.dataGridViewFournisseur.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.dataGridViewFournisseur.AllowUserToAddRows = false;
            this.dataGridViewFournisseur.AllowUserToDeleteRows = false;
            this.dataGridViewFournisseur.AllowUserToResizeColumns = false;
            this.dataGridViewFournisseur.AllowUserToResizeRows = false;
            this.dataGridViewFournisseur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewFournisseur.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFournisseur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewFournisseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFournisseur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewFournisseur.GridColor = System.Drawing.Color.White;
            this.dataGridViewFournisseur.Location = new System.Drawing.Point(105, 52);
            this.dataGridViewFournisseur.MultiSelect = false;
            this.dataGridViewFournisseur.Name = "dataGridViewFournisseur";
            this.dataGridViewFournisseur.ReadOnly = true;
            this.dataGridViewFournisseur.RowHeadersVisible = false;
            this.dataGridViewFournisseur.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewFournisseur.RowTemplate.Height = 28;
            this.dataGridViewFournisseur.ShowEditingIcon = false;
            this.dataGridViewFournisseur.Size = new System.Drawing.Size(1044, 422);
            this.dataGridViewFournisseur.TabIndex = 13;
            // 
            // btnOpenAddFournisseur
            // 
            this.btnOpenAddFournisseur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenAddFournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(174)))), ((int)(((byte)(124)))));
            this.btnOpenAddFournisseur.FlatAppearance.BorderSize = 0;
            this.btnOpenAddFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenAddFournisseur.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenAddFournisseur.ForeColor = System.Drawing.Color.White;
            this.btnOpenAddFournisseur.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnOpenAddFournisseur.IconColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOpenAddFournisseur.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOpenAddFournisseur.Location = new System.Drawing.Point(976, 512);
            this.btnOpenAddFournisseur.Name = "btnOpenAddFournisseur";
            this.btnOpenAddFournisseur.Size = new System.Drawing.Size(173, 65);
            this.btnOpenAddFournisseur.TabIndex = 14;
            this.btnOpenAddFournisseur.Text = "Ajouter une pièce";
            this.btnOpenAddFournisseur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenAddFournisseur.UseVisualStyleBackColor = false;
            this.btnOpenAddFournisseur.Click += new System.EventHandler(this.btnOpenAddFournisseur_Click);
            // 
            // dataIdPiece
            // 
            this.dataIdPiece.DataPropertyName = "idPiece";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataIdPiece.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataIdPiece.HeaderText = "idPiece";
            this.dataIdPiece.Name = "dataIdPiece";
            this.dataIdPiece.ReadOnly = true;
            this.dataIdPiece.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataDesc
            // 
            this.dataDesc.DataPropertyName = "description";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDesc.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataDesc.HeaderText = "description";
            this.dataDesc.Name = "dataDesc";
            this.dataDesc.ReadOnly = true;
            // 
            // dataCategorie
            // 
            this.dataCategorie.DataPropertyName = "categorie";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataCategorie.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataCategorie.HeaderText = "categorie";
            this.dataCategorie.Name = "dataCategorie";
            this.dataCategorie.ReadOnly = true;
            // 
            // dataPrixU
            // 
            this.dataPrixU.DataPropertyName = "prixU";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPrixU.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataPrixU.HeaderText = "prixU";
            this.dataPrixU.Name = "dataPrixU";
            this.dataPrixU.ReadOnly = true;
            // 
            // dataStock
            // 
            this.dataStock.DataPropertyName = "stock";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataStock.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataStock.HeaderText = "stock";
            this.dataStock.Name = "dataStock";
            this.dataStock.ReadOnly = true;
            // 
            // dataDateI
            // 
            this.dataDateI.HeaderText = "dateI";
            this.dataDateI.Name = "dataDateI";
            this.dataDateI.ReadOnly = true;
            // 
            // dataDateD
            // 
            this.dataDateD.HeaderText = "dateD";
            this.dataDateD.Name = "dataDateD";
            this.dataDateD.ReadOnly = true;
            // 
            // dataDelaiA
            // 
            this.dataDelaiA.HeaderText = "delaiA";
            this.dataDelaiA.Name = "dataDelaiA";
            this.dataDelaiA.ReadOnly = true;
            // 
            // btnUpdate
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.btnUpdate.DefaultCellStyle = dataGridViewCellStyle13;
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
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.btnDelete.DefaultCellStyle = dataGridViewCellStyle14;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.HeaderText = "";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseColumnTextForButtonValue = true;
            this.btnDelete.Width = 150;
            // 
            // FormPiece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1255, 629);
            this.Controls.Add(this.dataGridViewFournisseur);
            this.Controls.Add(this.btnOpenAddFournisseur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPiece";
            this.Text = "FormPiece";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFournisseur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFournisseur;
        private FontAwesome.Sharp.IconButton btnOpenAddFournisseur;
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
    }
}