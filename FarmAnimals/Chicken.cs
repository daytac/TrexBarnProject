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
            Species = "Chicken";
            Age = age;
            Gender = gender;
            Lifespan = 365 * 10;
            AnimalValue = 50;

            CurrentProduct = new Product()
            {
                ProductName = "Yumurta",
                ProductTime = 5,
                ProductValue = 5
            };
        }
        public override void ProducePoduct() => ProductionProgres = 0;
        
           
        //public override void ProducePoduct()
        //{
        //    ProductionProgres = 0;
        //}
    }
}
