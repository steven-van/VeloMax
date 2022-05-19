namespace VeloMax.ChildForms
{
    partial class FormModele
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
            this.dataGridViewModele = new System.Windows.Forms.DataGridView();
            this.btnOpenAddModele = new FontAwesome.Sharp.IconButton();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataIdModele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGrandeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPrixU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLigneP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDateI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDateD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModele)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewModele
            // 
            this.dataGridViewModele.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.dataGridViewModele.AllowUserToAddRows = false;
            this.dataGridViewModele.AllowUserToDeleteRows = false;
            this.dataGridViewModele.AllowUserToResizeColumns = false;
            this.dataGridViewModele.AllowUserToResizeRows = false;
            this.dataGridViewModele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewModele.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewModele.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewModele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataIdModele,
            this.dataNom,
            this.dataGrandeur,
            this.dataPrixU,
            this.dataLigneP,
            this.dataDateI,
            this.dataDateD,
            this.dataStock,
            this.btnUpdate,
            this.btnDelete});
            this.dataGridViewModele.GridColor = System.Drawing.Color.White;
            this.dataGridViewModele.Location = new System.Drawing.Point(105, 140);
            this.dataGridViewModele.MultiSelect = false;
            this.dataGridViewModele.Name = "dataGridViewModele";
            this.dataGridViewModele.ReadOnly = true;
            this.dataGridViewModele.RowHeadersVisible = false;
            this.dataGridViewModele.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewModele.RowTemplate.Height = 28;
            this.dataGridViewModele.ShowEditingIcon = false;
            this.dataGridViewModele.Size = new System.Drawing.Size(1044, 422);
            this.dataGridViewModele.TabIndex = 13;
            this.dataGridViewModele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewModele_CellClick);
            // 
            // btnOpenAddModele
            // 
            this.btnOpenAddModele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenAddModele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(174)))), ((int)(((byte)(124)))));
            this.btnOpenAddModele.FlatAppearance.BorderSize = 0;
            this.btnOpenAddModele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenAddModele.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenAddModele.ForeColor = System.Drawing.Color.White;
            this.btnOpenAddModele.IconChar = FontAwesome.Sharp.IconChar.Bicycle;
            this.btnOpenAddModele.IconColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOpenAddModele.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOpenAddModele.Location = new System.Drawing.Point(105, 43);
            this.btnOpenAddModele.Name = "btnOpenAddModele";
            this.btnOpenAddModele.Size = new System.Drawing.Size(173, 65);
            this.btnOpenAddModele.TabIndex = 14;
            this.btnOpenAddModele.Text = "Ajouter un modèle";
            this.btnOpenAddModele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenAddModele.UseVisualStyleBackColor = false;
            this.btnOpenAddModele.Click += new System.EventHandler(this.btnOpenAddModele_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearch.BackColor = System.Drawing.Color.White;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(855, 73);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(294, 35);
            this.textBoxSearch.TabIndex = 18;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // dataIdModele
            // 
            this.dataIdModele.DataPropertyName = "idModele";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataIdModele.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataIdModele.HeaderText = "idModele";
            this.dataIdModele.Name = "dataIdModele";
            this.dataIdModele.ReadOnly = true;
            this.dataIdModele.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataIdModele.Width = 150;
            // 
            // dataNom
            // 
            this.dataNom.DataPropertyName = "nom";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataNom.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataNom.HeaderText = "nom";
            this.dataNom.Name = "dataNom";
            this.dataNom.ReadOnly = true;
            this.dataNom.Width = 150;
            // 
            // dataGrandeur
            // 
            this.dataGrandeur.DataPropertyName = "grandeur";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrandeur.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrandeur.HeaderText = "grandeur";
            this.dataGrandeur.Name = "dataGrandeur";
            this.dataGrandeur.ReadOnly = true;
            this.dataGrandeur.Width = 150;
            // 
            // dataPrixU
            // 
            this.dataPrixU.DataPropertyName = "prixU";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPrixU.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataPrixU.HeaderText = "prixU";
            this.dataPrixU.Name = "dataPrixU";
            this.dataPrixU.ReadOnly = true;
            this.dataPrixU.Width = 150;
            // 
            // dataLigneP
            // 
            this.dataLigneP.DataPropertyName = "ligneP";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLigneP.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataLigneP.HeaderText = "ligneP";
            this.dataLigneP.Name = "dataLigneP";
            this.dataLigneP.ReadOnly = true;
            this.dataLigneP.Width = 150;
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
            // dataStock
            // 
            this.dataStock.DataPropertyName = "stock";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataStock.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataStock.HeaderText = "stock";
            this.dataStock.Name = "dataStock";
            this.dataStock.ReadOnly = true;
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
            // FormModele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1255, 629);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridViewModele);
            this.Controls.Add(this.btnOpenAddModele);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormModele";
            this.Text = "FormModele";
            this.Shown += new System.EventHandler(this.FormModele_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewModele;
        private FontAwesome.Sharp.IconButton btnOpenAddModele;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataIdModele;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGrandeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPrixU;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLigneP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDateI;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDateD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataStock;
        private System.Windows.Forms.DataGridViewButtonColumn btnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}