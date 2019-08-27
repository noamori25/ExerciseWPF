using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5
{
    class Order
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email{ get; set; }
        public bool VIP { get; set; }
        public int Sum { get; set; }
        public EnumStatus Status { get; set; }
        public DateTime Birthday { get; set; }

        public Order(int id, string first, string last,int age, string email, bool vip, int sum, EnumStatus status)
        {
            Id = id;
            FirstName = first;
            LastName = last;
            Age = age;
            Email = email;
            VIP = vip;
            Sum = sum;
            Status = status;
        }
    }
}
