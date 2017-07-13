using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Food
{
    private int quantityFood;

    protected Food(int quantityFood)
    {
        this.QuantityFood = quantityFood;
    }

    public int QuantityFood
    {
        get { return quantityFood; }
        set { quantityFood = value; }

    }
}