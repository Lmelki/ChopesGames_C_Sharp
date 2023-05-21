using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ChopesGames
{
    public partial class FormCreerProduit : Form
    {
        private MySqlConnection maCnx; 
        private Regex regexPrixHTTauxTVA = new Regex(@"^-?(?:\d+|\d{1,3}(?:,\d{3})+)(?:(\.|,)\d+)?$");
        private bool prixHTEstValide, tauxTVAEstValide; // controle
        public string idProduit = "";
        public string mode = "";

        public FormCreerProduit()
        {
            InitializeComponent();
            maCnx = new MySqlConnection("SERVER=127.0.0.1; DATABASE=ppe_chopesgames; UID=root; PASSWORD=; Convert Zero Datetime = true;");
        }
        
        private void FormCreerProduit_Load(object sender, EventArgs e)
        {
            maCnx.Close();
            // Chargement des catégories dans cmbCategorie
            try
            {
                maCnx.Open();
                string requete = "Select * from Categorie";
                MySqlCommand cmd = new MySqlCommand(requete, maCnx);
                MySqlDataReader red = cmd.ExecuteReader();
                cmbCategorie.Items.Clear();
                while (red.Read())
                {
                    cmbCategorie.Items.Add(red["LIBELLE"]);
                }
                if (cmbCategorie.Items.Count != 0)
                {
                    cmbCategorie.SelectedIndex = 0;
                }
                maCnx.Close();
                maCnx.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            // Chargement des marques dans cmbMarque

            try
            {
                //maCnx.Open();
                string requete = "Select * from Marque";
                MySqlCommand cmd = new MySqlCommand(requete, maCnx);
                MySqlDataReader red = cmd.ExecuteReader();
                cmbMarque.Items.Clear();
                while (red.Read())
                {
                    cmbMarque.Items.Add(red["NOM"]);
                }
                if (cmbMarque.Items.Count != 0)
                {
                    cmbMarque.SelectedIndex = 0;
                }
                maCnx.Close();
                maCnx.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            // Chargement des catégories dans cmbCategorie
            //try
            //{
            //    string requête;
            //    int noCategorie;
            //    string libelle;
            //    MySqlDataReader jeuEnr = null;
            //    maCnx.Open(); // on se connecte
            //    requête = "Select * from Categorie";
            //    var maCde = new MySqlCommand(requête, maCnx);
            //    jeuEnr = maCde.ExecuteReader();

            //    while (jeuEnr.Read())
            //    {
            //        noCategorie = jeuEnr.GetInt32("NOCATEGORIE");
            //        libelle = jeuEnr.GetString("LIBELLE");
            //        cmbCategorie.Items.Add(new Categorie(noCategorie, libelle));
            //    }
            //}
            //catch (MySqlException erreur)
            //{
            //    MessageBox.Show("Erreur chargement catégories : " + erreur.ToString());
            //}
            //finally
            //{
            //    if (maCnx is object & maCnx.State == ConnectionState.Open)
            //    {
            //        maCnx.Close(); // on se déconnecte
            //    }
            //}

            //// Chargement des marques dans cmbMarque
            //try
            //{
            //    string requête;
            //    int noMarque;
            //    string nom;
            //    MySqlDataReader jeuEnr = null;
            //    maCnx.Open(); // on se connecte
            //    requête = "Select * from Marque";
            //    var maCde = new MySqlCommand(requête, maCnx);
            //    jeuEnr = maCde.ExecuteReader();

            //    while (jeuEnr.Read())
            //    {
            //        noMarque = jeuEnr.GetInt32("NOMARQUE");
            //        nom = jeuEnr.GetString("NOM");
            //        cmbMarque.Items.Add(new Marque(noMarque, nom));
            //    }
            //}
            //catch (MySqlException erreur)
            //{
            //    MessageBox.Show("Erreur chargement marques : " + erreur.ToString());
            //}
            //finally
            //{
            //    if (maCnx is object & maCnx.State == ConnectionState.Open)
            //    {
            //        maCnx.Close(); // on se déconnecte
            //    }
            //}

        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            if (mode == "Ajouter")
            { 
                if (cmbCategorie.SelectedItem is object && cmbMarque.SelectedItem is object &&
                    prixHTEstValide && tauxTVAEstValide)
                {
                    try
                    {
                        string requête;
                        maCnx.Open(); // on se connecte
                        requête = "Insert into Produit(NOCATEGORIE,NOMARQUE,LIBELLE,DETAIL,PRIXHT,TAUXTVA,NOMIMAGE,QUANTITEENSTOCK,DATEAJOUT,DISPONIBLE,VITRINE) " +
                            "values (@noCategorie,@noMarque,@libelle,@detail,@prixHT,@tauxTVA, @nomimage, @quantiteenstock, @dateajout, @disponible, @vitrine)";
                        var maCde = new MySqlCommand(requête, maCnx);
                        //maCde.Prepare();

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

                        int nbLigneAffectées = maCde.ExecuteNonQuery();
                        MessageBox.Show(nbLigneAffectées.ToString() + " produit(s) créé(s).", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // ci-après on remet les zones de saisie à vide (pas les combo.)
                        tbxDetail.Clear();
                        tbxLibelle.Clear();
                        tbxPrixHT.Clear();
                        tbxTauxTVA.Clear();
                        cmbCategorie.Focus(); // on remet le focus sur la combo catégorie
                    }
                    catch (MySqlException erreur)
                    {
                        MessageBox.Show("Erreur lors de l'ajout : " + erreur.ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (maCnx is object & maCnx.State == ConnectionState.Open)
                        {
                            maCnx.Close(); // on se déconnecte
                        }
                    } // try
                }
                else
                {
                    MessageBox.Show("Saisie incomplète ou incorrecte.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
            //    if (mode == "Modifier")
            //    {
            //        if (cmbCategorie.SelectedItem is object && cmbMarque.SelectedItem is object &&
            //            prixHTEstValide && tauxTVAEstValide)
            //        {
            //            try
            //            {
            //            }catch { }
            //        }
            //    }
            //                string requête;
            //    maCnx.Open(); // on se connecte
            //    requête = "update Produit set NOCATEGORIE=@noCategorie,NOMARQUE=@noMarque,LIBELLE=@libelle,DETAIL=@detail,PRIXHT=@prixHT," +
            //        "TAUXTVA=@tauxTVA,NOMIMAGE=@nomimage,QUANTITEENSTOCK=@quantiteenstock,DATEAJOUT=@dateajout,DISPONIBLE=@disponible,VITRINE=@vitrine " +
            //        "where NOPRODUIT=@noproduit";
            //    var maCde = new MySqlCommand(requête, maCnx);
            //    //maCde.Prepare();

            //    int noCategorie = ((Categorie)(cmbCategorie.SelectedItem)).GetNoCategorie();
            //    int noMarque = ((Marque)(cmbMarque.SelectedItem)).GetNoMarque();
            //    maCde.Parameters.AddWithValue("@noCategorie", noCategorie);
            //    maCde.Parameters.AddWithValue("@noMarque", noMarque);
            //    maCde.Parameters.AddWithValue("@libelle", tbxLibelle.Text);
            //    maCde.Parameters.AddWithValue("@detail", tbxDetail.Text);
            //    maCde.Parameters.AddWithValue("@prixHT", tbxPrixHT.Text);
            //    maCde.Parameters.AddWithValue("@tauxTVA", tbxTauxTVA.Text);
            //    maCde.Parameters.AddWithValue("@nomimage", tbxNomImage.Text);
            //    maCde.Parameters.AddWithValue("@quantiteenstock", tbxQteStock);
            //    maCde.Parameters.AddWithValue("@dateajout", dateAjout.Text);
            //    if (radBtnDispoOui.Checked == true)
            //    {
            //        maCde.Parameters.AddWithValue("@disponible", "1");
            //    }
            //    else
            //    {
            //        maCde.Parameters.AddWithValue("@disponible", "0");
            //    }

            //    if (radBtnVitOui.Checked == true)
            //    {
            //        maCde.Parameters.AddWithValue("@vitrine", "1");
            //    }
            //    else
            //    {
            //        maCde.Parameters.AddWithValue("@vitrine", "0");
            //    }

            //    int nbLigneAffectées = maCde.ExecuteNonQuery();
            //    MessageBox.Show(nbLigneAffectées.ToString() + " produit modifié.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        } // méthode

        // --------------------
        /* Contrôles de saisie - Nota bene : pas de contrôle sur détail et libellé */
        // --------------------
        private void tbxPrixHT_Leave(object sender, EventArgs e)
        {
            if (regexPrixHTTauxTVA.Match(tbxPrixHT.Text).Success & tbxPrixHT.Text != "")
            {
                prixHTEstValide = true;
                tbxPrixHT.BackColor = SystemColors.Window;
            }
            else
            {
                tbxPrixHT.BackColor = Color.Red;
                prixHTEstValide = false;
            }
        }

        public string noCat = "";

        public string getNocat(string libelle)
        {
            maCnx.Open();
            string sql = "select * from Categorie where LIBELLE = '" + libelle + "'";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                noCat = reader["NOCATEGORIE"].ToString();
            }
            maCnx.Close();
            maCnx.Dispose();
            return noCat;
        }
        private void cmbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            string noCategorie = getNocat(cmbCategorie.Text);
            MessageBox.Show(noCategorie);
        }

        private void tbxTauxTVA_Leave(object sender, EventArgs e)
        {
            if (regexPrixHTTauxTVA.Match(tbxTauxTVA.Text).Success & tbxTauxTVA.Text != "")
            {
                tauxTVAEstValide = true;
                tbxTauxTVA.BackColor = SystemColors.Window;
            }
            else
            {
                tbxTauxTVA.BackColor = Color.Red;
                tauxTVAEstValide = false;
            }
        }
    }
}
