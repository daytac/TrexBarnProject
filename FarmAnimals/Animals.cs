using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrexBarn
{
    public abstract class Animals
    {
        private static int _nextId = 1;
        public int Id { get; } = _nextId++;
        public string Species {  get; set; }
        public string Gender { get; set; }
        public int Age {  get; set; }
        public int Lifespan {  get; set; }
        public bool isAlive => Age < Lifespan;
        public int AnimalValue {  get; set; }
        public abstract void ProducePoduct();
        public int ProductionProgres { get; set; }
        public Product CurrentProduct { get; set; }
        public override string ToString() => $"{Species} - {Gender} - ID: {Id}";

    }

    public class Product
    {
        public string ProductName {  get; set; }    
        public int ProductTime { get; set; }
        public int ProductCount { get; set; }
        public int ProductValue { get; set; }
        
    }
}