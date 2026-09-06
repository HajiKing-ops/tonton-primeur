namespace tp_tonton
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            button1 = new Button();
            btnSupprimerArticle = new Button();
            btnModifierArticle = new Button();
            btnAjouterArticle = new Button();
            cboFournisseur = new ComboBox();
            label4 = new Label();
            numQuantite = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            numPrix = new NumericUpDown();
            cboTypeArticle = new ComboBox();
            Type = new Label();
            txtNomArticle = new TextBox();
            label1 = new Label();
            dgvArticles = new DataGridView();
            tabPage2 = new TabPage();
            button4 = new Button();
            button3 = new Button();
            txtAdresseFournisseur = new TextBox();
            txtEmailFournisseur = new TextBox();
            txtTelephoneFournisseur = new TextBox();
            txtNomFournisseur = new TextBox();
            btnModifierFournisseur = new Button();
            btnSupprimerFournisseur = new Button();
            btnAjouterFournisseur = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dgvFournisseurs = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvArticles).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFournisseurs).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(853, 486);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(btnSupprimerArticle);
            tabPage1.Controls.Add(btnModifierArticle);
            tabPage1.Controls.Add(btnAjouterArticle);
            tabPage1.Controls.Add(cboFournisseur);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(numQuantite);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(numPrix);
            tabPage1.Controls.Add(cboTypeArticle);
            tabPage1.Controls.Add(Type);
            tabPage1.Controls.Add(txtNomArticle);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dgvArticles);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(845, 453);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Articles";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(108, 6);
            button2.Name = "button2";
            button2.Size = new Size(99, 29);
            button2.TabIndex = 15;
            button2.Text = "Trier Z -> A";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(3, 6);
            button1.Name = "button1";
            button1.Size = new Size(99, 29);
            button1.TabIndex = 14;
            button1.Text = "Trier A -> Z";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnSupprimerArticle
            // 
            btnSupprimerArticle.Location = new Point(306, 380);
            btnSupprimerArticle.Name = "btnSupprimerArticle";
            btnSupprimerArticle.Size = new Size(94, 29);
            btnSupprimerArticle.TabIndex = 13;
            btnSupprimerArticle.Text = "Supprimer";
            btnSupprimerArticle.UseVisualStyleBackColor = true;
            btnSupprimerArticle.Click += btnSupprimerArticle_Click;
            // 
            // btnModifierArticle
            // 
            btnModifierArticle.Location = new Point(306, 329);
            btnModifierArticle.Name = "btnModifierArticle";
            btnModifierArticle.Size = new Size(94, 27);
            btnModifierArticle.TabIndex = 12;
            btnModifierArticle.Text = "Modifier";
            btnModifierArticle.UseVisualStyleBackColor = true;
            btnModifierArticle.Click += btnModifierArticle_Click;
            // 
            // btnAjouterArticle
            // 
            btnAjouterArticle.Location = new Point(306, 278);
            btnAjouterArticle.Name = "btnAjouterArticle";
            btnAjouterArticle.Size = new Size(94, 29);
            btnAjouterArticle.TabIndex = 11;
            btnAjouterArticle.Text = "Ajouter";
            btnAjouterArticle.UseVisualStyleBackColor = true;
            btnAjouterArticle.Click += btnAjouterArticle_Click;
            // 
            // cboFournisseur
            // 
            cboFournisseur.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFournisseur.FormattingEnabled = true;
            cboFournisseur.Location = new Point(137, 397);
            cboFournisseur.Name = "cboFournisseur";
            cboFournisseur.Size = new Size(151, 28);
            cboFournisseur.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 400);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 9;
            label4.Text = "Fournisseur";
            // 
            // numQuantite
            // 
            numQuantite.Location = new Point(138, 363);
            numQuantite.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numQuantite.Name = "numQuantite";
            numQuantite.Size = new Size(150, 27);
            numQuantite.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 365);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 7;
            label3.Text = "Quantité en stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 336);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 6;
            label2.Text = "Prix unitaire ($)";
            // 
            // numPrix
            // 
            numPrix.DecimalPlaces = 2;
            numPrix.Increment = new decimal(new int[] { 10, 0, 0, 131072 });
            numPrix.Location = new Point(138, 330);
            numPrix.Maximum = new decimal(new int[] { 999999, 0, 0, 131072 });
            numPrix.Name = "numPrix";
            numPrix.Size = new Size(150, 27);
            numPrix.TabIndex = 5;
            numPrix.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // cboTypeArticle
            // 
            cboTypeArticle.FormattingEnabled = true;
            cboTypeArticle.Items.AddRange(new object[] { "Fruit", "Légume" });
            cboTypeArticle.Location = new Point(136, 296);
            cboTypeArticle.Name = "cboTypeArticle";
            cboTypeArticle.Size = new Size(151, 28);
            cboTypeArticle.TabIndex = 4;
            // 
            // Type
            // 
            Type.AutoSize = true;
            Type.Location = new Point(-1, 302);
            Type.Name = "Type";
            Type.Size = new Size(40, 20);
            Type.TabIndex = 3;
            Type.Text = "Type";
            // 
            // txtNomArticle
            // 
            txtNomArticle.Location = new Point(136, 263);
            txtNomArticle.Name = "txtNomArticle";
            txtNomArticle.Size = new Size(151, 27);
            txtNomArticle.TabIndex = 2;
            txtNomArticle.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-1, 268);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 1;
            label1.Text = "Nom de l'article";
            label1.Click += label1_Click;
            // 
            // dgvArticles
            // 
            dgvArticles.AllowUserToAddRows = false;
            dgvArticles.AllowUserToDeleteRows = false;
            dgvArticles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticles.Location = new Point(3, 41);
            dgvArticles.MultiSelect = false;
            dgvArticles.Name = "dgvArticles";
            dgvArticles.ReadOnly = true;
            dgvArticles.RowHeadersWidth = 51;
            dgvArticles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArticles.Size = new Size(839, 204);
            dgvArticles.TabIndex = 0;
            dgvArticles.CellClick += dgvArticles_CellClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(txtAdresseFournisseur);
            tabPage2.Controls.Add(txtEmailFournisseur);
            tabPage2.Controls.Add(txtTelephoneFournisseur);
            tabPage2.Controls.Add(txtNomFournisseur);
            tabPage2.Controls.Add(btnModifierFournisseur);
            tabPage2.Controls.Add(btnSupprimerFournisseur);
            tabPage2.Controls.Add(btnAjouterFournisseur);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(dgvFournisseurs);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(845, 453);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Fournisseurs";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(113, 0);
            button4.Name = "button4";
            button4.Size = new Size(99, 29);
            button4.TabIndex = 16;
            button4.Text = "Trier Z -> A";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(8, 0);
            button3.Name = "button3";
            button3.Size = new Size(99, 29);
            button3.TabIndex = 15;
            button3.Text = "Trier A -> Z";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtAdresseFournisseur
            // 
            txtAdresseFournisseur.Location = new Point(108, 383);
            txtAdresseFournisseur.Name = "txtAdresseFournisseur";
            txtAdresseFournisseur.Size = new Size(249, 27);
            txtAdresseFournisseur.TabIndex = 11;
            // 
            // txtEmailFournisseur
            // 
            txtEmailFournisseur.Location = new Point(108, 346);
            txtEmailFournisseur.Name = "txtEmailFournisseur";
            txtEmailFournisseur.Size = new Size(249, 27);
            txtEmailFournisseur.TabIndex = 10;
            // 
            // txtTelephoneFournisseur
            // 
            txtTelephoneFournisseur.Location = new Point(108, 308);
            txtTelephoneFournisseur.Name = "txtTelephoneFournisseur";
            txtTelephoneFournisseur.Size = new Size(249, 27);
            txtTelephoneFournisseur.TabIndex = 9;
            // 
            // txtNomFournisseur
            // 
            txtNomFournisseur.Location = new Point(108, 268);
            txtNomFournisseur.Name = "txtNomFournisseur";
            txtNomFournisseur.Size = new Size(249, 27);
            txtNomFournisseur.TabIndex = 8;
            // 
            // btnModifierFournisseur
            // 
            btnModifierFournisseur.Location = new Point(392, 320);
            btnModifierFournisseur.Name = "btnModifierFournisseur";
            btnModifierFournisseur.Size = new Size(94, 29);
            btnModifierFournisseur.TabIndex = 7;
            btnModifierFournisseur.Text = "Modifier";
            btnModifierFournisseur.UseVisualStyleBackColor = true;
            btnModifierFournisseur.Click += btnModifierFournisseur_Click;
            // 
            // btnSupprimerFournisseur
            // 
            btnSupprimerFournisseur.Location = new Point(392, 377);
            btnSupprimerFournisseur.Name = "btnSupprimerFournisseur";
            btnSupprimerFournisseur.Size = new Size(94, 29);
            btnSupprimerFournisseur.TabIndex = 6;
            btnSupprimerFournisseur.Text = "Supprimer";
            btnSupprimerFournisseur.UseVisualStyleBackColor = true;
            btnSupprimerFournisseur.Click += btnSupprimerFournisseur_Click;
            // 
            // btnAjouterFournisseur
            // 
            btnAjouterFournisseur.Location = new Point(392, 267);
            btnAjouterFournisseur.Name = "btnAjouterFournisseur";
            btnAjouterFournisseur.Size = new Size(94, 29);
            btnAjouterFournisseur.TabIndex = 5;
            btnAjouterFournisseur.Text = "Ajouter";
            btnAjouterFournisseur.UseVisualStyleBackColor = true;
            btnAjouterFournisseur.Click += btnAjouterFournisseur_Click;
            btnAjouterFournisseur.KeyDown += btnAjouterFournisseur_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 386);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 4;
            label8.Text = "Adresse";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 346);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 3;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 308);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 2;
            label6.Text = "Téléphone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 267);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 1;
            label5.Text = "Nom";
            // 
            // dgvFournisseurs
            // 
            dgvFournisseurs.AllowUserToAddRows = false;
            dgvFournisseurs.AllowUserToDeleteRows = false;
            dgvFournisseurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFournisseurs.Location = new Point(3, 35);
            dgvFournisseurs.MultiSelect = false;
            dgvFournisseurs.Name = "dgvFournisseurs";
            dgvFournisseurs.ReadOnly = true;
            dgvFournisseurs.RowHeadersWidth = 51;
            dgvFournisseurs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFournisseurs.Size = new Size(829, 218);
            dgvFournisseurs.TabIndex = 0;
            dgvFournisseurs.CellClick += dgvFournisseurs_CellClick;
            dgvFournisseurs.CellContentClick += dgvFournisseurs_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 486);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantite).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrix).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvArticles).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFournisseurs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvArticles;
        private TextBox txtNomArticle;
        private Label label1;
        private ComboBox cboTypeArticle;
        private Label Type;
        private Label label3;
        private Label label2;
        private NumericUpDown numPrix;
        private NumericUpDown numQuantite;
        private ComboBox cboFournisseur;
        private Label label4;
        private Button btnSupprimerArticle;
        private Button btnModifierArticle;
        private Button btnAjouterArticle;
        private Button button2;
        private Button button1;
        private Label label6;
        private Label label5;
        private DataGridView dgvFournisseurs;
        private Button btnModifierFournisseur;
        private Button btnSupprimerFournisseur;
        private Button btnAjouterFournisseur;
        private Label label8;
        private Label label7;
        private TextBox txtAdresseFournisseur;
        private TextBox txtEmailFournisseur;
        private TextBox txtTelephoneFournisseur;
        private TextBox txtNomFournisseur;
        private Button button4;
        private Button button3;
    }
}
