using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrexBarn
{
    public abstract class Animals : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private static int _nextId = 1;
        public int Id { get; } = _nextId++;
        public string Species {  get; set; }
        public string Gender { get; set; }
        private int age {  get; set; }
        public int Age
        {
            get => age;
            set
            {
                age = value;
                OnPropertyChanged(nameof(Age));
                OnPropertyChanged(nameof(isAlive)); // Yaş değişince canlılık durumu da değişebilir
            }
        }
        private void OnPropertyChanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }
        public int Lifespan {  get; set; }
        public bool isAlive => Age < Lifespan;
        public int AnimalValue {  get; set; }
        public abstract void ProduceProduct();
        private int productionProgress;
        public int ProductionProgress { get=>productionProgress; set
            {
                productionProgress = value;
                OnPropertyChanged(nameof(ProductionProgress));
            } }
        public Product CurrentProduct { get; set; }
        public override string ToString() => $"{Species} - {Gender} - ID: {Id}";
        public string Status => isAlive ? "Canlı" : "Ölü";

    }

    public class Product
    {
        public string ProductName {  get; set; }    
        public int ProductTime { get; set; }
        public int ProgressPerTick { get; set; }
        public int ProductValue { get; set; }
        
    }
}