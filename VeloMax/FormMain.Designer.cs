namespace VeloMax
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnStats = new FontAwesome.Sharp.IconButton();
            this.btnStock = new FontAwesome.Sharp.IconButton();
            this.btnCommande = new FontAwesome.Sharp.IconButton();
            this.btnFournisseur = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitleActiveForm = new System.Windows.Forms.Label();
            this.iconActiveForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconActiveForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnStats);
            this.panelMenu.Controls.Add(this.btnStock);
            this.panelMenu.Controls.Add(this.btnCommande);
            this.panelMenu.Controls.Add(this.btnFournisseur);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 544);
            this.panelMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 40;
            this.btnExit.Location = new System.Drawing.Point(0, 484);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5);
            this.btnExit.Size = new System.Drawing.Size(220, 60);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Quitter";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStats
            // 
            this.btnStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStats.FlatAppearance.BorderSize = 0;
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStats.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.ForeColor = System.Drawing.Color.White;
            this.btnStats.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnStats.IconColor = System.Drawing.Color.White;
            this.btnStats.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStats.IconSize = 40;
            this.btnStats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStats.Location = new System.Drawing.Point(0, 280);
            this.btnStats.Name = "btnStats";
            this.btnStats.Padding = new System.Windows.Forms.Padding(5);
            this.btnStats.Size = new System.Drawing.Size(220, 60);
            this.btnStats.TabIndex = 4;
            this.btnStats.Text = "Statistiques";
            this.btnStats.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnStock
            // 
            this.btnStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.btnStock.IconColor = System.Drawing.Color.White;
            this.btnStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStock.IconSize = 40;
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(0, 220);
            this.btnStock.Name = "btnStock";
            this.btnStock.Padding = new System.Windows.Forms.Padding(5);
            this.btnStock.Size = new System.Drawing.Size(220, 60);
            this.btnStock.TabIndex = 3;
            this.btnStock.Text = "Stock";
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnCommande
            // 
            this.btnCommande.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCommande.FlatAppearance.BorderSize = 0;
            this.btnCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommande.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommande.ForeColor = System.Drawing.Color.White;
            this.btnCommande.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            this.btnCommande.IconColor = System.Drawing.Color.White;
            this.btnCommande.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCommande.IconSize = 40;
            this.btnCommande.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCommande.Location = new System.Drawing.Point(0, 160);
            this.btnCommande.Name = "btnCommande";
            this.btnCommande.Padding = new System.Windows.Forms.Padding(5);
            this.btnCommande.Size = new System.Drawing.Size(220, 60);
            this.btnCommande.TabIndex = 2;
            this.btnCommande.Text = "Commandes";
            this.btnCommande.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCommande.UseVisualStyleBackColor = true;
            this.btnCommande.Click += new System.EventHandler(this.btnCommande_Click);
            // 
            // btnFournisseur
            // 
            this.btnFournisseur.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFournisseur.FlatAppearance.BorderSize = 0;
            this.btnFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFournisseur.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFournisseur.ForeColor = System.Drawing.Color.White;
            this.btnFournisseur.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btnFournisseur.IconColor = System.Drawing.Color.White;
            this.btnFournisseur.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFournisseur.IconSize = 40;
            this.btnFournisseur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFournisseur.Location = new System.Drawing.Point(0, 100);
            this.btnFournisseur.Name = "btnFournisseur";
            this.btnFournisseur.Padding = new System.Windows.Forms.Padding(5);
            this.btnFournisseur.Size = new System.Drawing.Size(220, 60);
            this.btnFournisseur.TabIndex = 0;
            this.btnFournisseur.Text = "Fournisseurs";
            this.btnFournisseur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFournisseur.UseVisualStyleBackColor = true;
            this.btnFournisseur.Click += new System.EventHandler(this.btnFournisseur_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 100);
            this.panelLogo.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.Image = global::VeloMax.Properties.Resources.velo_max;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(220, 100);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.panelHeader.Controls.Add(this.labelTitleActiveForm);
            this.panelHeader.Controls.Add(this.iconActiveForm);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(220, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(958, 100);
            this.panelHeader.TabIndex = 1;
            // 
            // labelTitleActiveForm
            // 
            this.labelTitleActiveForm.AutoSize = true;
            this.labelTitleActiveForm.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleActiveForm.ForeColor = System.Drawing.Color.White;
            this.labelTitleActiveForm.Location = new System.Drawing.Point(66, 36);
            this.labelTitleActiveForm.Name = "labelTitleActiveForm";
            this.labelTitleActiveForm.Size = new System.Drawing.Size(68, 25);
            this.labelTitleActiveForm.TabIndex = 1;
            this.labelTitleActiveForm.Text = "Home";
            // 
            // iconActiveForm
            // 
            this.iconActiveForm.BackColor = System.Drawing.Color.Transparent;
            this.iconActiveForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconActiveForm.IconColor = System.Drawing.Color.White;
            this.iconActiveForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconActiveForm.IconSize = 40;
            this.iconActiveForm.Location = new System.Drawing.Point(21, 30);
            this.iconActiveForm.Name = "iconActiveForm";
            this.iconActiveForm.Size = new System.Drawing.Size(40, 40);
            this.iconActiveForm.TabIndex = 0;
            this.iconActiveForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(50)))));
            this.panelDesktop.Controls.Add(this.labelDate);
            this.panelDesktop.Controls.Add(this.labelHours);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 100);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(958, 444);
            this.panelDesktop.TabIndex = 2;
            // 
            // labelDate
            // 
            this.labelDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(378, 213);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(181, 44);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "01/01/0001";
            // 
            // labelHours
            // 
            this.labelHours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHours.AutoSize = true;
            this.labelHours.Font = new System.Drawing.Font("Montserrat SemiBold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(48)))));
            this.labelHours.Location = new System.Drawing.Point(373, 136);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(289, 77);
            this.labelHours.TabIndex = 0;
            this.labelHours.Text = "00:00:00";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 544);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMain";
            this.Text = "VeloMax";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconActiveForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnFournisseur;
        private FontAwesome.Sharp.IconButton btnStats;
        private FontAwesome.Sharp.IconButton btnStock;
        private FontAwesome.Sharp.IconButton btnCommande;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Label labelTitleActiveForm;
        private FontAwesome.Sharp.IconPictureBox iconActiveForm;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelDate;
    }
}

