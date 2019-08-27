using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5
{
    class ViewModel
    {
        public List<Order> orders;
        public ViewModel()
        {
            orders = new List<Order>()
            {
                new Order(1,"noam","mori",24,"noamori@gmail.com",true,300,EnumStatus.Processing),
                new Order(2,"shanny","mori", 34, "shani@walla.com", true,250,EnumStatus.New),
                new Order (3, "Israel", "mori", 56,"israel@gmail.co.il",false,400,EnumStatus.Shipped)
            };
        }
    }
}
