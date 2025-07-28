using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrexBarn
{
    public abstract class Animals
    {

        public string Species {  get; set; }
        public string Gender { get; set; }
        public int Age {  get; set; }
        public int Lifespan {  get; set; }
        public bool isAlive => Age < Lifespan;
        public int ProductTime {  get; set; }   
        public int ProductCount { get; set; }
        public int ProductValue {  get; set; }  
        public int ProductionProgres {  get; set; }   
        public int AnimalValue {  get; set; }
        public abstract void ProducePoduct();

    }
}
// species, age, gender, lifespan, producttime, productvalue, productionprogres,