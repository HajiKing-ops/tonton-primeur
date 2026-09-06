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
            dgvArticles = new DataGridView();
            tabPage2 = new TabPage();
            label1 = new Label();
            txtNomArticle = new TextBox();
            Type = new Label();
            cboTypeArticle = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArticles).BeginInit();
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
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cboTypeArticle);
            tabPage1.Controls.Add(Type);
            tabPage1.Controls.Add(txtNomArticle);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dgvArticles);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Articles";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvArticles
            // 
            dgvArticles.AllowUserToAddRows = false;
            dgvArticles.AllowUserToDeleteRows = false;
            dgvArticles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticles.Location = new Point(6, 15);
            dgvArticles.MultiSelect = false;
            dgvArticles.Name = "dgvArticles";
            dgvArticles.ReadOnly = true;
            dgvArticles.RowHeadersWidth = 51;
            dgvArticles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArticles.Size = new Size(300, 188);
            dgvArticles.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Fournisseurs";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 216);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 1;
            label1.Text = "Nom de l'article";
            label1.Click += label1_Click;
            // 
            // txtNomArticle
            // 
            txtNomArticle.Location = new Point(127, 213);
            txtNomArticle.Name = "txtNomArticle";
            txtNomArticle.Size = new Size(125, 27);
            txtNomArticle.TabIndex = 2;
            txtNomArticle.TextChanged += textBox1_TextChanged;
            // 
            // Type
            // 
            Type.AutoSize = true;
            Type.Location = new Point(22, 250);
            Type.Name = "Type";
            Type.Size = new Size(50, 20);
            Type.TabIndex = 3;
            Type.Text = "label2";
            // 
            // cboTypeArticle
            // 
            cboTypeArticle.FormattingEnabled = true;
            cboTypeArticle.Items.AddRange(new object[] { "Fruit", "Légume" });
            cboTypeArticle.Location = new Point(114, 250);
            cboTypeArticle.Name = "cboTypeArticle";
            cboTypeArticle.Size = new Size(151, 28);
            cboTypeArticle.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArticles).EndInit();
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
    }
}
