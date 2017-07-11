using System.Collections.Generic;
using System;
public class Team
{
    private string name;
    private List<Person> firstTeam;
    private List<Person> reserveTeam;

    

    public Team(string name)
    {
        this.name = name;
        this.firstTeam = new List<Person>();
        this.reserveTeam = new List<Person>();
    }
    public IReadOnlyCollection<Person> FirstTeam => this.firstTeam.AsReadOnly();
    public IReadOnlyCollection<Person> ReserveTeam => this.reserveTeam.AsReadOnly();
    public void AddPlayer(Person player)
    {
        if (player.Age < 40)
        {
            firstTeam.Add(player);
        }
        else
        {
            reserveTeam.Add(player);
        }
    }
    public override string ToString()
    {
        return $"First team have {firstTeam.Capacity} players{Environment.NewLine}Reserve team have {reserveTeam.Capacity} players";
    }
}

