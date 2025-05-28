namespace MagazinOnline
{
    partial class SellerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerForm));
            lblBunVenit = new Label();
            btnCereAprobare = new Button();
            groupBox1 = new GroupBox();
            chkNegociabil = new CheckBox();
            txtDescriere = new TextBox();
            numPret = new NumericUpDown();
            txtNume = new TextBox();
            btnAdaugaProdus = new Button();
            dataGridViewProduse = new DataGridView();
            btnAnuleazaVanzare = new Button();
            btnAprobaNegociere = new Button();
            btnAnuleazaNegociere = new Button();
            panel1 = new Panel();
            label2 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPret).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduse).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblBunVenit
            // 
            lblBunVenit.AutoSize = true;
            lblBunVenit.BackColor = Color.Transparent;
            lblBunVenit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBunVenit.ForeColor = Color.White;
            lblBunVenit.Location = new Point(27, 53);
            lblBunVenit.Name = "lblBunVenit";
            lblBunVenit.Size = new Size(88, 21);
            lblBunVenit.TabIndex = 0;
            lblBunVenit.Text = "Bun venit!";
            lblBunVenit.Click += lblBunVenit_Click;
            // 
            // btnCereAprobare
            // 
            btnCereAprobare.Location = new Point(257, 53);
            btnCereAprobare.Name = "btnCereAprobare";
            btnCereAprobare.Size = new Size(150, 30);
            btnCereAprobare.TabIndex = 1;
            btnCereAprobare.Text = "Cere aprobare cont";
            btnCereAprobare.Click += btnCereAprobare_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(chkNegociabil);
            groupBox1.Controls.Add(txtDescriere);
            groupBox1.Controls.Add(numPret);
            groupBox1.Controls.Add(txtNume);
            groupBox1.Controls.Add(btnAdaugaProdus);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(27, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 196);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adaugă produs";
            // 
            // chkNegociabil
            // 
            chkNegociabil.Location = new Point(20, 125);
            chkNegociabil.Name = "chkNegociabil";
            chkNegociabil.Size = new Size(115, 31);
            chkNegociabil.TabIndex = 0;
            chkNegociabil.Text = "Negociabil?";
            // 
            // txtDescriere
            // 
            txtDescriere.Location = new Point(20, 88);
            txtDescriere.Name = "txtDescriere";
            txtDescriere.PlaceholderText = "Descriere produs";
            txtDescriere.Size = new Size(350, 29);
            txtDescriere.TabIndex = 1;
            // 
            // numPret
            // 
            numPret.DecimalPlaces = 2;
            numPret.Location = new Point(20, 58);
            numPret.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numPret.Name = "numPret";
            numPret.Size = new Size(150, 29);
            numPret.TabIndex = 2;
            // 
            // txtNume
            // 
            txtNume.Location = new Point(20, 28);
            txtNume.Name = "txtNume";
            txtNume.PlaceholderText = "Nume produs";
            txtNume.Size = new Size(350, 29);
            txtNume.TabIndex = 3;
            // 
            // btnAdaugaProdus
            // 
            btnAdaugaProdus.BackColor = Color.Silver;
            btnAdaugaProdus.ForeColor = Color.Black;
            btnAdaugaProdus.Location = new Point(20, 157);
            btnAdaugaProdus.Name = "btnAdaugaProdus";
            btnAdaugaProdus.Size = new Size(150, 32);
            btnAdaugaProdus.TabIndex = 4;
            btnAdaugaProdus.Text = "Adaugă produs";
            btnAdaugaProdus.UseVisualStyleBackColor = false;
            btnAdaugaProdus.Click += btnAdaugaProdus_Click;
            // 
            // dataGridViewProduse
            // 
            dataGridViewProduse.Location = new Point(457, 53);
            dataGridViewProduse.Name = "dataGridViewProduse";
            dataGridViewProduse.ReadOnly = true;
            dataGridViewProduse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProduse.Size = new Size(540, 300);
            dataGridViewProduse.TabIndex = 3;
            // 
            // btnAnuleazaVanzare
            // 
            btnAnuleazaVanzare.Location = new Point(470, 359);
            btnAnuleazaVanzare.Name = "btnAnuleazaVanzare";
            btnAnuleazaVanzare.Size = new Size(150, 33);
            btnAnuleazaVanzare.TabIndex = 4;
            btnAnuleazaVanzare.Text = "Anulează vânzare";
            btnAnuleazaVanzare.Click += btnAnuleazaVanzare_Click;
            // 
            // btnAprobaNegociere
            // 
            btnAprobaNegociere.Location = new Point(651, 359);
            btnAprobaNegociere.Name = "btnAprobaNegociere";
            btnAprobaNegociere.Size = new Size(150, 33);
            btnAprobaNegociere.TabIndex = 5;
            btnAprobaNegociere.Text = "Aprobă negociere";
            btnAprobaNegociere.Click += btnAprobaNegociere_Click;
            // 
            // btnAnuleazaNegociere
            // 
            btnAnuleazaNegociere.Location = new Point(825, 359);
            btnAnuleazaNegociere.Name = "btnAnuleazaNegociere";
            btnAnuleazaNegociere.Size = new Size(150, 33);
            btnAnuleazaNegociere.TabIndex = 6;
            btnAnuleazaNegociere.Text = "Anulează negociere";
            btnAnuleazaNegociere.Click += btnAnuleazaNegociere_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 18, 18);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1020, 36);
            panel1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 11);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 4;
            label2.Text = "FIS";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(983, 0);
            button1.Name = "button1";
            button1.Size = new Size(37, 36);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // SellerForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1020, 420);
            Controls.Add(panel1);
            Controls.Add(lblBunVenit);
            Controls.Add(btnCereAprobare);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewProduse);
            Controls.Add(btnAnuleazaVanzare);
            Controls.Add(btnAprobaNegociere);
            Controls.Add(btnAnuleazaNegociere);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SellerForm";
            Text = "Interfață Vânzător";
            Load += SellerForm_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPret).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduse).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblBunVenit;
        private System.Windows.Forms.Button btnCereAprobare;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.NumericUpDown numPret;
        private System.Windows.Forms.TextBox txtDescriere;
        private System.Windows.Forms.CheckBox chkNegociabil;
        private System.Windows.Forms.Button btnAdaugaProdus;
        private System.Windows.Forms.DataGridView dataGridViewProduse;
        private System.Windows.Forms.Button btnAnuleazaVanzare;
        private System.Windows.Forms.Button btnAprobaNegociere;
        private System.Windows.Forms.Button btnAnuleazaNegociere;
        private Panel panel1;
        private Label label2;
        private Button button1;
    }
}
