namespace VotingApplication;

public class User
{
    private string userName;
    private string password;

    public string UserName { get => userName; set => userName = value; }
    public string Password { get => password; set => password = value; }
    
    public static List<User> DefineUser()
    {
        List<User> _users = new List<User>();

        User user1 = new User();
        user1.UserName = "bedirhan";
        user1.Password = "123456";
        _users.Add(user1);

        User user2 = new User();
        user2.UserName = "cengizhan";
        user2.Password = "987654";
        _users.Add(user2);

        User user3 = new User();
        user3.UserName = "sila";
        user3.Password = "123456";
        _users.Add(user3);        

        return _users;
    }
}