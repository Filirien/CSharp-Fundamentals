using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

public class Box<T> where T : IComparable
{
    private T value;

    public Box(T value)
    {
        this.value = value;
    }
    public override string ToString()
    {
        return $"{this.value.GetType().FullName}: {this.value}";
    }
    public int CompareTo(T element)
    {
        return this.value.CompareTo(element);
    }
}
