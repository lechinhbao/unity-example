public class User
{
    public User(string email, string password)
    {
        this.email = email;
        this.password = password;
    }
    public User(string email, string password, string name, int age)
    {
        this.email = email;
        this.password = password;
        this.name = name;
        this.age = age;
    }
    private string email { get; set; }
    private string password { get; set; }
    private string name { get; set; }
    private int age { get; set; }
}
