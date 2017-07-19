using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main()
    {
        DraftManager draftManager = new DraftManager();
        while (true)
        {
            var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            try
            {
                var result= string.Empty;
                var input = command[0];
                command.RemoveAt(0);
                switch (input)
                {
                    case "RegisterHarvester":
                        result = draftManager.RegisterHarvester(command);
                        break;
                    case "RegisterProvider":
                        result = draftManager.RegisterProvider(command);
                        break;
                    case "Day":
                        result = draftManager.Day(); //TODO in DraftManager
                        break;
                    case "Mode":
                        result = draftManager.Mode(command); //TODO in DraftManager
                        break;
                    case "Check":
                        result = draftManager.Check(command); //TODO in DraftManager
                        break;
                    case "Shutdown":
                        result = draftManager.Shutdown();
                        Console.WriteLine(result);
                        return;
                }
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}

