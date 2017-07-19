using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HammerHarvester:Harvester
{
    public HammerHarvester(string id, double oreOutput, double energyRequirement)
        : base(id, oreOutput, energyRequirement)
    {
    }

    public override string ToString()
    {
        return $"Hammer Harvester - {this.Id}{Environment.NewLine}Ore Output: {this.OreOutput}{Environment.NewLine}Energy Requirement: {this.EnergyRequirement}";
    }
}
