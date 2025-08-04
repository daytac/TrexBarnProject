using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrexBarn.FarmAnimals
{
    public class Chicken : Animals
    {
        public Chicken(int age, string gender)
        {
            Species = "Tavuk";
            Age = age;
            Gender = gender;
            Lifespan = 60;
            AnimalValue = 60;

            CurrentProduct = new Product()
            {
                ProductName = "Yumurta",
                ProductTime = 5,
                ProgressPerTick = 20,// 100/5
                ProductValue = 5
            };
        }
        public override void ProduceProduct() => ProductionProgress = 0;
    }
}
