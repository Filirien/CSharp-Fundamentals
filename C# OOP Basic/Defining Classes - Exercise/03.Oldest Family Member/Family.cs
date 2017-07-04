using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Family
{
    public List<Person> family = new List<Person>();
    public void AddMember(Person member)
    {
        this.family.Add(member);
    }
    public Person GetOldestMember()
    {
         return family.OrderByDescending(x => x.Age).FirstOrDefault();
    }
}
