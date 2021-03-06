﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Animal
    {
    private string name;
    private string favouriteFood;

    public Animal(string name, string favouriteFood)
    {
        this.Name = name;
        this.FavouriteFood = favouriteFood;
    }
    public string FavouriteFood
    {
        get { return favouriteFood; }
        protected set { favouriteFood = value; }
    }


    public string Name
    {
        get { return name; }
        protected set { name = value; }
    }
    public virtual string ExplainMyself()
    {
        return $"I am {this.Name} and my fovourite food is {this.FavouriteFood}";
    }

}

