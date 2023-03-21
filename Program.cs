namespace VotingApplication;
class Program
{
    static void Main(string[] args)
    {
        List<Category> _categories = Category.DefineCategories();
        List<User> _users = User.DefineUser();
        bool check = true;
        bool control = true;
        do
        {
            do
            {
                Console.WriteLine("Please login to vote");
                Console.WriteLine("--------------------");
                Console.WriteLine("");
                Console.Write("Username : ");
                string userName = Console.ReadLine();
    
                Console.Write("Password : ");
                string password = Password.HidePassword();
    
                foreach (var user in _users)
                {
                    if (userName == user.UserName && password == user.Password)
                    {
                        check = true;
                        Console.WriteLine("");
                        Console.WriteLine("Sign-in successful");
                        MenuHelper.Continue();
                        break;
                    }
                    else
                    {
                        check = false;
                    }
                }
    
                if (check == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Username or password is wrong.");
                    Console.WriteLine("");
                    Console.WriteLine("Press (1) to try again");
                    Console.WriteLine("Press (2) to sign-up");
    
                    MenuHelper.ControlSelection(out int selection, 2);
                    if (selection == 1)
                        check = false;
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("SIGN-UP");
                        Console.WriteLine("*******");
                        Console.Write("Username : ");
                        string newUserName = Console.ReadLine();
                        Console.Write("Password : ");
                        string newPassword = Password.HidePassword();
    
                        User newUser = new User();
                        newUser.UserName = newUserName;
                        newUser.Password = newPassword;
                        _users.Add(newUser);
                        Console.WriteLine("");
                        Console.WriteLine("Sign-up is successful. Thank you.");
    
                        MenuHelper.Continue();
                    }
    
                }
    
            } while (check == false);
    
            
            MenuHelper.GetCategories();
            Console.Write("Your vote : ");
    
            MenuHelper.ControlSelection(out int vote, 8);
    
            switch (vote)
            {
                case 1:
                    _categories[0].NumberOfVotes += 1;
                    break;
                case 2:
                    _categories[1].NumberOfVotes += 1;
                    break;
                case 3:
                    _categories[2].NumberOfVotes += 1;
                    break;
                case 4:
                    _categories[3].NumberOfVotes += 1;
                    break;
                case 5:
                    _categories[4].NumberOfVotes += 1;
                    break;
                case 6:
                    _categories[5].NumberOfVotes += 1;
                    break;
                case 7:
                    _categories[6].NumberOfVotes += 1;
                    break;
                case 8:
                    _categories[7].NumberOfVotes += 1;
                    break;
                default:
                    break;
            }
            Console.WriteLine("Thanks for voting!");
    
            MenuHelper.Continue("Please press any key to see results");
    
            double totalVotes = 0;
            foreach (var votes in _categories)
            {
                totalVotes += Convert.ToDouble(votes.NumberOfVotes);
            }
    
            GetResult(_categories, totalVotes);

            Console.WriteLine("Press (1) to log-out and sign-in with another account");
            Console.WriteLine("Press (2) to exit");
            MenuHelper.ControlSelection(out int chosen, 2);

            if(chosen == 1)
            {
                control = true;
                Console.Clear();
            }
            else
                control = false;

        } while (control == true);

    }

    private static void GetResult(List<Category> _categories, double totalVotes)
    {
        Console.WriteLine("Results");
        Console.WriteLine("-------");
        Console.WriteLine("");
        Console.WriteLine("Real-time Strategy     :  number of votes : " + _categories[0].NumberOfVotes + " - %" + Math.Round(((_categories[0].NumberOfVotes * 100) / totalVotes), 2));
        Console.WriteLine("Shooters (FPS and TPS) :  number of votes : " + _categories[1].NumberOfVotes + " - %" + Math.Round(((_categories[1].NumberOfVotes * 100) / totalVotes), 2));
        Console.WriteLine("MOBA                   :  number of votes : " + _categories[2].NumberOfVotes + " - %" + Math.Round(((_categories[2].NumberOfVotes * 100) / totalVotes), 2));
        Console.WriteLine("Role-playing           :  number of votes : " + _categories[3].NumberOfVotes + " - %" + Math.Round(((_categories[3].NumberOfVotes * 100) / totalVotes), 2));
        Console.WriteLine("Simulation             :  number of votes : " + _categories[4].NumberOfVotes + " - %" + Math.Round(((_categories[4].NumberOfVotes * 100) / totalVotes), 2));
        Console.WriteLine("Sports                 :  number of votes : " + _categories[5].NumberOfVotes + " - %" + Math.Round(((_categories[5].NumberOfVotes * 100) / totalVotes), 2));
        Console.WriteLine("Action-Adventure       :  number of votes : " + _categories[6].NumberOfVotes + " - %" + Math.Round(((_categories[6].NumberOfVotes * 100) / totalVotes), 2));
        Console.WriteLine("Survival and Horror    :  number of votes : " + _categories[7].NumberOfVotes + " - %" + Math.Round(((_categories[7].NumberOfVotes * 100) / totalVotes), 2));
        Console.WriteLine("");
    }
}
