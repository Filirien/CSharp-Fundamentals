namespace _04.Merging_two_files_into_third_one
{
    using System.IO;
    public class Program
    {
        public static void Main()
        {
            string[] file1 = File.ReadAllLines(@"C:\Users\Niki\Desktop\C# Fundamentals\Exercises\03. CSharp-Advanced-Files-And-Directories\05_MergingFiles\01_FileOne.txt");
            string[] file2 = File.ReadAllLines(@"C:\Users\Niki\Desktop\C# Fundamentals\Exercises\03. CSharp-Advanced-Files-And-Directories\05_MergingFiles\01_FileTwo.txt");

            using (StreamWriter writer = File.CreateText(@"C:\Users\Niki\Desktop\C# Fundamentals\Exercises\03. CSharp-Advanced-Files-And-Directories\05_MergingFiles\01_Merged.txt"))
            {
                int lineNum = 0;
                while (lineNum < file1.Length || lineNum < file2.Length)
                {
                    if (lineNum < file1.Length)
                    {
                        writer.WriteLine(file1[lineNum]);
                    }
                    if (lineNum < file2.Length)
                    {
                        writer.WriteLine(file2[lineNum]);
                    }
                    lineNum++;
                }
            }
        }
    }
}
