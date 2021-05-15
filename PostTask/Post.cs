using BaseNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Post => id,Content,CreationDateTime,LikeCount,ViewCount
namespace PostNamespace
{
    public class Post : Base
    {

        public string Content { get; set; }
        public DateTime CreationDateTime { get; set; }
        public int LikeCount { get; set; }
        public int ViewCount { get; set; }
        public override string ToString()
        {
            return $@"Id{Id},
           Content      {Content},
           Creation Time{CreationDateTime },
           Like count   {CreationDateTime },
           View Count   {ViewCount }";
        }
    }
}