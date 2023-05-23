namespace ChopesGames
{
    partial class FormCreerProduit
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
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblPrixHT = new System.Windows.Forms.Label();
            this.lblTauxTVA = new System.Windows.Forms.Label();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.cmbMarque = new System.Windows.Forms.ComboBox();
            this.tbxLibelle = new System.Windows.Forms.TextBox();
            this.tbxDetail = new System.Windows.Forms.TextBox();
            this.tbxPrixHT = new System.Windows.Forms.TextBox();
            this.tbxTauxTVA = new System.Windows.Forms.TextBox();
            this.btnCreer = new System.Windows.Forms.Button();
            this.lblNomImage = new System.Windows.Forms.Label();
            this.lblQuantiteStock = new System.Windows.Forms.Label();
            this.lblDateAjout = new System.Windows.Forms.Label();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.lblVitrine = new System.Windows.Forms.Label();
            this.tbxNomImage = new System.Windows.Forms.TextBox();
            this.tbxQteStock = new System.Windows.Forms.TextBox();
            this.radBtnDispoOui = new System.Windows.Forms.RadioButton();
            this.radBtnDispoNon = new System.Windows.Forms.RadioButton();
            this.dateAjout = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radBtnVitNon = new System.Windows.Forms.RadioButton();
            this.radBtnVitOui = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(37, 58);
            this.lblCategorie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(66, 16);
            this.lblCategorie.TabIndex = 0;
            this.lblCategorie.Text = "Catégorie";
            // 
            // lblMarque
            // 
            this.lblMarque.AutoSize = true;
            this.lblMarque.Location = new System.Drawing.Point(37, 97);
            this.lblMarque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarque.Name = "lblMarque";
            this.lblMarque.Size = new System.Drawing.Size(53, 16);
            this.lblMarque.TabIndex = 1;
            this.lblMarque.Text = "Marque";
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Location = new System.Drawing.Point(37, 145);
            this.lblLibelle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(47, 16);
            this.lblLibelle.TabIndex = 2;
            this.lblLibelle.Text = "Libellé";
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Location = new System.Drawing.Point(37, 191);
            this.lblDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(42, 16);
            this.lblDetail.TabIndex = 3;
            this.lblDetail.Text = "Détail";
            // 
            // lblPrixHT
            // 
            this.lblPrixHT.AutoSize = true;
            this.lblPrixHT.Location = new System.Drawing.Point(39, 364);
            this.lblPrixHT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrixHT.Name = "lblPrixHT";
            this.lblPrixHT.Size = new System.Drawing.Size(51, 16);
            this.lblPrixHT.TabIndex = 4;
            this.lblPrixHT.Text = "Prix HT";
            // 
            // lblTauxTVA
            // 
            this.lblTauxTVA.AutoSize = true;
            this.lblTauxTVA.Location = new System.Drawing.Point(37, 401);
            this.lblTauxTVA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTauxTVA.Name = "lblTauxTVA";
            this.lblTauxTVA.Size = new System.Drawing.Size(67, 16);
            this.lblTauxTVA.TabIndex = 5;
            this.lblTauxTVA.Text = "Taux TVA";
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Location = new System.Drawing.Point(204, 47);
            this.cmbCategorie.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(195, 24);
            this.cmbCategorie.TabIndex = 6;
            this.cmbCategorie.SelectedIndexChanged += new System.EventHandler(this.cmbCategorie_SelectedIndexChanged);
            // 
            // cmbMarque
            // 
            this.cmbMarque.FormattingEnabled = true;
            this.cmbMarque.Location = new System.Drawing.Point(204, 87);
            this.cmbMarque.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMarque.Name = "cmbMarque";
            this.cmbMarque.Size = new System.Drawing.Size(195, 24);
            this.cmbMarque.TabIndex = 7;
            this.cmbMarque.SelectedIndexChanged += new System.EventHandler(this.cmbMarque_SelectedIndexChanged);
            // 
            // tbxLibelle
            // 
            this.tbxLibelle.Location = new System.Drawing.Point(204, 145);
            this.tbxLibelle.Margin = new System.Windows.Forms.Padding(4);
            this.tbxLibelle.Name = "tbxLibelle";
            this.tbxLibelle.Size = new System.Drawing.Size(195, 22);
            this.tbxLibelle.TabIndex = 8;
            // 
            // tbxDetail
            // 
            this.tbxDetail.Location = new System.Drawing.Point(204, 191);
            this.tbxDetail.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDetail.Multiline = true;
            this.tbxDetail.Name = "tbxDetail";
            this.tbxDetail.Size = new System.Drawing.Size(195, 142);
            this.tbxDetail.TabIndex = 9;
            // 
            // tbxPrixHT
            // 
            this.tbxPrixHT.Location = new System.Drawing.Point(204, 356);
            this.tbxPrixHT.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPrixHT.Name = "tbxPrixHT";
            this.tbxPrixHT.Size = new System.Drawing.Size(195, 22);
            this.tbxPrixHT.TabIndex = 10;
            this.tbxPrixHT.Leave += new System.EventHandler(this.tbxPrixHT_Leave);
            // 
            // tbxTauxTVA
            // 
            this.tbxTauxTVA.Location = new System.Drawing.Point(204, 401);
            this.tbxTauxTVA.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTauxTVA.Name = "tbxTauxTVA";
            this.tbxTauxTVA.Size = new System.Drawing.Size(195, 22);
            this.tbxTauxTVA.TabIndex = 11;
            this.tbxTauxTVA.Leave += new System.EventHandler(this.tbxTauxTVA_Leave);
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(575, 356);
            this.btnCreer.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(161, 46);
            this.btnCreer.TabIndex = 12;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // lblNomImage
            // 
            this.lblNomImage.AutoSize = true;
            this.lblNomImage.Location = new System.Drawing.Point(465, 54);
            this.lblNomImage.Name = "lblNomImage";
            this.lblNomImage.Size = new System.Drawing.Size(110, 16);
            this.lblNomImage.TabIndex = 13;
            this.lblNomImage.Text = "Nome de l\'image";
            // 
            // lblQuantiteStock
            // 
            this.lblQuantiteStock.AutoSize = true;
            this.lblQuantiteStock.Location = new System.Drawing.Point(465, 93);
            this.lblQuantiteStock.Name = "lblQuantiteStock";
            this.lblQuantiteStock.Size = new System.Drawing.Size(109, 16);
            this.lblQuantiteStock.TabIndex = 14;
            this.lblQuantiteStock.Text = "Quantité en stock";
            // 
            // lblDateAjout
            // 
            this.lblDateAjout.AutoSize = true;
            this.lblDateAjout.Location = new System.Drawing.Point(465, 145);
            this.lblDateAjout.Name = "lblDateAjout";
            this.lblDateAjout.Size = new System.Drawing.Size(79, 16);
            this.lblDateAjout.TabIndex = 15;
            this.lblDateAjout.Text = "Date d\'ajout";
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Location = new System.Drawing.Point(465, 236);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(77, 16);
            this.lblDisponible.TabIndex = 16;
            this.lblDisponible.Text = "Disoinible ?";
            // 
            // lblVitrine
            // 
            this.lblVitrine.AutoSize = true;
            this.lblVitrine.Location = new System.Drawing.Point(465, 287);
            this.lblVitrine.Name = "lblVitrine";
            this.lblVitrine.Size = new System.Drawing.Size(54, 16);
            this.lblVitrine.TabIndex = 17;
            this.lblVitrine.Text = "Vitrine ?";
            // 
            // tbxNomImage
            // 
            this.tbxNomImage.Location = new System.Drawing.Point(612, 48);
            this.tbxNomImage.Name = "tbxNomImage";
            this.tbxNomImage.Size = new System.Drawing.Size(219, 22);
            this.tbxNomImage.TabIndex = 18;
            // 
            // tbxQteStock
            // 
            this.tbxQteStock.Location = new System.Drawing.Point(612, 91);
            this.tbxQteStock.Name = "tbxQteStock";
            this.tbxQteStock.Size = new System.Drawing.Size(219, 22);
            this.tbxQteStock.TabIndex = 19;
            // 
            // radBtnDispoOui
            // 
            this.radBtnDispoOui.AutoSize = true;
            this.radBtnDispoOui.Location = new System.Drawing.Point(612, 234);
            this.radBtnDispoOui.Name = "radBtnDispoOui";
            this.radBtnDispoOui.Size = new System.Drawing.Size(51, 20);
            this.radBtnDispoOui.TabIndex = 20;
            this.radBtnDispoOui.TabStop = true;
            this.radBtnDispoOui.Text = "OUI";
            this.radBtnDispoOui.UseVisualStyleBackColor = true;
            // 
            // radBtnDispoNon
            // 
            this.radBtnDispoNon.AutoSize = true;
            this.radBtnDispoNon.Location = new System.Drawing.Point(716, 232);
            this.radBtnDispoNon.Name = "radBtnDispoNon";
            this.radBtnDispoNon.Size = new System.Drawing.Size(58, 20);
            this.radBtnDispoNon.TabIndex = 21;
            this.radBtnDispoNon.TabStop = true;
            this.radBtnDispoNon.Text = "NON";
            this.radBtnDispoNon.UseVisualStyleBackColor = true;
            // 
            // dateAjout
            // 
            this.dateAjout.CustomFormat = "yyyy-MM-dd";
            this.dateAjout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAjout.Location = new System.Drawing.Point(612, 143);
            this.dateAjout.Name = "dateAjout";
            this.dateAjout.Size = new System.Drawing.Size(200, 22);
            this.dateAjout.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radBtnVitNon);
            this.panel1.Controls.Add(this.radBtnVitOui);
            this.panel1.Location = new System.Drawing.Point(591, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 55);
            this.panel1.TabIndex = 25;
            // 
            // radBtnVitNon
            // 
            this.radBtnVitNon.AutoSize = true;
            this.radBtnVitNon.Location = new System.Drawing.Point(125, 18);
            this.radBtnVitNon.Name = "radBtnVitNon";
            this.radBtnVitNon.Size = new System.Drawing.Size(58, 20);
            this.radBtnVitNon.TabIndex = 25;
            this.radBtnVitNon.TabStop = true;
            this.radBtnVitNon.Text = "NON";
            this.radBtnVitNon.UseVisualStyleBackColor = true;
            // 
            // radBtnVitOui
            // 
            this.radBtnVitOui.AutoSize = true;
            this.radBtnVitOui.Location = new System.Drawing.Point(21, 18);
            this.radBtnVitOui.Name = "radBtnVitOui";
            this.radBtnVitOui.Size = new System.Drawing.Size(51, 20);
            this.radBtnVitOui.TabIndex = 24;
            this.radBtnVitOui.TabStop = true;
            this.radBtnVitOui.Text = "OUI";
            this.radBtnVitOui.UseVisualStyleBackColor = true;
            // 
            // FormCreerProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateAjout);
            this.Controls.Add(this.radBtnDispoNon);
            this.Controls.Add(this.radBtnDispoOui);
            this.Controls.Add(this.tbxQteStock);
            this.Controls.Add(this.tbxNomImage);
            this.Controls.Add(this.lblVitrine);
            this.Controls.Add(this.lblDisponible);
            this.Controls.Add(this.lblDateAjout);
            this.Controls.Add(this.lblQuantiteStock);
            this.Controls.Add(this.lblNomImage);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.tbxTauxTVA);
            this.Controls.Add(this.tbxPrixHT);
            this.Controls.Add(this.tbxDetail);
            this.Controls.Add(this.tbxLibelle);
            this.Controls.Add(this.cmbMarque);
            this.Controls.Add(this.cmbCategorie);
            this.Controls.Add(this.lblTauxTVA);
            this.Controls.Add(this.lblPrixHT);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.lblLibelle);
            this.Controls.Add(this.lblMarque);
            this.Controls.Add(this.lblCategorie);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCreerProduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Créer un produit";
            this.Load += new System.EventHandler(this.FormCreerProduit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label lblPrixHT;
        private System.Windows.Forms.Label lblTauxTVA;
        private System.Windows.Forms.Label lblNomImage;
        private System.Windows.Forms.Label lblQuantiteStock;
        private System.Windows.Forms.Label lblDateAjout;
        private System.Windows.Forms.Label lblDisponible;
        private System.Windows.Forms.Label lblVitrine;
        public System.Windows.Forms.ComboBox cmbCategorie;
        public System.Windows.Forms.ComboBox cmbMarque;
        public System.Windows.Forms.TextBox tbxLibelle;
        public System.Windows.Forms.TextBox tbxDetail;
        public System.Windows.Forms.TextBox tbxPrixHT;
        public System.Windows.Forms.TextBox tbxTauxTVA;
        public System.Windows.Forms.Button btnCreer;
        public System.Windows.Forms.TextBox tbxNomImage;
        public System.Windows.Forms.TextBox tbxQteStock;
        public System.Windows.Forms.RadioButton radBtnDispoOui;
        public System.Windows.Forms.RadioButton radBtnDispoNon;
        public System.Windows.Forms.DateTimePicker dateAjout;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.RadioButton radBtnVitNon;
        public System.Windows.Forms.RadioButton radBtnVitOui;
    }
}