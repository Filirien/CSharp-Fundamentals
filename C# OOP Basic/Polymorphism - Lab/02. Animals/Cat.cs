using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cat :Animal
{
    private string name;
    private string favoutriteFood;
    public Cat(string name, string favoutirteFood)
        :base(name,favoutirteFood)
    {
        
    }
    public override string ExplainMyself()
    {
        return base.ExplainMyself() + Environment.NewLine + "MEEOW";

    }
}
