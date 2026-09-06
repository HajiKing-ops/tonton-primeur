using tp_tonton.Data;
using MySqlConnector;
using System.Data;
namespace tp_tonton
{
    public partial class Form1 : Form
    {
        private int idAritcleSelectionne = 0;
        public Form1()
        {
            InitializeComponent();
            ChargerArticle();
            ChargerFournisseurDansComboBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void TesterConnexion()
        {
            try
            {
                Database database = new Database();

                using (var connexion = database.GetConnection())
                {
                    connexion.Open();
                    MessageBox.Show("Connexion ressie");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed" + ex.Message);
            }

        }

        private void ChargerArticle()
        {
            try
            {
                Database database = new Database();
                using (var connexion = database.GetConnection())
                {
                    string query = @"Select
                                a.id_article,
                                a.id_fournisseur,
                                a.nom as nom_article,
                                a.type,
                                a.prix_unitaire,
                                a.quantite_stock,
                                f.nom as nom_fournisseur
                    from article as a inner join fournisseur as f  on a.id_fournisseur = f.id_fournisseur;";
                    using (var command = new MySqlCommand(query, connexion))
                    {
                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            connexion.Open();
                            adapter.Fill(table);

                            dgvArticles.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des articles : " + ex.Message);
            }
        }

        private void ChargerFournisseurDansComboBox()
        {
            try
            {
                Database database = new Database();

                using (var connexion = database.GetConnection())
                {
                    string query = @" Select id_fournisseur, nom  from fournisseur order by nom;";
                    using (var command = new MySqlCommand(query, connexion))
                    {
                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            connexion.Open();
                            adapter.Fill(table);
                            cboFournisseur.DataSource = table;
                            cboFournisseur.DisplayMember = "nom";
                            cboFournisseur.ValueMember = "id_fournisseur";

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des articles : " + ex.Message);
            }
        }

        private void btnAjouterArticle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomArticle.Text))
            {
                MessageBox.Show("Veuillez saisir le nom de l'article");
                return;
            }
            if (cboTypeArticle.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez selectionner un Type");
                return;
            }
            if (numPrix.Value <= 0)
            {
                MessageBox.Show("Veuillez saisir le prix");
                return;
            }
            if (cboFournisseur.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez selectionner un fournisseur");
                return;
            }

            try
            {
                Database database = new Database();
                using (var connexion = database.GetConnection())
                {
                    string query = @"insert into article (nom, type, prix_unitaire, quantite_stock, id_fournisseur) values (@nom, @type, @prix, @quantite, @fournisseur);";
                    using (var command = new MySqlCommand(query, connexion))
                    {
                        command.Parameters.AddWithValue("@nom", txtNomArticle.Text.Trim());
                        command.Parameters.AddWithValue("@type", cboTypeArticle.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@prix", numPrix.Value);
                        command.Parameters.AddWithValue("@quantite", Convert.ToInt32(numQuantite.Value));
                        command.Parameters.AddWithValue("@fournisseur", Convert.ToInt32(cboFournisseur.SelectedValue));
                        connexion.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("done");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des articles : " + ex.Message);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnModifierArticle_Click(object sender, EventArgs e)
        {

        }



        private void dgvArticles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow ligne = dgvArticles.Rows[e.RowIndex];
            idAritcleSelectionne = Convert.ToInt32(ligne.Cells["id_article"].Value);
            txtNomArticle.Text = ligne.Cells["nom_article"].Value?.ToString() ?? "";
            cboTypeArticle.SelectedItem = ligne.Cells["type"].Value?.ToString();
            numPrix.Value = Convert.ToDecimal(ligne.Cells["prix_unitaire"].Value);
            numQuantite.Value = Convert.ToDecimal(ligne.Cells["quantite_stock"].Value);
            cboFournisseur.SelectedValue = ligne.Cells["id_fournisseur"].Value;
        }
    }
}
