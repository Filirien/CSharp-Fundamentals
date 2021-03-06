﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Scale<T> where T : IComparable<T>
{
    private T left;
    private T right;
    public Scale(T left, T right)
    {
        this.left = left;
        this.right = right;
    }

    public T GetHavier()
    {
        int compareResult = this.left.CompareTo(this.right);

        if (compareResult > 0)
        {
            return this.left;
        }
        else if (compareResult < 0)
        {
            return this.right;
        }
        else
        {
            return default(T);
        }
    }
}
