namespace Week07.Linq
{
    using System.Collections.Generic;
    using System.Linq;
    using Models;
    using Setup;
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var allUsers = ReadUsers("users.json");
            var allPosts = ReadPosts("posts.json");

            // 1 - find all users having email ending with ".net".
                //Var 1
            var netUsers = from u in allUsers
                           where u.Email.EndsWith(".net")
                           select u;           
            foreach (var user in netUsers)
            {
                Console.WriteLine(user.Email);
            }

                //Var 2
            var LinqNetUsers = allUsers.Where(x => x.Email.EndsWith(".net"));              
            foreach (var user1 in LinqNetUsers)
            {
                Console.WriteLine(user1.Email);
            }


            // 2 - find all posts for users having email ending with ".net".
                //Var 1
            var postEmailJoin = from post in allPosts
                                join netEmail in netUsers on post.UserId equals netEmail.Id
                                select new
                                {
                                    UserEmail = netEmail.Email,
                                    UserName = netEmail.Name,
                                    PostTitle = post.Title,
                                    PostBody = post.Body
                                };
            foreach (var obj in postEmailJoin)
            {
                Console.WriteLine($"User's: Email {obj.UserEmail};\nName {obj.UserName};\nPost title: { obj.PostTitle};\nPost body: {obj.PostBody}");
            }

                //Var 2
            var LinqPostEmailJoin = LinqNetUsers.Join(
                                    allPosts,
                                    linqNetEmail => linqNetEmail.Id,
                                    linqPost => linqPost.UserId,
                                   
                                    (linqNetEmail, linqPost) => new 
                                    {
                                        UserEmail = linqNetEmail.Email,
                                        UserName = linqNetEmail.Name,
                                        PostTitle = linqPost.Title,
                                        PostBody = linqPost.Body
                                    });
            foreach (var obj in LinqPostEmailJoin)
            {
                Console.WriteLine($"User's email {obj.UserEmail};\nName {obj.UserName};\nPost title: { obj.PostTitle};\nPost body: {obj.PostBody}");
            }

            // 3 - print number of posts for each user.

            var numOfPosts = from numPost in allPosts
                             group numPost by numPost.UserId into numbPosts //http://www.csharp-examples.net/linq-count/
                             select new
                             {
                                 Users = numbPosts.Key,
                                 Count = numbPosts.Count(),
                             };

            foreach (var obj in numOfPosts)
            {
                Console.WriteLine($"User number {obj.Users} has {obj.Count} posts");
            }

            // 4 - find all users that have lat and long negative.


            // 5 - find the post with longest body.
            //Var 1
            var longBody = allPosts.Max();           
            Console.WriteLine("Longest body from userid {0} and id {1} is:\n {2} ", longBody.UserId,longBody.Id, longBody.Body);

            //var 2
            var linqLongBody = allPosts.OrderByDescending(s => s.Body.Length).First();
            Console.WriteLine("Longest body from userid {0} and id {1} is:\n {2} ", linqLongBody.UserId, linqLongBody.Id, linqLongBody.Body);

            // 6 - print the name of the employee that have post with longest body.
            

            // 7 - select all addresses in a new List<Address>. print the list.


            // 8 - print the employee with min lat

            // 9 - print the employee with max long


            // 10 - create a new class: public class UserPosts { public User User {get; set}; public List<Post> Posts {get; set} }
            //    - create a new list: List<UserPosts>
            //    - insert in this list each user with his posts only


            // 11 - order users by zip code


            // 12 - order users by number of posts


            System.Console.ReadKey();
        }

        private static List<Post> ReadPosts(string file)
        {
            return ReadData.ReadFrom<Post>(file);
        }

        private static List<User> ReadUsers(string file)
        {
            return ReadData.ReadFrom<User>(file);
        }

    }
}
