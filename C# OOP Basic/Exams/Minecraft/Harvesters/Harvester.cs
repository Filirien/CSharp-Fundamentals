using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Harvester
{
    private string id;
    private double oreOutput;
    private double energyRequirement;
    private double sumOfOre;


    protected Harvester(string id, double oreOutput, double energyRequirement)
    {
        this.Id = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    public double EnergyRequirement
    {
        get
        {
            return energyRequirement;
        }
       protected set
        {
            if (value < 0 || value >= 20000)
            {
                throw new ArgumentException("Harvester is not registered, because of it's EnergyRequirement");
            }
            this.energyRequirement = value;
        }
    }

    public double OreOutput
    {
        get { return oreOutput; }
        protected set
        {
            if (value < 0 )
            {
                throw new ArgumentException();
            }
            this.oreOutput = value;
        }
    }


    public string Id
    {
        get { return id; }
        set { this.id = value; }
    }

    public override string ToString()
    {
        return base.ToString();
    }

 
}
