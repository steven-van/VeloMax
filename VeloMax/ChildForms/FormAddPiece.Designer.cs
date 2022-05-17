namespace VeloMax.ChildForms
{
    partial class FormAddPiece
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
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelDelaiA = new System.Windows.Forms.Label();
            this.labelDateD = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelDateI = new System.Windows.Forms.Label();
            this.labelPrixU = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.labelCategorie = new System.Windows.Forms.Label();
            this.comboBoxCategorie = new System.Windows.Forms.ComboBox();
            this.datePickerDateI = new System.Windows.Forms.DateTimePicker();
            this.datePickerDateD = new System.Windows.Forms.DateTimePicker();
            this.numDelaiA = new System.Windows.Forms.NumericUpDown();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.numPrixU = new System.Windows.Forms.NumericUpDown();
            this.btnAddPiece = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.numDelaiA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrixU)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDesc
            // 
            this.labelDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDesc.AutoSize = true;
            this.labelDesc.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesc.ForeColor = System.Drawing.Color.White;
            this.labelDesc.Location = new System.Drawing.Point(220, 69);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(129, 28);
            this.labelDesc.TabIndex = 1;
            this.labelDesc.Text = "Description";
            // 
            // labelDelaiA
            // 
            this.labelDelaiA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDelaiA.AutoSize = true;
            this.labelDelaiA.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelaiA.ForeColor = System.Drawing.Color.White;
            this.labelDelaiA.Location = new System.Drawing.Point(45, 549);
            this.labelDelaiA.Name = "labelDelaiA";
            this.labelDelaiA.Size = new System.Drawing.Size(286, 28);
            this.labelDelaiA.TabIndex = 3;
            this.labelDelaiA.Text = "Délai d\'approvisionnement";
            // 
            // labelDateD
            // 
            this.labelDateD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDateD.AutoSize = true;
            this.labelDateD.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateD.ForeColor = System.Drawing.Color.White;
            this.labelDateD.Location = new System.Drawing.Point(75, 466);
            this.labelDateD.Name = "labelDateD";
            this.labelDateD.Size = new System.Drawing.Size(256, 28);
            this.labelDateD.TabIndex = 4;
            this.labelDateD.Text = "Date de discontinuation";
            // 
            // labelStock
            // 
            this.labelStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.ForeColor = System.Drawing.Color.White;
            this.labelStock.Location = new System.Drawing.Point(281, 307);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(68, 28);
            this.labelStock.TabIndex = 5;
            this.labelStock.Text = "Stock";
            // 
            // labelDateI
            // 
            this.labelDateI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDateI.AutoSize = true;
            this.labelDateI.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateI.ForeColor = System.Drawing.Color.White;
            this.labelDateI.Location = new System.Drawing.Point(121, 389);
            this.labelDateI.Name = "labelDateI";
            this.labelDateI.Size = new System.Drawing.Size(210, 28);
            this.labelDateI.TabIndex = 6;
            this.labelDateI.Text = "Date d\'introduction";
            // 
            // labelPrixU
            // 
            this.labelPrixU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPrixU.AutoSize = true;
            this.labelPrixU.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrixU.ForeColor = System.Drawing.Color.White;
            this.labelPrixU.Location = new System.Drawing.Point(214, 224);
            this.labelPrixU.Name = "labelPrixU";
            this.labelPrixU.Size = new System.Drawing.Size(135, 28);
            this.labelPrixU.TabIndex = 7;
            this.labelPrixU.Text = "Prix Unitaire";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDesc.Location = new System.Drawing.Point(390, 71);
            this.textBoxDesc.MaxLength = 40;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(231, 26);
            this.textBoxDesc.TabIndex = 9;
            // 
            // labelCategorie
            // 
            this.labelCategorie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCategorie.AutoSize = true;
            this.labelCategorie.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategorie.ForeColor = System.Drawing.Color.White;
            this.labelCategorie.Location = new System.Drawing.Point(221, 149);
            this.labelCategorie.Name = "labelCategorie";
            this.labelCategorie.Size = new System.Drawing.Size(110, 28);
            this.labelCategorie.TabIndex = 16;
            this.labelCategorie.Text = "Catégorie";
            // 
            // comboBoxCategorie
            // 
            this.comboBoxCategorie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategorie.FormattingEnabled = true;
            this.comboBoxCategorie.Items.AddRange(new object[] {
            "Cadre",
            "Guidon",
            "Freins",
            "Selle",
            "Dérailleur avant",
            "Dérailleur arrière",
            "Roue avant",
            "Roue arrière",
            "Réflecteurs",
            "Pédalie",
            "Ordinateur",
            "Panier"});
            this.comboBoxCategorie.Location = new System.Drawing.Point(390, 149);
            this.comboBoxCategorie.Name = "comboBoxCategorie";
            this.comboBoxCategorie.Size = new System.Drawing.Size(231, 28);
            this.comboBoxCategorie.TabIndex = 17;
            // 
            // datePickerDateI
            // 
            this.datePickerDateI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datePickerDateI.Location = new System.Drawing.Point(390, 391);
            this.datePickerDateI.Name = "datePickerDateI";
            this.datePickerDateI.Size = new System.Drawing.Size(231, 26);
            this.datePickerDateI.TabIndex = 28;
            // 
            // datePickerDateD
            // 
            this.datePickerDateD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datePickerDateD.Location = new System.Drawing.Point(390, 466);
            this.datePickerDateD.Name = "datePickerDateD";
            this.datePickerDateD.Size = new System.Drawing.Size(231, 26);
            this.datePickerDateD.TabIndex = 29;
            // 
            // numDelaiA
            // 
            this.numDelaiA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numDelaiA.Location = new System.Drawing.Point(390, 554);
            this.numDelaiA.Name = "numDelaiA";
            this.numDelaiA.Size = new System.Drawing.Size(231, 26);
            this.numDelaiA.TabIndex = 30;
            // 
            // numStock
            // 
            this.numStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numStock.Location = new System.Drawing.Point(390, 307);
            this.numStock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(231, 26);
            this.numStock.TabIndex = 31;
            // 
            // numPrixU
            // 
            this.numPrixU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numPrixU.Location = new System.Drawing.Point(390, 229);
            this.numPrixU.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPrixU.Name = "numPrixU";
            this.numPrixU.Size = new System.Drawing.Size(231, 26);
            this.numPrixU.TabIndex = 32;
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
            this.btnAddPiece.IconColor = System.Drawing.Color.White;
            this.btnAddPiece.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddPiece.Location = new System.Drawing.Point(411, 645);
            this.btnAddPiece.Name = "btnAddPiece";
            this.btnAddPiece.Size = new System.Drawing.Size(173, 65);
            this.btnAddPiece.TabIndex = 15;
            this.btnAddPiece.Text = "Ajouter";
            this.btnAddPiece.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPiece.UseVisualStyleBackColor = false;
            this.btnAddPiece.Click += new System.EventHandler(this.btnAddPiece_Click);
            // 
            // FormAddPiece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(807, 808);
            this.Controls.Add(this.numPrixU);
            this.Controls.Add(this.numStock);
            this.Controls.Add(this.numDelaiA);
            this.Controls.Add(this.datePickerDateD);
            this.Controls.Add(this.datePickerDateI);
            this.Controls.Add(this.comboBoxCategorie);
            this.Controls.Add(this.labelCategorie);
            this.Controls.Add(this.btnAddPiece);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.labelPrixU);
            this.Controls.Add(this.labelDateI);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.labelDateD);
            this.Controls.Add(this.labelDelaiA);
            this.Controls.Add(this.labelDesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAddPiece";
            this.Text = "FormAddPiece";
            ((System.ComponentModel.ISupportInitialize)(this.numDelaiA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrixU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelDelaiA;
        private System.Windows.Forms.Label labelDateD;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelDateI;
        private System.Windows.Forms.Label labelPrixU;
        private System.Windows.Forms.TextBox textBoxDesc;
        private FontAwesome.Sharp.IconButton btnAddPiece;
        private System.Windows.Forms.Label labelCategorie;
        private System.Windows.Forms.ComboBox comboBoxCategorie;
        private System.Windows.Forms.DateTimePicker datePickerDateI;
        private System.Windows.Forms.DateTimePicker datePickerDateD;
        private System.Windows.Forms.NumericUpDown numDelaiA;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.NumericUpDown numPrixU;
    }
}