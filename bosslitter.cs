using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitywork
{
    class bosslitter
    {
        string bossname;
        int bossblood;
        int bossattack;
        public string Bossname
        {
            get { return bossname; }
            set { bossname = value; }
        }
        public int Bossblood
        {
            get { return bossblood; }
            set { bossblood = value; }
        }
        public int Bossattack
        {
            get { return bossattack; }
            set { bossattack = value; }
        }
        public void showboss()
        {
            Console.WriteLine("boss的名字是{0}，boss的血量是{1}，boss的攻击是{2}",Bossname,Bossblood,Bossattack);
            Console.WriteLine("海鸣：我是海国少主的老师，少主将成为新的传说，我的愿景也会在不远的未来实现，谁都无法阻止我\n");
        }
    

    }
}
