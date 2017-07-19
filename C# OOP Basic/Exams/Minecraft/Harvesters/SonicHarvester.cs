using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SonicHarvester : Harvester
{
    private int sonicFactor;

    public int SonicFactor
    {
        get { return sonicFactor; }
        set { this.sonicFactor = value; }
    }

    public SonicHarvester(string id, double oreOutput, double energyRequirement,int sonicFactor)
        : base(id, oreOutput, energyRequirement)
    {
        this.SonicFactor = sonicFactor;
    }
    public override string ToString()
    {
        return $"Sonic Harvester - {this.Id}{Environment.NewLine}Ore Output: {this.OreOutput}{Environment.NewLine}Energy Requirement: {this.EnergyRequirement}";
    }
}
