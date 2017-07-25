using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CustomList<T> : IEnumerable where T : IComparable<T>
{
    private List<T> cusList = new List<T>();
    public void Add(T element)
    {
        cusList.Add(element);
    }

    public T Remove(int index)
    {
        var elementToReturn = this.cusList[index];
        this.cusList.RemoveAt(index);
        return elementToReturn;
    }

    public bool Contains(T element)
    {
        return this.cusList.Contains(element);
    }

    public void Swap(int index1, int index2)
    {
        var firstIndex = index1;
        var secondIndex = index2;
        var old = cusList[firstIndex];
        cusList[firstIndex] = cusList[secondIndex];
        cusList[secondIndex] = old;
    }

    public int CountGreaterThan(T element)
    {
        return this.cusList.Count(e => e.CompareTo(element) > 0);
    }

    public T Max()
    {
        return cusList.Max();
    }

    public T Min()
    {
        return cusList.Min();
    }
    public IEnumerator<T> GetEnumerator()
    {
        return this.cusList.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}
