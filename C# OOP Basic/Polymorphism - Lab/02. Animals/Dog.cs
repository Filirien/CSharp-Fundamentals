using System;
public class Dog : Animal
{
    private string name;
    private string favoutriteFood;
    public Dog(string name, string favoutirteFood)
        :base(name,favoutirteFood)
    {

    }
    public override string ExplainMyself()
    {
        return base.ExplainMyself() + Environment.NewLine + "DJAAF";

    }
}
