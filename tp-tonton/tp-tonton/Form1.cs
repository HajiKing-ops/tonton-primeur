using tp_tonton.Data;
using MySqlConnector;
using tp_tonton.Data;
using System.Data;
namespace tp_tonton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ChargerArticle();
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

    }
}
