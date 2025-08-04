using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrexBarn.FarmAnimals
{
    public class Goat:Animals
    {
        public Goat(int age, string gender)
        {
            Species = "Keçi";
            Age = age;
            Gender = gender;
            Lifespan = 100;
            AnimalValue = 120;

            CurrentProduct=new Product()
            {
                ProductName="Peynir",
                ProductTime = 25,
                ProgressPerTick=4, // 100/25
                ProductValue = 30
            };
        }
        public override void ProduceProduct() => ProductionProgress = 0;
    }
}
