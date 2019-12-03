using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitywork
{
    class bossbig
    {
        string bigbossname;
        int bigbossattack;
        int bigbossblood;
        public string Bigbossname
        {
            get { return bigbossname; }
            set { bigbossname = value; }
        }
        public int Bigbossattack
        {
            get { return bigbossattack; }
            set { bigbossattack = value; }
        }
        public int Bigbossblood
        {
            get { return bigbossblood; }
            set { bigbossblood = value; }
        }
        public void bigbossshow()
        {
            Console.WriteLine("boss的名字是{0}，boss的血量是{1}，boss的攻击是{2}",Bigbossname,Bigbossblood,Bigbossattack);
            Console.WriteLine("大岳丸：我是海国统领，平安京我势在必得，我要把我失去的都要回来！\n");
        }
    }
}
