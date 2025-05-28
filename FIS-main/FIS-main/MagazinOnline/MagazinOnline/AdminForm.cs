using MagazinOnline.Clase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace MagazinOnline
{
    public partial class AdminForm : Form
    {
        private List<Seller> vanzatori;
        private List<Product> produse;

        private ListBox listBox1;
        private Button buttonApprove;
        private Button buttonDeactivate;

        public AdminForm()
        {
            InitializeComponent();
            IncarcaVanzatori();
            IncarcaProduse();
        }

        private void IncarcaVanzatori()
        {
            string path = "Conturi/sellers.json";
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                vanzatori = JsonSerializer.Deserialize<List<Seller>>(json) ?? new List<Seller>();
                dataGridViewVanzatori.DataSource = vanzatori.Select(v => new
                {
                    v.Email,
                    Aprobat = v.IsActive ? "Da" : "Nu",
                    Activ = v.IsActive ? "Da" : "Nu"
                }).ToList();
            }
        }

        private void IncarcaProduse()
        {
            string path = "Produse/produse.json";
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                produse = JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
                dataGridViewProduse.DataSource = produse.Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.Price,
                    p.VanzatorEmail,
                    p.Description,
                    Negociabil = p.EsteNegociabil ? "Da" : "Nu"
                }).ToList();
            }
        }

        
        private void buttonDeactivate_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                vanzatori[listBox1.SelectedIndex].IsActive = false;
            }
            else
            {
                MessageBox.Show("Selectează un vânzător.");
            }
        }
       

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewVanzatori.AutoGenerateColumns = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewVanzatori.CurrentRow != null)
            {
                string email = dataGridViewVanzatori.CurrentRow.Cells["Email"].Value.ToString();
                var vanzator = vanzatori.FirstOrDefault(v => v.Email == email);
                if (vanzator != null)
                {
                    vanzator.IsApproved = true;
                    SalveazaVanzatori();
                    IncarcaVanzatori();
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewProduse.AutoGenerateColumns = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridViewVanzatori.CurrentRow != null)
            {
                string email = dataGridViewVanzatori.CurrentRow.Cells["Email"].Value.ToString();
                var vanzator = vanzatori.FirstOrDefault(v => v.Email == email);
                if(vanzator!=null)
                {
                    vanzator.IsActive = false;
                    SalveazaVanzatori();
                    IncarcaVanzatori();
                }
            }
        }

        private void SalveazaVanzatori()
        {
            string path = "Conturi/sellers.json";
            string json = JsonSerializer.Serialize(vanzatori, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }

        private void SalveazaProduse()
        {
            string path = "Produse/produse.json";
            string json = JsonSerializer.Serialize(produse, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }
    }
}
