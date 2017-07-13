using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Felime : Mammal
{
    public Felime(string animalName, string animalType,double animalWeight,  string livingRegion) 
        :   base(animalName, animalType,animalWeight,  livingRegion)
    {
    }
}
