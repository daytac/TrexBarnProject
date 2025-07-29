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
            Species = "Bee";
            Age = age;
            Gender = gender;
            Lifespan = 365 * 10;
            AnimalValue = 100;

            CurrentProduct=new Product()
            {
                ProductName="Bal",
                ProductTime = 20,
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
