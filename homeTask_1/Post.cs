using System;
using Microsoft.VisualBasic.CompilerServices;

namespace homeTask_1
{
    public class Post
    {
        public void SendMessage(User user, Message message)
        {
            Console.WriteLine(user.GetMessage(message) + " - is sent to the user : " + user.Firstname + "  " + user.Lastname);
            
        }
    }
}