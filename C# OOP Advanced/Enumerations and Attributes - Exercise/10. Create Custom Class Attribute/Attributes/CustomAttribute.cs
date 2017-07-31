using System;
[AttributeUsage(AttributeTargets.Enum)]
public class CustomAttribute : Attribute
{
    private string author;
    private int revision;
    private string description;
    private string reviewers;

    public CustomAttribute(string author, int revision, string description,string reviewers)
    {
        this.author = author;
        this.revision = revision;
        this.description = description;
        this.reviewers = reviewers;
    }

    public override string ToString()
    {
        return $"Author = {this.author}{Environment.NewLine}" +
               $"Revision: {this.revision}{Environment.NewLine}" +
               $"Description = {this.description}{Environment.NewLine}" +
               $"Attributes.{Environment.NewLine}" +
               $"Reviewers: {this.reviewers}";
    }
}
