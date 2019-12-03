using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitywork
{
    class zhuangtai
    {
        int attack;
        int defence;
        int blood;
        int money;
        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }
        public int Defence
        {
            get { return defence; }
            set { defence = value; }
        }
        public int Blood
        {
            get { return blood; }
            set { blood = value; }
        }
        public int Money
        {
            get { return money; }
            set { money = value; }
        }
        public void show()
        {
            Console.WriteLine("角色攻击："+Attack);
            Console.WriteLine("角色防御：" + Defence);
            Console.WriteLine("角色血量：" + Blood);
            Console.WriteLine("角色金钱：" + Money);
        }
    }
}
