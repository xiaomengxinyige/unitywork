using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitywork
{
    class people
    {
        private string xingbie;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Xingbie
        {
            get { return xingbie; }
            set { xingbie = value; }
        }
       public void x()
        {
            int n;
            Console.WriteLine("请选择性别 1男  2女");
            Console.Write("请输入");
            n=Convert.ToInt32 (Console.ReadLine());
           switch(n)
           {
               case 1:this. xingbie="男";break;
               case 2: this.xingbie = "女"; break;
           }
           Console.WriteLine("你的性别为"+xingbie);

        }
        public void aa()
       {
           int n;
           Console.WriteLine("请输入你的名字");
           this.name = Console.ReadLine();
           Console.WriteLine("1确认 2重新输入");
           n = Convert.ToInt32(Console.ReadLine());
            if(n==1)
            Console.WriteLine("角色创建完成！");
            while(n!=1)
            {
               switch(n)
                 {
                  case 1: Console.WriteLine("角色创建完成！"); ; break;
                  case 2: Console.WriteLine("请输入名字");
                          this.name = Console.ReadLine();
                          break;
                 }
               Console.WriteLine("1确认 2重新输入");
             n = Convert.ToInt32(Console.ReadLine());
            }
         

       }
    }
}
