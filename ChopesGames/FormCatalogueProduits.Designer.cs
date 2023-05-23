namespace ChopesGames
{
    partial class FormCatalogueProduits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCatalogueProduits));
            this.dgridCatalogue = new System.Windows.Forms.DataGridView();
            this.btnAjouterProduit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnModifierProduit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSupprimerProduit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnActualiserTab = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tbxRechercherProduit = new System.Windows.Forms.ToolStripTextBox();
            this.lblTriCategorie = new System.Windows.Forms.ToolStripLabel();
            this.cmbTriCategorie = new System.Windows.Forms.ToolStripComboBox();
            this.lblTriMarque = new System.Windows.Forms.ToolStripLabel();
            this.cmbTriMarque = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgridCatalogue)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgridCatalogue
            // 
            this.dgridCatalogue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgridCatalogue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgridCatalogue.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgridCatalogue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridCatalogue.Location = new System.Drawing.Point(2, 63);
            this.dgridCatalogue.Name = "dgridCatalogue";
            this.dgridCatalogue.ReadOnly = true;
            this.dgridCatalogue.RowHeadersWidth = 51;
            this.dgridCatalogue.RowTemplate.Height = 24;
            this.dgridCatalogue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgridCatalogue.Size = new System.Drawing.Size(1806, 711);
            this.dgridCatalogue.TabIndex = 0;
            // 
            // btnAjouterProduit
            // 
            this.btnAjouterProduit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterProduit.Image = ((System.Drawing.Image)(resources.GetObject("btnAjouterProduit.Image")));
            this.btnAjouterProduit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAjouterProduit.Name = "btnAjouterProduit";
            this.btnAjouterProduit.Size = new System.Drawing.Size(106, 51);
            this.btnAjouterProduit.Text = "Ajouter";
            this.btnAjouterProduit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterProduit.ToolTipText = "Nouveau";
            this.btnAjouterProduit.Click += new System.EventHandler(this.btnAjouterProduit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // btnModifierProduit
            // 
            this.btnModifierProduit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierProduit.Image = ((System.Drawing.Image)(resources.GetObject("btnModifierProduit.Image")));
            this.btnModifierProduit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModifierProduit.Name = "btnModifierProduit";
            this.btnModifierProduit.Size = new System.Drawing.Size(116, 51);
            this.btnModifierProduit.Text = "Modifier";
            this.btnModifierProduit.ToolTipText = "Modification";
            this.btnModifierProduit.Click += new System.EventHandler(this.btnModifierProduit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // btnSupprimerProduit
            // 
            this.btnSupprimerProduit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerProduit.Image = ((System.Drawing.Image)(resources.GetObject("btnSupprimerProduit.Image")));
            this.btnSupprimerProduit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSupprimerProduit.Name = "btnSupprimerProduit";
            this.btnSupprimerProduit.Size = new System.Drawing.Size(132, 51);
            this.btnSupprimerProduit.Text = "Supprimer";
            this.btnSupprimerProduit.ToolTipText = "supprimer";
            this.btnSupprimerProduit.Click += new System.EventHandler(this.btnSupprimerProduit_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 54);
            // 
            // btnActualiserTab
            // 
            this.btnActualiserTab.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualiserTab.Image = ((System.Drawing.Image)(resources.GetObject("btnActualiserTab.Image")));
            this.btnActualiserTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualiserTab.Name = "btnActualiserTab";
            this.btnActualiserTab.Size = new System.Drawing.Size(125, 51);
            this.btnActualiserTab.Text = "Actualiser";
            this.btnActualiserTab.ToolTipText = "Actualiser";
            this.btnActualiserTab.Click += new System.EventHandler(this.btnActualiserTab_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 54);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 51);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(13, 51);
            this.toolStripLabel2.Text = " ";
            // 
            // tbxRechercherProduit
            // 
            this.tbxRechercherProduit.AccessibleName = "  ";
            this.tbxRechercherProduit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxRechercherProduit.BackColor = System.Drawing.Color.White;
            this.tbxRechercherProduit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxRechercherProduit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRechercherProduit.Name = "tbxRechercherProduit";
            this.tbxRechercherProduit.Size = new System.Drawing.Size(373, 54);
            this.tbxRechercherProduit.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxRechercherProduit.TextChanged += new System.EventHandler(this.tbxRechercherProduit_TextChanged);
            // 
            // lblTriCategorie
            // 
            this.lblTriCategorie.Name = "lblTriCategorie";
            this.lblTriCategorie.Size = new System.Drawing.Size(131, 51);
            this.lblTriCategorie.Text = "Trier par catégorie";
            // 
            // cmbTriCategorie
            // 
            this.cmbTriCategorie.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmbTriCategorie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbTriCategorie.Name = "cmbTriCategorie";
            this.cmbTriCategorie.Size = new System.Drawing.Size(225, 54);
            this.cmbTriCategorie.SelectedIndexChanged += new System.EventHandler(this.cmbTriCategorie_SelectedIndexChanged);
            // 
            // lblTriMarque
            // 
            this.lblTriMarque.Name = "lblTriMarque";
            this.lblTriMarque.Size = new System.Drawing.Size(119, 51);
            this.lblTriMarque.Text = "Trier par marque";
            // 
            // cmbTriMarque
            // 
            this.cmbTriMarque.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmbTriMarque.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbTriMarque.Name = "cmbTriMarque";
            this.cmbTriMarque.Size = new System.Drawing.Size(180, 54);
            this.cmbTriMarque.SelectedIndexChanged += new System.EventHandler(this.cmbTriMarque_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAjouterProduit,
            this.toolStripSeparator1,
            this.btnModifierProduit,
            this.toolStripSeparator2,
            this.btnSupprimerProduit,
            this.toolStripSeparator3,
            this.btnActualiserTab,
            this.toolStripSeparator5,
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.tbxRechercherProduit,
            this.lblTriCategorie,
            this.cmbTriCategorie,
            this.lblTriMarque,
            this.cmbTriMarque});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1808, 54);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FormCatalogueProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1808, 775);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgridCatalogue);
            this.Name = "FormCatalogueProduits";
            this.Text = "FormCatalogueProduits";
            this.Load += new System.EventHandler(this.FormCatalogueProduits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridCatalogue)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgridCatalogue;
        private System.Windows.Forms.ToolStripButton btnAjouterProduit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnModifierProduit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSupprimerProduit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnActualiserTab;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        public System.Windows.Forms.ToolStripTextBox tbxRechercherProduit;
        private System.Windows.Forms.ToolStripLabel lblTriCategorie;
        private System.Windows.Forms.ToolStripComboBox cmbTriCategorie;
        private System.Windows.Forms.ToolStripLabel lblTriMarque;
        private System.Windows.Forms.ToolStripComboBox cmbTriMarque;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}