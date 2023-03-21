namespace VotingApplication;
public static class MenuHelper
{
  
    public static void ControlSelection(out int selection, int maxValue)
    {
        bool selectionController;
        do
        {
            selectionController = int.TryParse(Console.ReadLine(), out selection);
            if (selection > 0 && selection <= maxValue && selectionController == true)
                selectionController = true;
            else
                selectionController = false;
            if (selectionController == false)
                Console.Write("Please make a valid selection : ");
        } while (selectionController == false);
    }

    public static void Continue()
    {
        Console.WriteLine();
        Console.WriteLine("Please press any key to continue!");
        Console.ReadKey();
        Console.Clear();
    }
    public static void Continue(string text)
    {
        Console.WriteLine();
        Console.WriteLine(text);
        Console.ReadKey();
        Console.Clear();
    }

    public static void GetCategories()
    {
        Console.WriteLine("Please select one of the game genres to voting");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("1-) Real-time Strategy");
        Console.WriteLine("2-) Shooters (FPS and TPS)");
        Console.WriteLine("3-) MOBA");
        Console.WriteLine("4-) Role-playing");
        Console.WriteLine("5-) Simulation");
        Console.WriteLine("6-) Sports");
        Console.WriteLine("7-) Action-Adventure");
        Console.WriteLine("8-) Survival and Horror");
        Console.WriteLine("");
    }
}