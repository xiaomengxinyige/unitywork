using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitywork
{
    class shop
    {
        string shopname;
        int price=1000;
        int add;
        public int Price
        {
            get{return price;}
            set{price=value;}
        }
        public int Add
        {
            get { return add; }
            set { add = value; }
        }
        public string Shopname
        {
            get { return shopname; }
            set { shopname = value; }
        }
        public void showshop()
        {
            Console.WriteLine("  "+Shopname+"   "+"$"+Price);
        }
        public void showsell()
        {
            Console.WriteLine("请选择你要购买的商品，输入0为退出");
        }
    }
}
