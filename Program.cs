using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitywork
{
    class Program
    {
        static void Main(string[] args)
        {
            //装备
            equipment c = new equipment();
            c.Toushi = "阴阳帽"; c.Yifu = "狩衣"; c.Kuzi = "长裤"; c.Xiezi = "靴子";
            c.Cangku_1 = "乌纱帽"; c.Cangku_2 = "官服";
            //技能
            skills skill_1 = new skills();
            skills skill_2 = new skills();
            skills skill_3 = new skills();
            skill_1.Skillname = "毒华爪    ";     skill_1.Skillpower = 85;
            skill_2.Skillname = "天生牙结界"; skill_2.Skillpower = 100;
            skill_3.Skillname = "冥道残月破"; skill_3.Skillpower = 200;
            //商店
            shop sh1 = new shop();
            shop sh2=new shop();
            shop sh3 = new shop();
            sh1.Shopname = "攻击御魂"; sh1.Price = 150; sh1.Add = 50;
            sh2.Shopname = "生命御魂"; sh2.Price = 100; sh2.Add = 40;
            sh3.Shopname = "防御御魂"; sh3.Price = 100; sh3.Add = 50;
            //bosslitter
            bosslitter boss = new bosslitter();
            boss.Bossname = "海鸣";
            boss.Bossblood = 1000;
            boss.Bossattack = 5;
            //角色状态
            zhuangtai att = new zhuangtai();
            att.Attack = 100; att.Blood = 100; att.Defence = 100; att.Money = 1000;
            //big boss
            bossbig big = new bossbig();
            big.Bigbossname = "大岳丸";
            big.Bigbossblood = 1000;
            big.Bigbossattack = 10;
            //剧情
            Console.WriteLine(@"                      阴阳师海国入侵
海上浪潮翻涌，异象频发。异动的海雾挟着浓重的压迫感，似要将整个平安京吞进腹中。
遥望海岸线上，只见巨大的黑影正在迫近。全新海国势力即将登场，前所未有的浩劫向着
平安京袭来。来自传说中的海上之地的统治者，以其绝对的强大，向平安京发出了征服的战书！
统治着海国的大岳丸率领来自铃鹿山的妖怪们，向平安京发出了宣战的通牒。面对着拥有压倒性
实力的大岳丸一行，平安京急需各位阴阳师的大力协助");

            //创建角色****************************
            Console.WriteLine();
            Console.WriteLine("创建角色");
            people a = new people();
             a.x();
             a.aa();            
           //界面*********************************
             jiemian b = new jiemian();
             b.shuchu();
            int n;
            n=Convert.ToInt32 (Console.ReadLine());
            while (n != 0)
            {
                switch (n)
                {    //装备*************************************************
                    case 1: Console.WriteLine("##########################################");
                        Console.WriteLine();
                        Console.WriteLine("角色装备");                        
                        c.chuangbei();
                        c.cangku();
                        c.change(); break;
                    //角色状态********************************************************
                    case 2: Console.WriteLine("######################################");
                        Console.WriteLine("角色状态");                    
                        att.show();
                        break;
                    //角色技能******************************************************
                    case 3: Console.WriteLine("#############################################");
                        Console.WriteLine("角色技能");
                        skill_1.skillshow(); skill_2.skillshow(); skill_3.skillshow();
                        break;
                    //商店***********************************
                    case 4: Console.WriteLine("##############################");                       
                        Console.WriteLine("商店");                       
                        Console.Write("商品1");
                        sh1.showshop();
                         Console.Write("商品2");
                        sh2.showshop();
                         Console.Write("商品3");
                        sh3.showshop();
                        sh3.showsell();
                        int shopselect;
                        shopselect = Convert.ToInt32(Console.ReadLine());
                        while(shopselect!=0)
                        {
                            switch(shopselect)
                            {
                                case 1: if (att.Money > 150)
                                    {
                                        att.Attack = att.Attack + 50; 
                                        att.Money = att.Money - 100;
                                        Console.WriteLine("                                       购买成功！！\n");
                                    }
                                    else Console.WriteLine("                                      金钱不足购买失败\n");
                                       break;
                                case 2: if (att.Money > 100)
                                        {
                                            att.Blood = att.Blood + 40;
                                            att.Money = att.Money - 100;
                                            Console.WriteLine("                                    购买成功！！\n");
                                        }
                                        else 
                                         Console.WriteLine("                                       金钱不足购买失败\n");
                                        break;
                                case 3: if (att.Money > 100)
                                    {
                                        att.Defence = att.Defence + 50; 
                                         att.Money = att.Money - 100;
                                         Console.WriteLine("                                       购买成功！！\n");
                                    }
                                        else Console.WriteLine("                                   金钱不足购买失败\n");
                                        break;
                            }
                            Console.Write("商品1");
                            sh1.showshop();
                            Console.Write("商品2");
                            sh2.showshop();
                            Console.Write("商品3");
                            sh3.showshop();
                            sh3.showsell();
                            shopselect = Convert.ToInt32(Console.ReadLine());
                        }

                        break;
                    //冒险模式*************************************
                    case 5: Console.WriteLine("########################################################################\n");                     
                        Console.WriteLine("冒险模式");                       
                        boss.showboss();
                        int peoplesk, bosssk = 0;
                        while (boss.Bossblood > 0)
                        {
                            Console.WriteLine("\t\t\t\t轮到你攻击boss");
                            Console.WriteLine("请选择技能");
                            Console.WriteLine("1 使用技能毒华爪，伤害85");
                            Console.WriteLine("2 使用技能天生牙结界，伤害100");
                            Console.WriteLine("3 使用技能冥道残月破，伤害200");
                            peoplesk = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            switch (peoplesk)
                            {
                                case 1: Console.WriteLine("\t\t\t\t你使用了毒华爪，**boss的血量减少为{0}**", boss.Bossblood - 85);
                                    bosssk++;  boss.Bossblood =  boss.Bossblood - 85; break;
                                case 2: Console.WriteLine("\t\t\t\t你使用了天生牙结界，**boss的血量减少为{0}**", boss.Bossblood - 100);
                                    bosssk++;  boss.Bossblood =  boss.Bossblood - 100; break;
                                case 3: Console.WriteLine("\t\t\t\t你使用了冥道残月破，**boss的血量减少为{0}**", boss.Bossblood - 200);
                                    bosssk++;  boss.Bossblood =  boss.Bossblood - 200; break;
                            }
                            if (bosssk > 3)
                                bosssk = 1;
                            Console.WriteLine("########################################################################\n");
                           
                            if (boss.Bossblood <= 0 && att.Blood > 0)
                            {
                                Console.WriteLine("\t\t\t\t恭喜你打败了海鸣保卫了平安京");
                                boss.Bossblood = -10;
                                break;
                            }
                            if (att.Blood < 0 && boss.Bossblood > 0)
                            {
                                Console.WriteLine("\t\t\t\t海鸣：你是阻止不了我们前进的步伐的，平安京将成为海国的领土，少主将成为传说");
                                boss.Bossblood = -10;
                                break;
                            } 
                            Console.WriteLine("\t\t\t\t轮到boss攻击了");
                            if (bosssk == 1)
                            {
                                Console.WriteLine("\t\t\t\t海鸣使用水龙卷!!!!，**你的血量减少为{0}", att.Blood-5);
                                att.Blood = att.Blood - 5;
                            }
                            if (bosssk == 2)
                            {
                                Console.WriteLine("\t\t\t\t海鸣使用巨浪!!!!，**你的血量减少为{0}", att.Blood - 5);
                                att.Blood = att.Blood - 5;
                            }
                            if (bosssk == 3)
                            {
                                Console.WriteLine("\t\t\t\t海鸣使用黄泉之水!!!!!!，***你的血量大减为{0}!!!!!", att.Blood - 25);
                                att.Blood = att.Blood - 25;
                            }
                            Console.WriteLine("#########################################################################\n");                       
                        }
                        boss.Bossblood = 1000;
                        att.Blood = 100;
                       break;
                    //BOSS战*****************************************
                    case 6: Console.WriteLine("\n");
                        Console.WriteLine("BOSS战");
                       
                        big.bigbossshow();
                        int bign = 0, people_n;

                        while (big.Bigbossblood > 0)
                        {
                            Console.WriteLine("#########################################################################\n");
                            Console.WriteLine("\t\t\t\t轮到你攻击boss");
                            Console.WriteLine("请选择技能");
                            Console.WriteLine("1 使用技能毒华爪，伤害85");
                            Console.WriteLine("2 使用技能天生牙结界，伤害100");
                            Console.WriteLine("3 使用技能冥道残月破，伤害200");
                            people_n = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            Console.WriteLine("#########################################################################\n");
                            switch (people_n)
                            {
                                case 1: Console.WriteLine("\t\t\t\t你使用了毒华爪，**boss的血量减少为{0}**", big.Bigbossblood - 85);
                                    bign++;big.Bigbossblood = big.Bigbossblood - 85; break;
                                case 2: Console.WriteLine("\t\t\t\t你使用了天生牙结界，**boss的血量减少为{0}**", big.Bigbossblood - 100);
                                    bign++; big.Bigbossblood = big.Bigbossblood - 100; break;
                                case 3: Console.WriteLine("\t\t\t\t你使用了冥道残月破，**boss的血量减少为{0}**", big.Bigbossblood - 200);
                                    bign++; big.Bigbossblood = big.Bigbossblood - 200; break;
                            }
                            if (big.Bigbossblood <= 0 && att.Blood > 0)
                            {

                                Console.WriteLine("\t\t\t\t恭喜你打败了大岳丸保卫了平安京\n");
                                big.Bigbossblood = -10;
                                break;
                            }
                            if (att.Blood < 0 && big.Bigbossblood > 0)
                            {
                                Console.WriteLine("\t\t\t\t大岳丸：你个不堪一击的垃圾，平安京我势在必得\n");
                                big.Bigbossblood = -10;
                                break;
                            }
                            if (bign > 2)
                                bign = 1;
                            Console.WriteLine("\n");
                            Console.WriteLine("#########################################################################\n");
                            Console.WriteLine("\t\t\t\t轮到boss攻击了");
                            if (bign == 1)
                            {
                                Console.WriteLine("\t\t\t\t大岳丸使用了麓鸣轰!!!!，**你的血量减少为{0}", att.Blood - 10);
                                att.Blood = att.Blood - 5;
                            }

                            if (bign == 2)
                            {
                                Console.WriteLine("\t\t\t大岳丸使用了麓鸣斩!!!!!!，***你的血量大减为{0}!!!!!", att.Blood - 25);
                                att.Blood = att.Blood - 25;
                            }
                            Console.WriteLine("#########################################################################\n");                           
                        }
                        big.Bigbossblood = 1000;
                        att.Blood = 100;
                        break;

                }
                b.shuchu();
                n = Convert.ToInt32(Console.ReadLine());
            }
 
            Console.ReadKey();
        }
    }
}
