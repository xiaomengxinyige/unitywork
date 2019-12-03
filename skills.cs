using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitywork
{
    class skills
    {
        string skillname;
        int    skillpower;
        public string Skillname
        {
            get { return Skillname; }
            set { skillname = value; }
            
        }
        public int Skillpower
        {
            get { return Skillpower; }
            set { skillpower = value; }
        }
        public void skillshow()
        {
            Console.WriteLine("技能："+skillname+"\t"+"攻击"+skillpower);
        }
    }
}
