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
        public void get_liste_produits()
        {
            try
            {
                MySqlConnection maCnx;
                maCnx = new MySqlConnection("SERVER=127.0.0.1; DATABASE=ppe_chopesgames; UID=root; PASSWORD=;Convert Zero Datetime = true;");
                maCnx.Open();
                string sql = "SELECT NOPRODUIT AS 'NO',categorie.LIBELLE as 'CATEGORIE',marque.NOM as 'MARQUE',Produit.LIBELLE as 'LIBELLE',DETAIL,PRIXHT,TAUXTVA as 'TVA',NOMIMAGE,QUANTITEENSTOCK as 'QON',CONVERT (DATEAJOUT,DATETIME) as 'DATEAJOUT',DISPONIBLE,VITRINE FROM Produit join categorie on Produit.NOCATEGORIE  = categorie.NOCATEGORIE  join marque on Produit.NOMARQUE  = marque.NOMARQUE ";
                MySqlCommand cmd = new MySqlCommand(sql, maCnx);
                dgridCatalogue.Rows.Clear();
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgridCatalogue.DataSource = dataTable;
                maCnx.Close();
                maCnx.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void dgridCatalogue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormCatalogueProduits_Load(object sender, EventArgs e)
        {
            get_liste_produits();
        }

        //public string getNoCategorie(string libelleCategorie)
        //{
        //    MySqlConnection maCnx;
        //    maCnx = new MySqlConnection("SERVER=127.0.0.1; DATABASE=ppe_chopesgames; UID=root; PASSWORD=;Convert Zero Datetime = true;");
        //    string requête;
        //    int noCategorie;
        //    string libelle;
        //    string mycategorie = "";
        //    MySqlDataReader jeuEnr = null;
        //    maCnx.Open(); // on se connecte
        //    requête = "Select * from Categorie where LIBELLE = '"+ libelleCategorie + "'";
        //    var maCde = new MySqlCommand(requête, maCnx);
        //    jeuEnr = maCde.ExecuteReader();

        //    while (jeuEnr.Read())
        //    {
        //        noCategorie = jeuEnr.GetInt32("NOCATEGORIE");
        //        libelle = jeuEnr.GetString("LIBELLE");
        //        mycategorie = noCategorie.ToString()+"-"+ libelle;
        //    }
        //    maCnx.Close();
        //    return mycategorie;
           
        //}
        private void btnModifierProduit_Click(object sender, EventArgs e)
        {
            if (dgridCatalogue.RowCount != 0) 
            {
                int index = dgridCatalogue.CurrentCell.RowIndex;
                if (index >= 0) 
                {
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

                    formModifier.Text = "Modifier Produit";
                    formModifier.btnCreer.Text = "Modifier";
                    formModifier.mode = "Modifier";
                    formModifier.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Il n'y a aucun produit dans le catalogue");
            }
        }

        private void btnAjouterProduit_Click(object sender, EventArgs e)
        {
            FormCreerProduit formCreerProduit = new FormCreerProduit();
            formCreerProduit.mode = "Ajouter";
            formCreerProduit.ShowDialog();
        }
    }
}
