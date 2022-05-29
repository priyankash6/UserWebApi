using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserWebApi.Model
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }
        public Int32 Number { get; set; }
        public string Address { get; set; }
        public string DocumentID { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
