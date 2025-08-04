using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrexBarn.FarmAnimals
{
    public class Bee:Animals
    {
        public Bee(int age, string gender)
        {
            Species = "Arı";
            Age = age;
            Gender = gender;
            Lifespan = 60;
            AnimalValue = 100;

            CurrentProduct = new Product()
            {
                ProductName = "Bal",
                ProductTime = 20,
                ProgressPerTick=5, // 100/20
                ProductValue = 25 
            };
        }
        public override void ProduceProduct() => ProductionProgress = 0;
    }
}
