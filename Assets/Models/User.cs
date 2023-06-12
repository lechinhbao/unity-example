
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
    public string email { get; set; }
    public string password { get; set; }
    public string name { get; set; }
    public int age { get; set; }
}
