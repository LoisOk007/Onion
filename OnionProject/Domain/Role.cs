
public class Role(int id,string name)
{
    public int Id { get; set; }
    public string Name { get; set; }
    protected Role[500] Roles {get;}
    public Role(int id,string name)
    {
        if(Roles==null)
        {
            Roles+=new Role(id,name);
            Id=id;
            Name=name;
        }
        else
        {
            foreach (var role in Roles)
            {
                if(role.Id==id||role.Name==name)
                {
                    Id=role.Id;
                    Name=role.Name;
                }
            }
            Roles+=new Role(id,name);
            Id=role.Id;
            Name=role.Name;
        }
    }
}