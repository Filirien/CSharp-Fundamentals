using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

public class Box<T> : IBox<T>
{
    private IList<T> data = new List<T>();
    public int Count => this.data.Count;

    public void Add(T item)
    {
        this.data.Add(item);
    }


    public T Remove()
    {
        if (this.data.Count == 0)
        {
            throw new InvalidOperationException("Cannot remove an item from an empty collection.");
        }
        var rem = this.data.Last();
        this.data.RemoveAt(this.data.Count - 1);
        return rem;
    }
}
