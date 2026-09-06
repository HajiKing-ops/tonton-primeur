using tp_tonton.Data;
using MySqlConnector;
using System.Data;
namespace tp_tonton
{
    public partial class Form1 : Form
    {
        private int idArticleSelectionne = 0;
        private int idFournisseurSelectionne = 0;

        public Form1()
        {
            InitializeComponent();
            ChargerArticle();
            ChargerFournisseurDansComboBox();
            ChargerFournisseurs();
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

        private void ChargerArticle(string order = "ASC")
        {
            try
            {
                Database database = new Database();
                using (var connexion = database.GetConnection())
                {
                    string query = $@"Select
                                a.id_article,
                                a.id_fournisseur,
                                a.nom as nom_article,
                                a.type,
                                a.prix_unitaire,
                                a.quantite_stock,
                                f.nom as nom_fournisseur
                    from article as a inner join fournisseur as f  on a.id_fournisseur = f.id_fournisseur order by a.nom {order};";
                    using (var command = new MySqlCommand(query, connexion))
                    {
                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            connexion.Open();
                            adapter.Fill(table);

                            dgvArticles.DataSource = table;
                            dgvArticles.Columns["id_fournisseur"].Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur  : " + ex.Message);
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
                    }
                }
                ChargerArticle();
                MessageBox.Show("succés");
                idArticleSelectionne = 0;
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
            if (idArticleSelectionne == 0)
            {
                MessageBox.Show("Veuillez selectionner un article a modifier");
                return;
            }
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
                    string query = @"update article set nom = @nom, type = @type, prix_unitaire = @prix , quantite_stock = @quantite, id_fournisseur = @idFournisseur where id_article = @idArticle ;";
                    using (var command = new MySqlCommand(query, connexion))
                    {
                        command.Parameters.AddWithValue("@nom", txtNomArticle.Text.Trim());
                        command.Parameters.AddWithValue("@type", cboTypeArticle.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@prix", numPrix.Value);
                        command.Parameters.AddWithValue("@quantite", Convert.ToInt32(numQuantite.Value));
                        command.Parameters.AddWithValue("@idFournisseur", Convert.ToInt32(cboFournisseur.SelectedValue));
                        command.Parameters.AddWithValue("@idArticle", idArticleSelectionne);
                        connexion.Open();
                        command.ExecuteNonQuery();
                    }
                }
                ChargerArticle();
                MessageBox.Show("Article modifié avec succés");
                idArticleSelectionne = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification de l'articles : " + ex.Message);
            }

        }



        private void dgvArticles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow ligne = dgvArticles.Rows[e.RowIndex];
            idArticleSelectionne = Convert.ToInt32(ligne.Cells["id_article"].Value);
            txtNomArticle.Text = ligne.Cells["nom_article"].Value?.ToString() ?? "";
            cboTypeArticle.SelectedItem = ligne.Cells["type"].Value?.ToString();
            numPrix.Value = Convert.ToDecimal(ligne.Cells["prix_unitaire"].Value);
            numQuantite.Value = Convert.ToDecimal(ligne.Cells["quantite_stock"].Value);
            cboFournisseur.SelectedValue = ligne.Cells["id_fournisseur"].Value;
        }


        private void btnSupprimerArticle_Click(object sender, EventArgs e)
        {
            if (idArticleSelectionne == 0)
            {
                MessageBox.Show("Veuillez selectionner un article a modifier");
                return;
            }
            DialogResult confirmation = MessageBox.Show(
                        "Voulez-vous vraiment supprimer cet article ?",
                        "Confirmation de suppression",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
            if (confirmation != DialogResult.Yes)
            {
                return;
            }


            try
            {
                Database database = new Database();
                using (var connexion = database.GetConnection())
                {
                    string query = @"delete from article where id_article = @idArticle;";
                    using (var command = new MySqlCommand(query, connexion))
                    {
                        command.Parameters.AddWithValue("@idArticle", idArticleSelectionne);
                        connexion.Open();
                        command.ExecuteNonQuery();
                    }
                }
                ChargerArticle();
                MessageBox.Show("l'article est supprime");
                idArticleSelectionne = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la supprime de l'articles : " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChargerArticle("ASC");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChargerArticle("DESC");
        }

        private void dgvFournisseurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ChargerFournisseurs()
        {
            try
            {
                Database database = new Database();
                using (var connexion = database.GetConnection())
                {
                    string query = @"Select id_fournisseur,nom , telephone , email, adresse from fournisseur;";
                    using (var command = new MySqlCommand(query, connexion))
                    {
                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            connexion.Open();
                            adapter.Fill(table);
                            dgvFournisseurs.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des fournisseurs : " + ex.Message);
            }
        }

        private void btnAjouterFournisseur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomFournisseur.Text))
            {
                MessageBox.Show("Veuillez saisir le nom fournisseur");
                return;
            }
            try
            {
                Database database = new Database();
                using (var connexion = database.GetConnection())
                {
                    string query = @"insert into fournisseur (nom, telephone, email, adresse) values (@nom, @telephone, @email, @adresse);";
                    using (var command = new MySqlCommand(query, connexion))
                    {
                        command.Parameters.AddWithValue("@nom", txtNomFournisseur.Text.Trim());
                        command.Parameters.AddWithValue("@telephone", txtTelephoneFournisseur.Text.Trim());
                        command.Parameters.AddWithValue("@email", txtEmailFournisseur.Text.Trim());
                        command.Parameters.AddWithValue("@adresse", txtAdresseFournisseur.Text.Trim());
                        connexion.Open();
                        command.ExecuteNonQuery();
                    }
                }
                ChargerFournisseurs();
                ChargerFournisseurDansComboBox();
                MessageBox.Show("Fournisseur ajouté avec succés");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout du fournisseur  " + ex.Message);
            }
        }

        private void dgvFournisseurs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow ligne = dgvFournisseurs.Rows[e.RowIndex];
            idFournisseurSelectionne = Convert.ToInt32(ligne.Cells["id_fournisseur"].Value);
            txtNomArticle.Text = ligne.Cells["nom"].Value?.ToString() ?? "";
            txtEmailFournisseur.Text = ligne.Cells["email"].Value?.ToString() ?? "";
            txtTelephoneFournisseur.Text = ligne.Cells["telephone"].Value?.ToString() ?? "";
            txtNomFournisseur.Text = ligne.Cells["nom"].Value?.ToString() ?? "";
            txtAdresseFournisseur.Text = ligne.Cells["adresse"].Value?.ToString() ?? "";
        }



        private void btnModifierFournisseur_Click(object sender, EventArgs e)
        {



            if (idFournisseurSelectionne == 0)
            {
                MessageBox.Show("Veuillez selectionner un fournisseur a modifier");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNomFournisseur.Text))
            {
                MessageBox.Show("Veuillez saisir le nom du fournisseur");
                return;
            }

            try
            {
                Database database = new Database();
                using (var connexion = database.GetConnection())
                {
                    string query = @"update fournisseur set nom = @nom, email = @email, telephone = @telephone , adresse = @adresse where  id_fournisseur = @idFournisseur ;";
                    using (var command = new MySqlCommand(query, connexion))
                    {
                        command.Parameters.AddWithValue("@nom", txtNomFournisseur.Text.Trim());
                        command.Parameters.AddWithValue("@email", txtEmailFournisseur.Text.Trim());
                        command.Parameters.AddWithValue("@telephone", txtTelephoneFournisseur.Text.Trim());
                        command.Parameters.AddWithValue("@adresse", txtAdresseFournisseur.Text.Trim());
                        command.Parameters.AddWithValue("@idFournisseur", idFournisseurSelectionne);
                        connexion.Open();
                        command.ExecuteNonQuery();
                    }
                }
                ChargerFournisseurs();
                ChargerFournisseurDansComboBox();
                MessageBox.Show("Fournissuer modifié avec succés");
                idFournisseurSelectionne = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification de Fournisseur : " + ex.Message);
            }

        }

        private void btnAjouterFournisseur_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnSupprimerFournisseur_Click(object sender, EventArgs e)
        {
            if (idFournisseurSelectionne == 0)
            {
                MessageBox.Show("Veuillez selectionner un fournisseur a modifier");
                return;
            }
            DialogResult confirmation = MessageBox.Show(
                        "Voulez-vous vraiment supprimer cet fournisseur ?",
                        "Confirmation de suppression",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
            if (confirmation != DialogResult.Yes)
            {
                return;
            }


            try
            {
                Database database = new Database();
                using (var connexion = database.GetConnection())
                {
                    string query = @"delete from fournisseur where id_fournisseur = @idfournisseur;";
                    using (var command = new MySqlCommand(query, connexion))
                    {
                        command.Parameters.AddWithValue("@idfournisseur ", idFournisseurSelectionne);
                        connexion.Open();
                        command.ExecuteNonQuery();
                    }
                }
                ChargerFournisseurs();
                ChargerFournisseurDansComboBox();
                MessageBox.Show("Fournisseur est supprime");
                idFournisseurSelectionne = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la supprime du fournisseur : " + ex.Message);
            }
        }
    }
}
