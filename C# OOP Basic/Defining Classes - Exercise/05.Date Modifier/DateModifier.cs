using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class DateModifier
{
    private DateTime startingDate;
    private DateTime endDate;


    public DateTime StartingDate
    {
        get
        {
            return this.startingDate;
        }
        set
        {
            this.startingDate = value;
        }
    }
    public DateTime EndDate
    {
        get
        {
            return this.endDate;
        }
        set
        {
            this.endDate = value; 
        }
    }

}

