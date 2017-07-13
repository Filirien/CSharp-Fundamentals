using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Mood
{
    public Mood(string moodName)
    {
        this.MoodName = moodName;
    }
    public string MoodName { get; set; }
}
