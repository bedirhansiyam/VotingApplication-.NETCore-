namespace VotingApplication;

public class Category
{
    private string name;
    private int numberOfVotes;

    public string Name { get => name; set => name = value; }
    public int NumberOfVotes { get => numberOfVotes; set => numberOfVotes = value; }

    public static List<Category> DefineCategories()
    {
        List<Category> _categories = new List<Category>();

        Category category1 = new Category();
        category1.Name = "Real-Time Strategy";
        category1.NumberOfVotes = 5;
        _categories.Add(category1);

        Category category2 = new Category();
        category2.Name = "Shooters";
        category2.NumberOfVotes = 3;
        _categories.Add(category2);

        Category category3 = new Category();
        category3.Name = "MOBA";
        category3.NumberOfVotes = 1;
        _categories.Add(category3);

        Category category4 = new Category();
        category4.Name = "Role-playing";
        category4.NumberOfVotes = 7;
        _categories.Add(category4);

        Category category5 = new Category();
        category5.Name = "Simulation";
        category5.NumberOfVotes = 5;
        _categories.Add(category5);

        Category category6 = new Category();
        category6.Name = "Sports";
        category6.NumberOfVotes = 10;
        _categories.Add(category6);

        Category category7 = new Category();
        category7.Name = "Action-Adventure";
        category7.NumberOfVotes = 7;
        _categories.Add(category7);

        Category category8 = new Category();
        category8.Name = "Survival and Horror";
        category8.NumberOfVotes = 3;
        _categories.Add(category8);                

        return _categories;
    }    
}