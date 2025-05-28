using MagazinOnline.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazinOnline
{
    public partial class SellerForm : Form
    {
        private Seller vanzatorCurent;
        private List<Product> produse;

        public SellerForm(Seller vanzator)
        {
            InitializeComponent();
            this.vanzatorCurent = vanzator;
            IncarcaProduse();
            AfiseazaProduse();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCereAprobare_Click(object sender, EventArgs e)
        {
            vanzatorCurent.IsApproved = true; // presupunem că trimite cererea automat
            SalveazaVanzator();
            MessageBox.Show("Cererea de aprobare a fost trimisă.");
        }

        private void btnAdaugaProdus_Click(object sender, EventArgs e)
        {
            var produs = new Product
            {
                Id = GetNextProductId(),
                Name = txtNume.Text,
                Price = numPret.Value,
                Description = txtDescriere.Text,
                EsteNegociabil = chkNegociabil.Checked,
                VanzatorEmail = vanzatorCurent.Email
            };

            produse.Add(produs);
            SalveazaProduse();
            AfiseazaProduse();
            MessageBox.Show("Produs adăugat.");
        }

        private void btnAnuleazaVanzare_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduse.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridViewProduse.CurrentRow.Cells["Id"].Value);
                var produs = produse.FirstOrDefault(p => p.Id == id && p.VanzatorEmail == vanzatorCurent.Email);
                if (produs != null)
                {
                    produse.Remove(produs);
                    SalveazaProduse();
                    AfiseazaProduse();
                    MessageBox.Show("Produsul a fost anulat.");
                }
            }
        }

        private void btnAprobaNegociere_Click(object sender, EventArgs e)
        {
            // Ex: setează preț negociat = preț curent - 10%
            if (dataGridViewProduse.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridViewProduse.CurrentRow.Cells["Id"].Value);
                var produs = produse.FirstOrDefault(p => p.Id == id && p.EsteNegociabil);
                if (produs != null)
                {
                    produs.Price *= 0.9m; // exemplu: reducere 10%
                    SalveazaProduse();
                    AfiseazaProduse();
                    MessageBox.Show("Preț negociat aprobat.");
                }
            }
        }

        private void btnAnuleazaNegociere_Click(object sender, EventArgs e)
        {
            // Marcare ca non-negociabil
            if (dataGridViewProduse.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridViewProduse.CurrentRow.Cells["Id"].Value);
                var produs = produse.FirstOrDefault(p => p.Id == id && p.EsteNegociabil);
                if (produs != null)
                {
                    produs.EsteNegociabil = false;
                    SalveazaProduse();
                    AfiseazaProduse();
                    MessageBox.Show("Negocierea a fost anulată.");
                }
            }
        }

        private void IncarcaProduse()
        {
            string path = "Produse/produse.json";
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                produse = JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
            }
            else
            {
                produse = new List<Product>();
            }
        }

        private void SalveazaProduse()
        {
            string path = "Produse/produse.json";
            string json = JsonSerializer.Serialize(produse, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }

        private void SalveazaVanzator()
        {
            string path = "Conturi/sellers.json";
            var totiVanzatorii = JsonSerializer.Deserialize<List<Seller>>(File.ReadAllText(path));
            var index = totiVanzatorii.FindIndex(v => v.Email == vanzatorCurent.Email);
            if (index >= 0)
            {
                totiVanzatorii[index] = vanzatorCurent;
                File.WriteAllText(path, JsonSerializer.Serialize(totiVanzatorii, new JsonSerializerOptions { WriteIndented = true }));
            }
        }

        private void AfiseazaProduse()
        {
            dataGridViewProduse.DataSource = produse
                .Where(p => p.VanzatorEmail == vanzatorCurent.Email)
                .Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.Price,
                    p.Description,
                    Negociabil = p.EsteNegociabil ? "Da" : "Nu"
                }).ToList();
        }

        private int GetNextProductId()
        {
            return produse.Any() ? produse.Max(p => p.Id) + 1 : 1;
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblBunVenit_Click(object sender, EventArgs e)
        {

        }

        private void SellerForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
