using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrexBarn
{
    public class Farm
    {
        public BindingList<Animals> Animals { get; } = new BindingList<Animals>();
        public int TotalMoney { get; set; } = 1000;
        // Ürün envanteri
        public Dictionary<string, int> ProductInventory { get; } = new Dictionary<string, int>()
        {
            {"Süt", 0},
            {"Yumurta", 0},
            {"Yün", 0},
            {"Bal", 0},
            {"Peynir", 0}
        };
        // Her ürün için ortalama üretim ilerlemesi
        public Dictionary<string, int> ProductProgress { get; } = new Dictionary<string, int>()
        {
           {"Süt", 0},
           {"Yumurta", 0},
           {"Yün", 0},
           {"Bal", 0},
           {"Peynir", 0}
        };
        // Ürün üretme metodunu güncelle
        public void ProduceProducts()
        {
            // Önce tüm progress değerlerini sıfırla
            foreach (var key in ProductProgress.Keys.ToList())
            {
                ProductProgress[key] = 0;
            }

            // Üretim sayılarını sıfırla (eğer sadece progress göstereceksek)
            // Gerçek envanteri sıfırlamıyoruz, sadece ilerleme için
            foreach (var animal in Animals.ToList())
            {
                if (animal.isAlive)
                {
                    string product = animal.CurrentProduct.ProductName;

                    animal.ProductionProgress += animal.CurrentProduct.ProgressPerTick;

                    if (animal.ProductionProgress > ProductProgress[product])
                    {
                        ProductProgress[product] = animal.ProductionProgress;
                    } 

                    if (animal.ProductionProgress >= 100)
                    {
                        ProductInventory[product]++;
                        animal.ProduceProduct(); // Progress'i sıfırla
                    }
                }
            }
            
        }
        public bool SellProduct(string productName, int quantity)
        {
            // Ürün envanterde var mı kontrol et
            if (!ProductInventory.ContainsKey(productName))
                return false;

            // Yeterli miktar var mı?
            if (ProductInventory[productName] < quantity)
                return false;

            // Fiyatı hesapla (ürünün birim fiyatı * miktar)
            int totalValue = 0;
            var animal = Animals.FirstOrDefault(a =>
                a.CurrentProduct.ProductName == productName);

            if (animal != null)
            {
                totalValue = animal.CurrentProduct.ProductValue * quantity;
                TotalMoney += totalValue;
                ProductInventory[productName] -= quantity;
                return true;
            }

            return false;
        }
        public double GetProductValue(string productName)
        {
            var animal = Animals.FirstOrDefault(a =>
                a.CurrentProduct.ProductName == productName);

            return animal?.CurrentProduct.ProductValue ?? 0;
        }
    }

}
