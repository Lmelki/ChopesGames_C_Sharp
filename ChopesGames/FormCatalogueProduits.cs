using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChopesGames
{
    public partial class FormCatalogueProduits : Form
    {
        public FormCatalogueProduits()
        {
            InitializeComponent();
        }
        //Récuperer tous les produits pour les afficher dans le tableau
        public void get_liste_produits()
        {
            try
            {
                // Se connecter à la base de données
                MySqlConnection maCnx;
                maCnx = new MySqlConnection("SERVER=127.0.0.1; DATABASE=ppe_chopesgames; UID=root; PASSWORD=;Convert Zero Datetime = true;");
                // Ouvrir la connexion et éxecuter la requet
                maCnx.Open();
                string sql = "SELECT NOPRODUIT AS 'NO',categorie.LIBELLE as 'CATEGORIE',marque.NOM as 'MARQUE',Produit.LIBELLE as 'LIBELLE',DETAIL,PRIXHT,TAUXTVA as 'TVA',NOMIMAGE,QUANTITEENSTOCK as 'QON',CONVERT (DATEAJOUT,DATETIME) as 'DATEAJOUT',DISPONIBLE,VITRINE FROM Produit join categorie on Produit.NOCATEGORIE  = categorie.NOCATEGORIE  join marque on Produit.NOMARQUE  = marque.NOMARQUE ";
                MySqlCommand cmd = new MySqlCommand(sql, maCnx);

                //Afficher les données en lecture sous forme de DataTable
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                //Injecter les données dans le tableau
                dgridCatalogue.DataSource = dataTable;
                //Fermer la connexion à la base de données
                maCnx.Close();
                maCnx.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FormCatalogueProduits_Load(object sender, EventArgs e)
        {
            get_liste_produits();

            // Chargement des catégories dans cmbCategorie
            try
            {
                MySqlConnection maCnx1 = new MySqlConnection("SERVER=127.0.0.1; DATABASE=ppe_chopesgames; UID=root; PASSWORD=; Convert Zero Datetime = true;");
                maCnx1.Open();
                string requete = "Select * from Categorie";
                MySqlCommand cmd = new MySqlCommand(requete, maCnx1);
                MySqlDataReader red = cmd.ExecuteReader();
                cmbTriCategorie.Items.Clear();
                while (red.Read())
                {
                    cmbTriCategorie.Items.Add(red["LIBELLE"]);
                }
                maCnx1.Close();
                maCnx1.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            // Chargement des marques dans cmbMarque

            try
            {
                MySqlConnection maCnx = new MySqlConnection("SERVER=127.0.0.1; DATABASE=ppe_chopesgames; UID=root; PASSWORD=; Convert Zero Datetime = true;");
                maCnx.Open();
                string requete = "Select * from Marque";
                MySqlCommand cmd = new MySqlCommand(requete, maCnx);
                MySqlDataReader red1 = cmd.ExecuteReader();
                cmbTriMarque.Items.Clear();
                while (red1.Read())
                {
                    cmbTriMarque.Items.Add(red1["NOM"]);
                }
                maCnx.Close();
                maCnx.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //--------------------- MODIFIER UN PRODUIT DANS LE CATALOGUE -----------------------------------------------------------------------------------------------------------------------------------
        private void btnModifierProduit_Click(object sender, EventArgs e)
        {
            //Si le tableau contient des produits
            if (dgridCatalogue.RowCount != 0) 
            {
                int index = dgridCatalogue.CurrentCell.RowIndex;
                if (index >= 0) 
                {
                    //Instanicier un objet formModifier avec les données de la ligne sélectionnée
                    DataGridViewRow selectedRow = dgridCatalogue.Rows[index];
                    FormCreerProduit formModifier = new FormCreerProduit();
                    formModifier.idProduit = selectedRow.Cells[0].Value.ToString();
                    formModifier.cmbCategorie.Text = selectedRow.Cells[1].Value.ToString();
                    formModifier.cmbMarque.Text = selectedRow.Cells[2].Value.ToString();
                    formModifier.tbxLibelle.Text = selectedRow.Cells[3].Value.ToString();
                    formModifier.tbxDetail.Text = selectedRow.Cells[4].Value.ToString();
                    formModifier.tbxPrixHT.Text = selectedRow.Cells[5].Value.ToString();
                    formModifier.tbxTauxTVA.Text = selectedRow.Cells[6].Value.ToString();
                    formModifier.tbxNomImage.Text = selectedRow.Cells[7].Value.ToString();
                    formModifier.tbxQteStock.Text = selectedRow.Cells[8].Value.ToString();
                    formModifier.dateAjout.Text = selectedRow.Cells[9].Value.ToString();
                    string dispo = selectedRow.Cells[10].Value.ToString();

                    if (dispo.Equals("True"))
                    {
                        formModifier.radBtnDispoOui.Checked= true;
                        formModifier.radBtnDispoNon.Checked = false;
                    }
                    else
                    {
                        formModifier.radBtnDispoNon.Checked = true;
                        formModifier.radBtnDispoOui.Checked = false;
                    }

                    string vitrine = selectedRow.Cells[11].Value.ToString();

                    if (vitrine.Equals("True"))
                    {
                        formModifier.radBtnVitOui.Checked = true;
                        formModifier.radBtnVitNon.Checked = false;
                    }
                    else
                    {
                        formModifier.radBtnVitNon.Checked = true;
                        formModifier.radBtnVitOui.Checked = false;
                    }

                    //Réutiliser le formCreerProduit pour la modification d'un produit
                    formModifier.Text = "Modifier Produit";
                    formModifier.btnCreer.Text = "Modifier";
                    formModifier.ShowDialog();

                    //Recharger les données dans le tableau
                    DataTable dt = new DataTable();
                    dgridCatalogue.DataSource = dt;
                    get_liste_produits();
                }
            }
            else //Si le tableau est vide
            {
                MessageBox.Show("Il n'y a aucun produit dans le catalogue");
            }
        }

        //----------------------- AJOUTER UN PRODUIT ----------------------------------------------------------------------------------------------------------------------------------------------------
        private void btnAjouterProduit_Click(object sender, EventArgs e)
        {
            //Renvoyer au FormCreerProduit pour ajouter un nouveau produit
            FormCreerProduit formCreerProduit = new FormCreerProduit();
            formCreerProduit.mode = "Ajouter";
            formCreerProduit.ShowDialog();
            DataTable dt = new DataTable();
            dgridCatalogue.DataSource = dt;
            get_liste_produits();
        }

        //----------------------- AJOUTER UN PRODUIT ----------------------------------------------------------------------------------------------------------------------------------------------------


        private void btnActualiserTab_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dgridCatalogue.DataSource = dt;
            get_liste_produits();
        }

        //------------- SUPPRIMER UN PRODUIT DANS LE CATALOGUE ------------------------------------------------------------------------------------------------------------------------------------------
        private void btnSupprimerProduit_Click(object sender, EventArgs e)
        {
            if (dgridCatalogue.RowCount != 0)
            {
                int index = dgridCatalogue.CurrentCell.RowIndex;//get index
                DataGridViewRow selectedRow = dgridCatalogue.Rows[index];// récupré la valure de la celle
                string idProduit = selectedRow.Cells[0].Value.ToString();
                DialogResult confirm = MessageBox.Show("Voulez-vous vraiment supprimer ce produit ?  ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (confirm == DialogResult.No)
                {
                    //Pas d'instruction
                }
                else
                {
                    MySqlConnection maCnx = new MySqlConnection("SERVER=127.0.0.1; DATABASE=ppe_chopesgames; UID=root; PASSWORD=; Convert Zero Datetime = true;");
                    string requête;
                    maCnx.Open();
                    requête = "update Produit set DISPONIBLE=@disponible where NOPRODUIT=@noproduit";
                    var maCde = new MySqlCommand(requête, maCnx);
                    maCde.Parameters.AddWithValue("@disponible", "0");
                    maCde.Parameters.AddWithValue("@noproduit", idProduit);
                    int nbLigneAffectées = maCde.ExecuteNonQuery();
                    maCnx.Close();
                    maCnx.Dispose();
                    MessageBox.Show(nbLigneAffectées.ToString() + " produit est supprimé avec succès .", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Recharger les données
                    DataTable dt = new DataTable();
                    dgridCatalogue.DataSource = dt;
                    get_liste_produits();
                }
            }
        }

        //-------------------- BARRE DE RECHERCHE DES PRODUIT PAR LIBELLE AVEC AUTOCOMPLETION -----------------------------------------------------------------------------------------------------------
        private void tbxRechercherProduit_TextChanged(object sender, EventArgs e)
        {
            if (tbxRechercherProduit.Text != "")
            {
                MySqlConnection maCnx = new MySqlConnection("SERVER=127.0.0.1; DATABASE=ppe_chopesgames; UID=root; PASSWORD=; Convert Zero Datetime = true;");
                string requête;
                maCnx.Open();
                requête = "SELECT NOPRODUIT AS 'NO', categorie.LIBELLE AS 'CATEGORIE', marque.NOM AS 'MARQUE', Produit.LIBELLE AS 'LIBELLE', DETAIL, PRIXHT, TAUXTVA AS 'TVA', NOMIMAGE, QUANTITEENSTOCK AS 'QON', CONVERT(DATEAJOUT, DATETIME) AS 'DATEAJOUT', DISPONIBLE, VITRINE FROM Produit JOIN categorie ON Produit.NOCATEGORIE = categorie.NOCATEGORIE JOIN marque ON Produit.NOMARQUE = marque.NOMARQUE WHERE Produit.LIBELLE LIKE @LIBELLE";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@LIBELLE", "%" + tbxRechercherProduit.Text + "%");
                MySqlDataReader reader = maCde.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgridCatalogue.DataSource = dataTable;
                maCnx.Close();
            }
            else
            {
                DataTable dt = new DataTable();
                dgridCatalogue.DataSource = dt;
                get_liste_produits();
            }

        }

        //---------------------- ELEMENTS DE TRI PAR CATEGORIE ET PAR MARQUE --------------------------------------------------------------------------------------------------------------------------

        public string noCategorie = "";
        public string noMarque = "";

        public string getNocategorie()
        {
            MySqlConnection maCnx = new MySqlConnection("SERVER=127.0.0.1; DATABASE=ppe_chopesgames; UID=root; PASSWORD=; Convert Zero Datetime = true;");
            maCnx.Open();
            string sql = "select * from Categorie where LIBELLE = '" + cmbTriCategorie.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                noCategorie = reader["NOCATEGORIE"].ToString();
            }
            maCnx.Close();
            maCnx.Dispose();
            return noCategorie;
        }

        public string getNoMarque()
        {
            MySqlConnection maCnx = new MySqlConnection("SERVER=127.0.0.1; DATABASE=ppe_chopesgames; UID=root; PASSWORD=; Convert Zero Datetime = true;");
            maCnx.Open();
            string sql = "select * from marque where NOM = '" + cmbTriMarque.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                noMarque = reader["NOMARQUE"].ToString();
            }
            maCnx.Close();
            maCnx.Dispose();
            return noMarque;
        }
        //---------------- TRIER PAR CATEGORIE ---------------------------------------------------------------------------------------------------------------------------------------------------------
        private void cmbTriCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            getNocategorie();
            MySqlConnection maCnx = new MySqlConnection("SERVER=127.0.0.1; DATABASE=ppe_chopesgames; UID=root; PASSWORD=; Convert Zero Datetime = true;");
            maCnx.Open();
            string sql = "SELECT NOPRODUIT AS 'NO',categorie.LIBELLE as 'CATEGORIE',marque.NOM as 'MARQUE',Produit.LIBELLE as 'LIBELLE',DETAIL,PRIXHT,TAUXTVA as 'TVA',NOMIMAGE,QUANTITEENSTOCK as 'QON',CONVERT (DATEAJOUT,DATETIME) as 'DATEAJOUT',DISPONIBLE,VITRINE FROM Produit join categorie on Produit.NOCATEGORIE  = categorie.NOCATEGORIE  join marque on Produit.NOMARQUE  = marque.NOMARQUE where categorie.NOCATEGORIE = @nocateorie ";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);
            cmd.Parameters.AddWithValue("@nocateorie", noCategorie);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dgridCatalogue.DataSource = dataTable;
            maCnx.Close();
            maCnx.Dispose();
        }

        //------------------------ TRIER PAR MARQUE ----------------------------------------------------------------------------------------------------------------------------------------------------
        private void cmbTriMarque_SelectedIndexChanged(object sender, EventArgs e)
        {
            getNoMarque();
            MySqlConnection maCnx = new MySqlConnection("SERVER=127.0.0.1; DATABASE=ppe_chopesgames; UID=root; PASSWORD=; Convert Zero Datetime = true;");
            maCnx.Open();
            string sql = "SELECT NOPRODUIT AS 'NO',categorie.LIBELLE as 'CATEGORIE',marque.NOM as 'MARQUE',Produit.LIBELLE as 'LIBELLE',DETAIL,PRIXHT,TAUXTVA as 'TVA',NOMIMAGE,QUANTITEENSTOCK as 'QON',CONVERT (DATEAJOUT,DATETIME) as 'DATEAJOUT',DISPONIBLE,VITRINE FROM Produit join categorie on Produit.NOCATEGORIE  = categorie.NOCATEGORIE  join marque on Produit.NOMARQUE  = marque.NOMARQUE where marque.NOMARQUE = @nomarque";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);
            cmd.Parameters.AddWithValue("@nomarque", noMarque);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dgridCatalogue.DataSource = dataTable;
            maCnx.Close();
            maCnx.Dispose();
        }

        


    }
}
