using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ListyIterator<T>
{
    private List<T> elements;
    private int currentIndex;

    public ListyIterator(List<T> elements)
    {
        this.elements = elements;
        currentIndex = 0;
    }

  
    public bool HasNext()
    {
        return this.currentIndex + 1 < this.elements.Count;
    }

    public bool Move()
    {
        if (HasNext())
        {
            this.currentIndex++;
            return true;
        }
        return false;
    }


    public void Print()
    {
        if (this.elements.Count == 0)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }
        Console.WriteLine(this.elements[this.currentIndex]);
    }
}
