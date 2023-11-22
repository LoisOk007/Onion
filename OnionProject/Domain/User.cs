

public class User(int id, string name,string email,int roleId)
{
    public int Id { get; set; }
    public int RoleID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public User(int id,string name,string email,int roleId)
    {
        if(id==nuint||name==''||email==''||roleId==nuint)
        {
            throw new ArgumentNullExeption("Вводимые данные были пустыми.");
        }
        else
        {
            Id=id; Name=name;
            RoleID=roleId; Email=email;
        }
    }
}