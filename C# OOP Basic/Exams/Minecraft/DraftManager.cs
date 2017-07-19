using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

public class DraftManager
{
    private Dictionary<string, Provider> providers;
    private Dictionary<string, Harvester> harvesters;
    private double summedEnergyOutput;
    private double summedOreOutput;
    private double totalEnergy;
    private double totalOre;
    private string modeEnergy;
    public DraftManager()
    {
        this.providers = new Dictionary<string, Provider>();
        this.harvesters = new Dictionary<string, Harvester>();

    }
    public string RegisterHarvester(List<string> arguments)
    {
        if (!harvesters.ContainsKey(arguments[1]))
        {
            var type = arguments[0];
            var id = arguments[1];
            var oreOutput = double.Parse(arguments[2]);
            var energyReq = double.Parse(arguments[3]);
            if (type == "Sonic")
            {
                var sonicPower = int.Parse(arguments[4]);
                this.harvesters[arguments[1]] = new SonicHarvester(id, oreOutput, energyReq / sonicPower, sonicPower); // TODO Може да е объркано делението за energyReq!!
            }
            else if (type == "Hammer")
            {

                harvesters[arguments[1]] = new HammerHarvester(id, oreOutput + oreOutput * 2, energyReq + energyReq); // TODO Може да има грешка при процентнотоумножение
            }
            return $"Successfully registered {type} Harvester – {id}";
        }
        return $"Harvester is not registered, because of it's EnergyRequirement";  // TODO НЕ Е EnergyRequirement, а определено проперти !!!
    }
    public string RegisterProvider(List<string> arguments)
    {
        if (!providers.ContainsKey(arguments[2]))
        {
            var type = arguments[0];
            var id = arguments[1];
            var energyOutput = double.Parse(arguments[2]);
            if (type == "Solar")
            {
                providers[id]=new SolarProvider(id,energyOutput);
            }
            else if (type == "Pressure")
            {
                providers[id] = new PressureProvider(id,energyOutput*1.5);
            }
            return $"Successfully registered {type} Provider – {id}";
        }
        return $"Provider is not registered, because of it's EnergyOutput";  // TODO exeption  ENERGYOUTPUT !!!
    }
    public string Day()
    {
        var output = new StringBuilder();
        var newEnergy = providers.Values.Sum(a => a.EnergyOutput);
        totalEnergy += newEnergy;
        var result = $"A day has passed.{Environment.NewLine}Energy Provided: {newEnergy}{Environment.NewLine}";
        if (modeEnergy=="Full")
        {
            var reqEnergy = harvesters.Values.Sum(a => a.EnergyRequirement);
            if (totalEnergy > newEnergy)
            {
                return result + $"Plumbus Ore Mined: 0";
            }
            double currentOre = harvesters.Values.Sum(o => o.OreOutput);
            totalOre += currentOre;
            totalEnergy -= reqEnergy;
            
            return $"Plumbus Ore Mined: {currentOre}";

        }
        else if (modeEnergy == "Energy")
        {
            return result+ $"Plumbus Ore Mined: 0";
        }
        else if (modeEnergy=="Half")
        {
            var reqEnergy = harvesters.Values.Sum(a => a.EnergyRequirement)*0.6;
            if (totalEnergy > newEnergy)
            {
                return result + $"Plumbus Ore Mined: 0";
            }
            double currentOre = harvesters.Values.Sum(o => o.OreOutput)*0.5;
            totalOre += currentOre;
            totalEnergy -= reqEnergy;

            return $"Plumbus Ore Mined: {currentOre}";
        }
        return "";
    }
    public string Mode(List<string> arguments)
    {
        switch (arguments[0])
        {
            
            case "Half":
                modeEnergy = "Half";
                return "Successfully changed working mode to Half Mode";
            case "Energy":
                modeEnergy = "Energy";
                return "Successfully changed working mode to Energy Mode";
            default:
                modeEnergy = "Full";
                return "Successfully changed working mode to Full Mode";
        }

    }

    public string Check(List<string> arguments)
    {
        if (harvesters.ContainsKey(arguments[0]))
        {
            return harvesters[arguments[0]].ToString();
        }
        return $"No element found with id – {arguments[0]}";
    }

    public string Shutdown()
    {
        return $"System Shutdown{Environment.NewLine}Total Energy Stored: {totalEnergy}{Environment.NewLine}Total Mined Plumbus Ore: {totalOre}";

    }
}
