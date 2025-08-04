using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrexBarn.FarmAnimals;

namespace TrexBarn
{
    public partial class Form1 : Form
    {
        //private double cash = 1000.00;
        private Farm farm = new Farm();
        private Dictionary<string, ProgressBar> productProgressBars;
        private Dictionary<string, Label> productCountLabels;
        public Form1()
        {
            InitializeComponent();
            ComboBoxes();
            UpdateCash();
            DataGridViewColumns();
            InitializeProductUI();
            UpdateProductUI();
            dataGridView1.DataSource = farm.Animals;
        }
        private void ComboBoxes()
        {
            cmbAnimalType.Items.AddRange(new string[] { "İnek", "Tavuk", "Koyun", "Keçi", "Arı" });
            cmbAnimalType.SelectedIndex = 0;

            cmbProduct.Items.AddRange(new string[] { "Süt", "Yumurta", "Yün", "Peynir", "Bal" });
            cmbProduct.SelectedIndex = 0;   
        }

        // Kasa bilgisini güncelle
        private void UpdateCash()
        {
            lblBudget.Text = $"Kasa: {farm.TotalMoney} tl";
        }

        // Hayvan türüne göre fiyat belirle
        private int GetAnimalPrice(string animalType)
        {
            switch (animalType)
            {
                case "İnek": return 200;
                case "Tavuk": return 50;
                case "Koyun": return 150;
                case "Keçi": return 120;
                case "Arı": return 100;
                default: return 00;
            }
        }

        // Hayvan türüne göre nesne oluştur
        private Animals CreateAnimal(string animalType, string gender, int age)
        {
            switch (animalType)
            {
                case "İnek": return new Cow(age, gender);
                case "Tavuk": return new Chicken(age, gender);
                case "Koyun": return new Sheep(age, gender);
                case "Keçi": return new Goat(age, gender);
                case "Arı": return new Bee(age, gender);
                default: return new Cow(age, gender);
            }
        }
        private void btnBuy_Click(object sender, EventArgs e)
        {
            string selectedAnimal = cmbAnimalType.SelectedItem.ToString();
            string gender = rdbMale.Checked ? "Erkek" : "Dişi";
            int age = int.Parse(txtAnimalAge.Text);

            int animalPrice = GetAnimalPrice(selectedAnimal);

            if (farm.TotalMoney < animalPrice)
            {
                MessageBox.Show($"Yetersiz bakiye! Gerekli: {animalPrice} tl\nMevcut: {farm.TotalMoney} tl",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Animals newAnimal = CreateAnimal(selectedAnimal, gender, age);
            farm.Animals.Add(newAnimal);
      
            farm.TotalMoney -= animalPrice;
            UpdateCash();

            MessageBox.Show($"{selectedAnimal} satın alındı!\nID: {newAnimal.Id}\nCinsiyet: {gender}",
                            "Satın Alma Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DataGridViewColumns()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Width = 50
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Species",
                HeaderText = "Tür",
                Width = 100
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Gender",
                HeaderText = "Cinsiyet",
                Width = 80
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Age",
                HeaderText = "Yaş",
                Width = 60
            });
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var animal in farm.Animals.ToList())
            {
                animal.Age++;

                // Ölüm kontrolü (isteğe bağlı)
                if (!animal.isAlive)
                {
                    farm.Animals.Remove(animal);
                }
            }
        }
        private void ProductTimer_Tick(object sender, EventArgs e)
        {
            farm.ProduceProducts();
            UpdateProductUI();
        }
        private void UpdateProductUI()
        {
            // Her ürün için UI güncellemesi
            foreach (var product in farm.ProductInventory)
            {
                string productName = product.Key;

                // ProgressBar güncelleme
                if (productProgressBars.ContainsKey(productName))
                {
                    int progress = farm.ProductProgress[productName];
                    productProgressBars[productName].Value = progress;
                }

                // Ürün sayısı güncelleme
                if (productCountLabels.ContainsKey(productName))
                {
                    productCountLabels[productName].Text = product.Value.ToString();
                }
            }
            
        }
        private void InitializeProductUI()
        {
            
            // ProgressBar'larınızı sözlüğe ekleyin
            productProgressBars = new Dictionary<string, ProgressBar>
            {
              {"Süt", pbMilk}, // Tasarımda verdiğiniz isim
              {"Yumurta", pbEgg},
              {"Yün", pbWool},
              {"Bal", pbHoney},
              {"Peynir", pbCheese}
            };

            // Ürün sayısı Label'larınızı sözlüğe ekleyin
            productCountLabels = new Dictionary<string, Label>
            {
              {"Süt", lblMilk},
              {"Yumurta", lblEgg},
              {"Yün", lblWool},
              {"Bal", lblHoney},
              {"Peynir", lblCheese}
            };

        }
        private void btnSell_Click(object sender, EventArgs e)
        {
            // Seçilen ürünü al
            string selectedProduct = cmbProduct.SelectedItem?.ToString();
            int productQuantity= (int)nudNumber.Value;

            // Satış işlemini yap
            if (string.IsNullOrEmpty(selectedProduct))
            {
                MessageBox.Show("Lütfen bir ürün seçin!");
                return;
            }

            if (farm.SellProduct(selectedProduct, productQuantity))
            {
                // Başarılı satış
                UpdateCash();
                UpdateProductUI();

                MessageBox.Show($"{productQuantity} adet {selectedProduct} satıldı!\n" +
                                $"Kazanç: {farm.GetProductValue(selectedProduct) * productQuantity} tl");
            }
            else
            {
                MessageBox.Show("Satış başarısız! Yeterli ürün yok.");
            }
        }

    }
}
