using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class Student : Human
{
    private string facNum;

    public Student(string firstName,string lastName,string facNum)
        :base(firstName,lastName)
    {
        this.FacNum = facNum;
    }
    public string FacNum
    {
        get
        {
            return this.facNum;
        }
        set
        {
            if (value.Length < 5 || value.Length > 10 || !Regex.IsMatch(value, @"[a-zA-Z0-9]{5,10}"))
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            this.facNum = value;
        }
    }


    public override string ToString()
    {
        return base.ToString() + $"{Environment.NewLine}Faculty number: {this.facNum}";
    }
}
