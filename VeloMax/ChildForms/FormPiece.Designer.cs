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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnAddPiece = new FontAwesome.Sharp.IconButton();
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
            this.dataGridViewPiece.Location = new System.Drawing.Point(105, 52);
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
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataIdPiece.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataIdPiece.HeaderText = "idPiece";
            this.dataIdPiece.Name = "dataIdPiece";
            this.dataIdPiece.ReadOnly = true;
            this.dataIdPiece.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataDesc
            // 
            this.dataDesc.DataPropertyName = "description";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDesc.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataDesc.HeaderText = "description";
            this.dataDesc.Name = "dataDesc";
            this.dataDesc.ReadOnly = true;
            // 
            // dataCategorie
            // 
            this.dataCategorie.DataPropertyName = "categorie";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataCategorie.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataCategorie.HeaderText = "categorie";
            this.dataCategorie.Name = "dataCategorie";
            this.dataCategorie.ReadOnly = true;
            // 
            // dataPrixU
            // 
            this.dataPrixU.DataPropertyName = "prixU";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPrixU.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataPrixU.HeaderText = "prixU";
            this.dataPrixU.Name = "dataPrixU";
            this.dataPrixU.ReadOnly = true;
            // 
            // dataStock
            // 
            this.dataStock.DataPropertyName = "stock";
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataStock.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataStock.HeaderText = "stock";
            this.dataStock.Name = "dataStock";
            this.dataStock.ReadOnly = true;
            // 
            // dataDateI
            // 
            this.dataDateI.DataPropertyName = "dateI";
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDateI.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataDateI.HeaderText = "dateI";
            this.dataDateI.Name = "dataDateI";
            this.dataDateI.ReadOnly = true;
            // 
            // dataDateD
            // 
            this.dataDateD.DataPropertyName = "dateD";
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDateD.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataDateD.HeaderText = "dateD";
            this.dataDateD.Name = "dataDateD";
            this.dataDateD.ReadOnly = true;
            // 
            // dataDelaiA
            // 
            this.dataDelaiA.DataPropertyName = "delaiA";
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDelaiA.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataDelaiA.HeaderText = "delaiA";
            this.dataDelaiA.Name = "dataDelaiA";
            this.dataDelaiA.ReadOnly = true;
            // 
            // btnUpdate
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            this.btnUpdate.DefaultCellStyle = dataGridViewCellStyle19;
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
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.btnDelete.DefaultCellStyle = dataGridViewCellStyle20;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.HeaderText = "";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseColumnTextForButtonValue = true;
            this.btnDelete.Width = 150;
            // 
            // btnAddPiece
            // 
            this.btnAddPiece.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddPiece.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(174)))), ((int)(((byte)(124)))));
            this.btnAddPiece.FlatAppearance.BorderSize = 0;
            this.btnAddPiece.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPiece.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPiece.ForeColor = System.Drawing.Color.White;
            this.btnAddPiece.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAddPiece.IconColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAddPiece.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddPiece.Location = new System.Drawing.Point(976, 512);
            this.btnAddPiece.Name = "btnAddPiece";
            this.btnAddPiece.Size = new System.Drawing.Size(173, 65);
            this.btnAddPiece.TabIndex = 14;
            this.btnAddPiece.Text = "Ajouter une pièce";
            this.btnAddPiece.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPiece.UseVisualStyleBackColor = false;
            this.btnAddPiece.Click += new System.EventHandler(this.btnAddPiece_Click);
            // 
            // FormPiece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1255, 629);
            this.Controls.Add(this.dataGridViewPiece);
            this.Controls.Add(this.btnAddPiece);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPiece";
            this.Text = "FormPiece";
            this.Load += new System.EventHandler(this.FormPiece_Load);
            this.Shown += new System.EventHandler(this.FormPiece_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPiece)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPiece;
        private FontAwesome.Sharp.IconButton btnAddPiece;
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