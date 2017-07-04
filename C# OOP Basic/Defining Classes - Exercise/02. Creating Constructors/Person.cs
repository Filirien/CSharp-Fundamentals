﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person
{
    public string name;
    public int age;

    public string Name { get; set; }
    public int Age { get; set; }

    public Person()
    {
        this.name = "No name";
        this.age = 1;
    }
    public Person(int age)
        :this()
    {
        this.age = age;
    }
    public Person(string name, int age)
        : this(age)
    {
        this.name = name;
    }
}
