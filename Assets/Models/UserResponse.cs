public class UserResponse
{
    public UserResponse(int status, string id, string email, string name, int age, int score, string scene, string positionx, string positiony, string positionz)
    {
        this.status = status;
        this.id = id;
        this.email = email;
        this.name = name;
        this.age = age;
        this.score = score;
        this.scene = scene;
        this.positionx = positionx;
        this.positiony = positiony;
        this.positionz = positionz;
    }
    public int status { get; set; }
    public string id { get; set; }
    public string email { get; set; }
    public string name { get; set; }
    public int age { get; set; }
    public int score { get; set; }
    public string scene { get; set; }
    public string positionx { get; set; }
    public string positiony { get; set; }
    public string positionz { get; set; }
    private static UserResponse instance;
    public static void setInstance(UserResponse userResponse)
    {
        instance = userResponse;
    }
    public static UserResponse getInstance()
    {
        return instance;
    }
}
