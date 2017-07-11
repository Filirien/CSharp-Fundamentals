using System;
using System.Collections;
using System.Collections.Generic;

public class RandomList : ArrayList
{
    private Random rnd; //TODO: Add ctor
    public RandomList()
    {
        this.rnd = new Random();
    }
    
    public string RandomString()
    {
        return "";
    }
}
