using System;

[AttributeUsage(AttributeTargets.Method)]
public class RoleAllowedAttribute : Attribute
{
    public string Role { get; }

    public RoleAllowedAttribute(string role)
    {
        Role = role;
    }
}

public class AccessControl
{
    public string UserRole { get; }

    public AccessControl(string userRole)
    {
        UserRole = userRole;
    }

    [RoleAllowed("ADMIN")]
    public void AdminTask()
    {
        if (UserRole != "ADMIN")
        {
            Console.WriteLine("access denied!");
            return;
        }

        Console.WriteLine("admin task executed successfully");
    }

    [RoleAllowed("USER")]
    public void UserTask()
    {
        if (UserRole != "USER" && UserRole != "ADMIN")
        {
            Console.WriteLine("access denied!");
            return;
        }

        Console.WriteLine("user task executed successfully");
    }
}

class Program
{
    static void Main(string[] args)
    {
        AccessControl adminUser = new AccessControl("ADMIN");
        AccessControl normalUser = new AccessControl("USER");
        AccessControl guestUser = new AccessControl("GUEST");

        Console.WriteLine("admin user:");
        adminUser.AdminTask();
        adminUser.UserTask();

        Console.WriteLine("\nnormal user:");
        normalUser.AdminTask();
        normalUser.UserTask();

        Console.WriteLine("\nguest user:");
        guestUser.AdminTask();
        guestUser.UserTask();
    }
}
