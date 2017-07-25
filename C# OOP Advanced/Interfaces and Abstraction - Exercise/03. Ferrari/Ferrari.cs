using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ferrari:ICar
{
    public string Name { get; }
    public string Model { get; set; }

    public Ferrari(string name,string model)
    {
        this.Name = name;
        this.Model = model;
    }

    public override string ToString()
    {
        return $"{this.Model}/Brakes!/Zadu6avam sA!/{this.Name}";
    }
}
