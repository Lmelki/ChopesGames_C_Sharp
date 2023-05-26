using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChopesGames
{
    public partial class FormModifierProduit : Form
    {
        private MySqlConnection maCnx;
        private Regex regexPrixHTTauxTVA = new Regex(@"^-?(?:\d+|\d{1,3}(?:,\d{3})+)(?:(\.|,)\d+)?$");
        private bool prixHTEstValide, tauxTVAEstValide; // controle
        public FormModifierProduit()
        {
            InitializeComponent();
            maCnx = new MySqlConnection("SERVER=127.0.0.1; DATABASE=ppe_chopesgames; UID=root; PASSWORD=; Convert Zero Datetime = true;");

        }

        private void FormModifierProduit_Load(object sender, EventArgs e)
        {
            // Chargement des catégories dans cmbCategorie
            try
            {
                string requête;
                int noCategorie;
                string libelle;
                MySqlDataReader jeuEnr = null;
                maCnx.Open(); // on se connecte
                requête = "Select * from Categorie";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    noCategorie = jeuEnr.GetInt32("NOCATEGORIE");
                    libelle = jeuEnr.GetString("LIBELLE");
                    cmbCategorie.Items.Add(new Categorie(noCategorie, libelle));
                }
            }
            catch (MySqlException erreur)
            {
                MessageBox.Show("Erreur chargement catégories : " + erreur.ToString());
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }

            // Chargement des marques dans cmbMarque
            try
            {
                string requête;
                int noMarque;
                string nom;
                MySqlDataReader jeuEnr = null;
                maCnx.Open(); // on se connecte
                requête = "Select * from Marque";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    noMarque = jeuEnr.GetInt32("NOMARQUE");
                    nom = jeuEnr.GetString("NOM");
                    cmbMarque.Items.Add(new Marque(noMarque, nom));
                }
            }
            catch (MySqlException erreur)
            {
                MessageBox.Show("Erreur chargement marques : " + erreur.ToString());
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }
            try
            {
                string requête;
                int noProduit, noCategorie, noMarque, quantiteEnStock, vitrine, disponibilite;
                string libelle, detail, nomImage;
                double prixHT, tauxTVA;
                DateTime dateAjout;
                MySqlDataReader jeuEnr = null;
                maCnx.Open(); // on se connecte
                requête = "Select * from Produit";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    noProduit = jeuEnr.GetInt32("NOPRODUIT");
                    noCategorie = jeuEnr.GetInt32("NOCATEGORIE");
                    noMarque = jeuEnr.GetInt32("NOMARQUE");
                    quantiteEnStock = jeuEnr.GetInt32("QUANTITEENSTOCK");
                    libelle = jeuEnr.GetString("LIBELLE");
                    detail = jeuEnr.GetString("DETAIL");
                    nomImage = jeuEnr.GetString("NOMIMAGE");
                    prixHT = jeuEnr.GetDouble("PRIXHT");
                    tauxTVA = jeuEnr.GetDouble("TAUXTVA");
                    disponibilite = jeuEnr.GetInt32("DISPONIBLE");
                    vitrine = jeuEnr.GetInt32("VITRINE");
                    dateAjout = jeuEnr.GetDateTime("DATEAJOUT").Date;
                    cmbProduits.Items.Add(new Produit(noProduit, noCategorie, noMarque, quantiteEnStock, libelle, detail, nomImage, prixHT, tauxTVA, disponibilite, vitrine, dateAjout));
                }
            }
            catch (MySqlException erreur)
            {
                MessageBox.Show("Erreur chargement produits : " + erreur.ToString());
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }
        }

        private void cmbProduits_SelectedIndexChanged(object sender, EventArgs e)
        {
            int noProduit = ((Produit)(cmbProduits.SelectedItem)).GetNoProduit();
            int noCategorie = ((Produit)(cmbProduits.SelectedItem)).GetNoCategorie();
            int noMarque = ((Produit)(cmbProduits.SelectedItem)).GetNoMarque();
            foreach (Categorie categorie in cmbCategorie.Items)
            {
                if (categorie.GetNoCategorie() == noCategorie)
                {
                    cmbCategorie.SelectedItem = categorie;
                }
            }
            foreach (Marque marque in cmbMarque.Items)
            {
                if (marque.GetNoMarque() == noMarque)
                {
                    cmbMarque.SelectedItem = marque;
                }
            }

            foreach (Produit produit in cmbProduits.Items)
            {
                if (produit.GetNoProduit() == noProduit)
                {
                    tbxLibelle.Text = ((Produit)(cmbProduits.SelectedItem)).GetLibelle();
                    tbxDetail.Text = ((Produit)(cmbProduits.SelectedItem)).GetDetail();
                    tbxPrixHT.Text = ((Produit)(cmbProduits.SelectedItem)).GetPrixHT().ToString();
                    tbxTauxTVA.Text = ((Produit)(cmbProduits.SelectedItem)).GetTauxTVA().ToString();
                    tbxNomImage.Text = ((Produit)(cmbProduits.SelectedItem)).GetNomImage();
                    tbxQteStock.Text = ((Produit)(cmbProduits.SelectedItem)).GetQuantite().ToString();
                    dateAjout.Text = ((Produit)(cmbProduits.SelectedItem)).GetDateAJout().ToString();

                    if (((Produit)(cmbProduits.SelectedItem)).GetDisponibilite()==1)
                    {
                        radBtnDispoOui.Checked = true;
                        radBtnDispoNon.Checked = false;
                    }
                    else
                    {
                        radBtnDispoOui.Checked = true;
                        radBtnDispoNon.Checked = false;
                    }
                    if (((Produit)(cmbProduits.SelectedItem)).GetVitrine() == 1)
                    {
                        radBtnVitNon.Checked = false;
                        radBtnVitOui.Checked = true;
                    }
                    else
                    {
                        radBtnVitNon.Checked = true;
                        radBtnVitOui.Checked = false;
                    }
                }
            }
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            string requête;
            int idProduit = ((Produit)(cmbProduits.SelectedItem)).GetNoProduit();
            maCnx.Open(); // on se connecte
            requête = "update Produit set NOCATEGORIE=@noCategorie,NOMARQUE=@noMarque,LIBELLE=@libelle,DETAIL=@detail,PRIXHT=@prixHT,TAUXTVA=@tauxTVA,NOMIMAGE=@nomimage,QUANTITEENSTOCK=@quantiteenstock,DATEAJOUT=@dateajout,DISPONIBLE=@disponible,VITRINE=@vitrine where NOPRODUIT=@noproduit";
            var maCde = new MySqlCommand(requête, maCnx);
            int noCategorie = ((Categorie)(cmbCategorie.SelectedItem)).GetNoCategorie();
            int noMarque = ((Marque)(cmbMarque.SelectedItem)).GetNoMarque();
            maCde.Parameters.AddWithValue("@noCategorie", noCategorie);
            maCde.Parameters.AddWithValue("@noMarque", noMarque);
            maCde.Parameters.AddWithValue("@libelle", tbxLibelle.Text);
            maCde.Parameters.AddWithValue("@detail", tbxDetail.Text);
            maCde.Parameters.AddWithValue("@prixHT", tbxPrixHT.Text);
            maCde.Parameters.AddWithValue("@tauxTVA", tbxTauxTVA.Text);
            maCde.Parameters.AddWithValue("@nomimage", tbxNomImage.Text);
            maCde.Parameters.AddWithValue("@quantiteenstock", tbxQteStock);
            maCde.Parameters.AddWithValue("@dateajout", dateAjout.Text);
            if (radBtnDispoOui.Checked == true)
            {
                maCde.Parameters.AddWithValue("@disponible", "1");
            }
            else
            {
                maCde.Parameters.AddWithValue("@disponible", "0");
            }

            if (radBtnVitOui.Checked == true)
            {
                maCde.Parameters.AddWithValue("@vitrine", "1");
            }
            else
            {
                maCde.Parameters.AddWithValue("@vitrine", "0");
            }
            maCde.Parameters.AddWithValue("@noproduit", idProduit);
            int nbLigneAffectées = maCde.ExecuteNonQuery();
            maCnx.Close();
            maCnx.Dispose();
            MessageBox.Show(nbLigneAffectées.ToString() + " produit modifié.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

