    using System;
    using AdminNamespace;
    using NotificationNamespace;
    using PostNamespace;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Net.Mail;
    using System.Net;
    using UserNamespace;
using PostProgramNamespace;
using NetworkNamespace;

namespace PostTask
{
        class Program
        {

        static void Main(string[] args)
        {
           
     

                Guid guid = Guid.NewGuid();
            DateTime dateTime = DateTime.Now;
            User user1 = new User
            {

                Name = "nezrin",
                Surname = "rehimli",
                Age = 16,
                Email = "NezrinRehimli@gmail.com",
                Id = guid,
                Password = "nezrin123"

            };
            User user2 = new User
            {
                Name = "Leyla",
                Surname = "Abdullayeva",
                Age = 22,
                Email = "LeylaAbdullayeva@gmail.com",
                Id = guid,
                Password = "leyla123"
            };
            User[] Users = { user1, user2 };
            Notification notification1 = new Notification
            {
                Date = dateTime,
                FromUser = user1,
                Id = guid,
                Text = "hello"
            };
            Notification notification2 = new Notification
            {
                Date = dateTime,
                FromUser = user2,
                Id = guid,
                Text = "hello"
            };
            Post post1 = new Post
            {
                Id = guid,
                Content = "hello",
                CreationDateTime = dateTime,
                LikeCount = 5,
                ViewCount = 4
            };
            Post post2 = new Post
            {
                Id = guid,
                Content = "hello",
                CreationDateTime = dateTime,
                LikeCount = 3,
                ViewCount = 1
            };
            Post[] posts = { post1, post2 };
            Notification[] notifications = { notification1, notification2 };
            Admin admin = new Admin
            {
                Id = guid,
                Email = "naranana123gt@gmail.com",
                NotificationCount = 4,
                Username = "anaraugurlu",
                Password = "anara123",
                PostCount = 5,
                Notifications = notifications,
                Posts = posts


            };
            Admin admin2 = new Admin
            {
                Id = guid,
                Email = "naranana123gt@gmail.com",
                NotificationCount = 4,
                Username = "zeynebesgerova",
                Password = "zeyneb123",
                PostCount = 5,
                Notifications = notifications,
                Posts = posts


            };
            Admin[] Admins = { admin, admin2 };
           
            Console.WriteLine("1-User or 2-Admin");
               bool isInt = int.TryParse(Console.ReadLine(), out int result);
            if (result == 1)
            {
                UserHelper.UserSection(Users, posts,Admins);
               
            }
            else if (result == 2)
            {

                AdminHelper.AdminSection(Admins, posts,Users);


            }
          
            else
            {
                throw new Exception();
            }
        }
    }
}
