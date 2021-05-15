using System;
using PostNamespace;
using NotificationNamespace;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseNamespace;

namespace AdminNamespace
{

    //Admin=>id,username,email,password,Posts,Notifications

    public class Admin : Base
    {

        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Post[] Posts { get; set; }
        public int PostCount { get; set; }
        public int NotificationCount { get; set; }
        public Notification[] Notifications { get; set; }
        public override string ToString()
        {
            return $@"Id{Id}
               ,Username{Username}, 
                Email   {Email },
                Password{Password}
       Notification Count{NotificationCount },
               Post count{PostCount }";
        }
        public Post[] RemovePost(Post[] Posts, int index)
        {
            Post[] destination = new Post[Posts.Length - 1];
            if (index > 0)
            {
                Array.Copy(Posts, 0, destination, 0, index);
            }
            if (index < Posts.Length - 1)
            {
                Array.Copy(Posts, index + 1, destination, index, Posts.Length - index - 1);
            }
            return destination;
        }

        public Notification[] RemoveNotification(Notification[] Notifications, int index)
        {
            Notification[] destination = new Notification[Notifications.Length - 1];
            if (index > 0)
            {
                Array.Copy(Posts, 0, destination, 0, index);
            }
            if (index < Posts.Length - 1)
            {
                Array.Copy(Posts, index + 1, destination, index, Notifications.Length - index - 1);
            }
            return destination;
        }

        public void AddPost(ref Post post)
        {
            Post[] temp = new Post[++PostCount];
            if (Posts != null)
            {
                Posts.CopyTo(temp, 0);
            }
            temp[temp.Length - 1] = post;
            Posts = temp;
        }

        public void AddNotification(ref Notification notification)
        {
            Notification[] temp = new Notification[++NotificationCount];
            if (Notifications != null)
            {
                Notifications.CopyTo(temp, 0);
            }
            temp[temp.Length - 1] = notification;
            Notifications = temp;
        }

        public void ShowPosts()
        {
            if (Posts != null)
            {
                foreach (var post in Posts)
                {
                    post.ToString();
                }
            }
        }
        public void ShowNotifications()
        {
            if (Posts != null)
            {
                foreach (var notification in Posts)
                {
                    notification.ToString();
                }
            }
        }
    }


}
