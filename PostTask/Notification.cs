using System;
using UserNamespace;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseNamespace;
//Notification => id,Text,DateTime,FromUser(bu hansi user terefinden bu bildirishin geldiyidir)
namespace NotificationNamespace
{
    public class Notification : Base
    {

        public string Text { get; set; }
        public DateTime Date { get; set; }
        public User FromUser { get; set; }

        public override string ToString()
        {
            return $@"Id  {Id},
                      Text{Text},
                      Date{Date},
                 from User{FromUser}";
        }
    }
}
