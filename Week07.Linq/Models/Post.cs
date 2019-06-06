using System;
using System.Collections.Generic;

namespace Week07.Linq.Models
{
    public class Post: IComparable<Post>
    {
        public int UserId { get; set; }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public int CompareTo(Post other)
        {
            if (this.Body.Length >= other.Body.Length)
                return 1;
                return 0;
        }

        internal object Join(List<User> allUsers, Func<object, object> p1, Func<User, int> p2, Func<object, object, object> p3)
        {
            throw new NotImplementedException();
        }
    }    
}