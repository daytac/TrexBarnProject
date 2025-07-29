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
            Species = "Goat";
            Age = age;
            Gender = gender;
            Lifespan = 365 * 10;
            AnimalValue = 120;

            CurrentProduct=new Product()
            {
                ProductName="Peynir",
                ProductTime = 5,
                ProductValue = 15
            };
        }
        public override void ProducePoduct() => ProductionProgres = 0;
        //public override void ProducePoduct()
        //{
        //    ProductionProgres = 0;
        //}
    }
}
