using AdminNamespace;
using PostNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserNamespace;

namespace PostProgramNamespace
{
    public class AdminHelper
    {
        public static void AdminSection(Admin[]Admins,Post []posts,User[]Users)
        {
            bool adm = true;
            while (adm)
            {
                Console.WriteLine("include  username");
                string username = Console.ReadLine();

                Console.WriteLine("include password");
                string password = Console.ReadLine();

                foreach (var admin in Admins)
                {
                    if (username == admin.Email || username == admin.Username && password == admin.Password)
                    {
                        adm = false;
                        bool adm2 = true;
                        while (adm2)
                        {
                            Console.WriteLine("1-show posts");
                            Console.WriteLine("2-remove post");
                            Console.WriteLine("3-add post");
                            Console.WriteLine("4-information about your profile");
                            Console.WriteLine("5-exit");
                            bool isInt=int.TryParse(Console.ReadLine(), out int result1);
                            if (result1 == 1)
                            {
                                foreach (var post in posts)
                                {
                                    Console.WriteLine(post.ToString());
                                }
                            }
                            else if (result1 == 2)
                            {
                                Console.WriteLine("include index");
                            bool isInt2=int.TryParse(Console.ReadLine(), out int result2);

                                admin.RemovePost(posts, result2);
                                Console.WriteLine( posts[result2].ToString() ); 
                                Console.WriteLine("this post has already been deleted");
                            }
                            else if (result1 == 3)
                            {
                                Post post = new Post
                                {
                                    Content ="hello",
                                    LikeCount =0,
                                    ViewCount =0
                                };
                                admin.AddPost(ref post);
                                Console.WriteLine(post.ToString ());
                                Console.WriteLine(" post was added");
                            }
                            else if (result1 == 4)
                            {
                                Console.WriteLine(admin.ToString()  ); 
                            }
                            else if (result1 == 5)
                            {
                                adm2 = false;
                                Console.WriteLine("1-user 2-admin");
                                bool isInt2 = int.TryParse(Console.ReadLine(), out int result2);
                                if (result2 == 1)
                                {
                                    UserHelper.UserSection(Users ,posts,Admins);
                                }
                                else if (result2 == 2)
                                {
                                    AdminHelper.AdminSection(Admins, posts, Users);
                                }
                                else
                                {
                                    new Exception("invalid argument");
                                }
                            }
                        }
                    }
                    else
                    {
                        new Exception("wrang username or password");
                    }
                }
            }
        }
    }
    public class UserHelper
    {

        public static void UserSection(User[]Users,Post[]posts,Admin[]Admins)
        {
            bool us = true;
            while (us)
            {


                Console.WriteLine("include  name");
                string name = Console.ReadLine();

                Console.WriteLine("include password");
                string password = Console.ReadLine();
                foreach (var user in Users)
                {
                    if (name == user.Email || name == user.Name && password == user.Password)
                    {
                        us = false;
                        bool ex = true;
                        while (ex)
                        {
                            Console.WriteLine("1-show posts");
                            Console.WriteLine("2-exit");
                            Console.WriteLine("3-like");
                            bool isInt2 = int.TryParse(Console.ReadLine(), out int result2);
                            if (result2 == 1)
                            {

                                foreach (var post in posts)
                                {
                                    Console.WriteLine(post.ToString());
                                }
                            }
                            else if (result2 == 2)
                            {
                                ex = false;
                                Console.WriteLine("1-User or 2-Admin");
                                bool isInt3 = int.TryParse(Console.ReadLine(), out int result3);
                                if (result3 == 1)
                                {
                                    UserHelper.UserSection(Users, posts,Admins);
                                }
                                else if (result3 == 2)
                                {
                                    AdminHelper.AdminSection(Admins, posts, Users);
                                }
                                else if (result3 == 3)
                                {
                                    Console.WriteLine("Enter the number of the post you want to like");
                                    string id = Console.ReadLine();
                                    foreach (var post in posts)
                                    {
                                        if (id == post.Id.ToString())
                                        {
                                            ++post.LikeCount;
                                        }

                                    }

                                }
                                else
                                {
                                    new Exception("wrang number");
                                }
                            }
                            else if (result2 == 3)
                            {
                               
                                
                                    Console.WriteLine("Enter the id of the post you want to like");
                                    string id = Console.ReadLine();
                                    foreach (var post in posts)
                                    {
                                        if (id == post.Id.ToString())
                                        {
                                            ++post.LikeCount;
                                        Console.WriteLine("the operation was completed successfully");
                                        }
                                    else
                                    {
                                        new Exception("wrang id");
                                    }

                                    }

                                
                            }
                        }



                    }
                    else
                    {
                        new Exception("wrang name or password");
                    }
                }
            }
        }


    }
}
