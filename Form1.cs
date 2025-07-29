using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrexBarn.FarmAnimals;

namespace TrexBarn
{
    public partial class Form1 : Form
    {
        private double cash = 1000.00;
        private List<Animals> animals = new List<Animals>();
        public Form1()
        {
            InitializeComponent();
            AnimalComboBox();
            UpdateCash();
        }
        private void AnimalComboBox()
        {
            cmbAnimalType.Items.AddRange(new string[] { "İnek", "Tavuk", "Koyun", "Keçi", "Arı" });
            cmbAnimalType.SelectedIndex = 0;
        }

        // Kasa bilgisini güncelle
        private void UpdateCash()
        {
            lblBudget.Text = $"Kasa: {cash.ToString("C2")}";
        }

        // Hayvan türüne göre fiyat belirle
        private double GetAnimalPrice(string animalType)
        {
            switch (animalType)
            {
                case "İnek": return 200.00;
                case "Tavuk": return 50.00;
                case "Koyun": return 150.00;
                case "Keçi": return 120.00;
                case "Arı": return 100.00;
                default: return 00.00;
            }
        }

        // Hayvan türüne göre nesne oluştur
        private Animals CreateAnimal(string animalType, string gender)
        {
            switch (animalType)
            {
                case "İnek": return new Cow(0, gender);
                case "Tavuk": return new Chicken(0, gender);
                case "Koyun": return new Sheep(0, gender);
                case "Keçi": return new Goat(0, gender);
                default: return new Cow(0, gender);
            }
        }

        // Hayvan listesini güncelle (Kullanıdğınız kontrol tipine göre)
        //private void UpdateAnimalList(Animals newAnimal)
        //{
        //    // Eğer DataGridView kullanıyorsanız:
        //    if (dataGridView1 != null)
        //    {
        //        // DataGridView'in bağlı olduğu veri kaynağını güncelle
        //        if (dataGridView1.DataSource is BindingList<Animals> bindingList)
        //        {
        //            // BindingList otomatik güncellenir
        //        }
        //        else
        //        {
        //            // Manuel güncelleme
        //            dataGridView1.Rows.Add(
        //                newAnimal.Id,
        //                newAnimal.Species,
        //                newAnimal.Gender,
        //                newAnimal.Age
        //            );
        //        }
        //    }
        //}
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            // Seçilen hayvan türü ve cinsiyet
            string selectedAnimal = cmbAnimalType.SelectedItem.ToString();
            string gender = rdbMale.Checked ? "Erkek" : "Dişi";

            // Hayvan fiyatını al
            double animalPrice = GetAnimalPrice(selectedAnimal);

            // Yeterli bakiye kontrolü
            if (cash < animalPrice)
            {
                MessageBox.Show($"Yetersiz bakiye! Gerekli: {animalPrice:C2}\nMevcut: {cash:C2}",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hayvanı oluştur ve listeye ekle
            Animals newAnimal = CreateAnimal(selectedAnimal, gender);
            animals.Add(newAnimal);

            // Kasayı güncelle
            cash -= animalPrice;
            UpdateCash();

            // Başarı mesajı
            MessageBox.Show($"{selectedAnimal} satın alındı!\nID: {newAnimal.Id}\nCinsiyet: {gender}",
                            "Satın Alma Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
