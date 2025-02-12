
using System;
using System.Collections.Generic;

class UserNode
{
    public int UserId;
    public string Name;
    public int Age;
    public List<int> FriendIds;
    public UserNode Next;

    public UserNode(int userId, string name, int age)
    {
        UserId = userId;
        Name = name;
        Age = age;
        FriendIds = new List<int>();
        Next = null;
    }
}

class SocialMedia
{
    private UserNode head;

    public void AddUser(int userId, string name, int age)
    {
        UserNode newUser = new UserNode(userId, name, age);
        newUser.Next = head;
        head = newUser;
    }

    public void AddFriend(int userId1, int userId2)
    {
        UserNode user1 = FindUser(userId1);
        UserNode user2 = FindUser(userId2);
        if (user1 != null && user2 != null && userId1 != userId2)
        {
            if (!user1.FriendIds.Contains(userId2)) user1.FriendIds.Add(userId2);
            if (!user2.FriendIds.Contains(userId1)) user2.FriendIds.Add(userId1);
        }
    }

    public void RemoveFriend(int userId1, int userId2)
    {
        UserNode user1 = FindUser(userId1);
        UserNode user2 = FindUser(userId2);
        if (user1 != null && user2 != null)
        {
            user1.FriendIds.Remove(userId2);
            user2.FriendIds.Remove(userId1);
        }
    }

    public void DisplayFriends(int userId)
    {
        UserNode user = FindUser(userId);
        if (user != null)
        {
            Console.Write("friends of " + user.Name + ": ");
            foreach (int friendId in user.FriendIds)
            {
                UserNode friend = FindUser(friendId);
                if (friend != null) Console.Write(friend.Name + " ");
            }
            Console.WriteLine();
        }
    }

    public void FindMutualFriends(int userId1, int userId2)
    {
        UserNode user1 = FindUser(userId1);
        UserNode user2 = FindUser(userId2);
        if (user1 != null && user2 != null)
        {
            Console.Write("mutual friends of " + user1.Name + " and " + user2.Name + ": ");
            foreach (int id in user1.FriendIds)
            {
                if (user2.FriendIds.Contains(id))
                {
                    UserNode mutual = FindUser(id);
                    if (mutual != null) Console.Write(mutual.Name + " ");
                }
            }
            Console.WriteLine();
        }
    }

    public UserNode FindUser(int userId)
    {
        UserNode current = head;
        while (current != null)
        {
            if (current.UserId == userId) return current;
            current = current.Next;
        }
        return null;
    }

    public void SearchUser(string nameOrId)
    {
        UserNode current = head;
        while (current != null)
        {
            if (current.Name == nameOrId || current.UserId.ToString() == nameOrId)
            {
                Console.WriteLine("found: " + current.Name + ", age: " + current.Age);
                return;
            }
            current = current.Next;
        }
        Console.WriteLine("user not found");
    }
}

class Program
{
    static void Main()
    {
        SocialMedia sm = new SocialMedia();
        sm.AddUser(1, "Alok", 25);
        sm.AddUser(2, "Ramesh", 27);

        sm.AddFriend(1, 2);
        sm.DisplayFriends(1);
        sm.DisplayFriends(2);

        sm.FindMutualFriends(1, 2);

        sm.RemoveFriend(1, 2);
        sm.DisplayFriends(1);
        sm.DisplayFriends(2);

        sm.SearchUser("Alok");
        sm.SearchUser("3");
    }
}

