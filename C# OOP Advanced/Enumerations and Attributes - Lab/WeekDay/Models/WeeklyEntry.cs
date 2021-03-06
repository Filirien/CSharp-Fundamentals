﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

public class WeeklyEntry : IComparable<WeeklyEntry>
{
    private WeekDay weekDay;

    public WeeklyEntry(string weekday, string notes)
    {
        Enum.TryParse(weekday, out this.weekDay);
        this.Notes = notes;
    }

    public WeekDay WeekDay { get; set; }
    public string Notes { get; set; }
    public override string ToString()
    {
        return $"{this.weekDay} - {this.Notes}";

    }

    public int CompareTo(WeeklyEntry other)
    {
        if (ReferenceEquals(this,other))
        {
            return 0;
        }
        if (ReferenceEquals(null,other))
        {
            return 1;
        }
        var weekDayComparison = weekDay.CompareTo(other.weekDay);
        if (weekDayComparison!=0)
        {
            return weekDayComparison;
        }
        return string.Compare(Notes, other.Notes, StringComparison.Ordinal);
    }
}

