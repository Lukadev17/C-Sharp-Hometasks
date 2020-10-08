using System;
using System.Collections;

namespace homeTask_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Users = new ArrayList();
            
            Console.WriteLine("etner the  recipients name : ");
            string FirstName = Console.ReadLine();
            Console.WriteLine("etner the  recipients lastname : ");
            string LastName = Console.ReadLine();
            Console.WriteLine("etner the  recipients address : ");
            string address = Console.ReadLine();
            User recipient1 = new User(FirstName, LastName,address);
            Users.Add(recipient1);
            
            Console.WriteLine("ID of the User - " + recipient1.Firstname + " is " + recipient1.Id );
            Console.WriteLine("Enter the subject: ");
            string subject = Console.ReadLine();
            Console.WriteLine("Enter the body of the message: ");
            string body = Console.ReadLine();
            Message message = new Message(subject, body);
            
            Post post = new Post();
            post.SendMessage(recipient1, message);
            
        }
    }
}