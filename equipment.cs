using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitywork
{
    class equipment
    {
        
        
        string toushi;
        string yifu;
        string kuzi;
        string xiezi;
        string cangku_1 ;
        string cangku_2 ;
        public string Toushi
        {
            get { return toushi; }
            set { toushi = value; }
        }
        public string Yifu
        {
            get { return yifu; }
            set { yifu = value; }
        }
        public string Kuzi
        {
            get { return kuzi; }
            set { kuzi = value; }
        }
        public string Xiezi
        {
            get { return xiezi; }
            set { xiezi = value; }
        }
        public string Cangku_1
        {
            get { return cangku_1; }
            set { cangku_1 = value; }
        }
        public string Cangku_2
        {
            get { return cangku_2; }
            set { cangku_2 = value; }
        }
        public void chuangbei()
        {
            Console.WriteLine("1 头饰："+Toushi);
            Console.WriteLine("2 衣服："+Yifu);
            Console.WriteLine("3 裤子："+Kuzi);
            Console.WriteLine("4 鞋子："+Xiezi);

        } 
        public void cangku()
        {
            Console.WriteLine("仓库");
            Console.WriteLine("1："+Cangku_1+"2："+Cangku_2);
        }
        
        public void change()
        {
            int n, i;
            string x;
            Console.WriteLine("请输入要改变的的部位+仓库序号，0-0表示退出,要输入一个数然后回车，再输入另一个数！！！");
            n=Convert.ToInt32 (Console.ReadLine());
            i=Convert.ToInt32 (Console.ReadLine());
            while(n!=0&&i!=0)
            {
                 if(i==1&&n==1)
            {
                x=Cangku_1;
                Cangku_1 = Toushi;
                Toushi = x;
            }
            if (i == 2 && n == 1)
            {
                x = Cangku_1;
                Cangku_1 = Yifu;
                Yifu = x;
            }
            if (i == 3 && n == 1)
            {
                x = Cangku_1;
                Cangku_1 = Kuzi;
                Kuzi = x;
            }
            if (i == 4 && n == 1)
            {
                x = Cangku_1;
                Cangku_1 = Xiezi;
                Xiezi = x;
            }
            //***************************************
            if (i == 1 && n == 2)
            {
                x = Cangku_2;
                Cangku_2 = Toushi;
                Toushi = x;
            }
            if (i == 2 && n == 2)
            {
                x = Cangku_2;
                Cangku_2 = Yifu;
                Yifu = x;
            }
            if (i == 3 && n == 2)
            {
                x = Cangku_2;
                Cangku_2 = Kuzi;
                Kuzi = x;
            }
            if (i == 4 && n == 2)
            {
                x = Cangku_2;
                Cangku_2 = Xiezi;
                Xiezi = x;
            }
            Console.WriteLine("请输入要改变的的部位+仓库序号，0-0表示退出,要输入一个数然后回车，再输入另一个数！！！");
            n = Convert.ToInt32(Console.ReadLine());
            i = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("退出成功");

            
            

        }
       
    }
}
