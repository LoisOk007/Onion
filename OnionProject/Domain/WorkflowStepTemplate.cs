

public class WorkflowStepTemplate()
{
    public int Order { get; set; }
    public int UserID { get; set; }
    public int RoleID { get; set; }
    public string Name { get; set; }
    public WorkflowStepTemplate(int orderId,int userId,int roleId,string name)
    {
        if(orderId==nuint||userId==nuint||roleId==nuint||name=="")
        {
            throw new ArgumentNullExeption("Введённые данные были пустыми или не полностью заполнеными.");
            Order=orderId;
            UserID=userId;
            RoleID=roleId;
            Name=name;
        }
    }
}