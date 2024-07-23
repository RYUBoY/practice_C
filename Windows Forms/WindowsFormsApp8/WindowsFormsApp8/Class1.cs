using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8

{
    class Dog
    {
        public static string voice = "먼먼";
        public static string Vox() => voice;
        public void test()
        {
            voice = "가나다";
            Vox();
        }
        
    }
    public class Dog_check
    {
        private static int num;
        public static int Count
        {
            get { return num; }
        }
        public static int getNumber()
        {
            return num;
        }
        public Dog_check()
        {
            num++;
        }
        ~Dog_check() { num--; }
    }

    
    public class Weapon
    {
        
        public int attack_power;
        public int attack_speed;
        public Weapon()
        {
            attack_power = 1;
            attack_speed = 2;   
        }
        public void setCombatPoint(int a) => attack_power = a;
        public void setCombatPoint(int a, int b)
        {
            attack_power = a;
            attack_speed = b;
            
        }

        internal virtual string getinfo() => $"공격력은 {attack_power}, 공격속도는 {attack_speed} 입니다.\r\n";


    }

    public class Rifle : Weapon
    {   
        public Rifle()
        {
            bullet_count = 3;

        }
        
        protected int bullet_count;
        public int combatPoint() => attack_power * attack_speed * bullet_count;
        internal override string getinfo() => $"공격력은 {attack_power}, 공격속도는 {attack_speed}, 장탄수는 {bullet_count} 입니다.\r\n";
        public void setCombatPoint(int a, int b, int c)
        {
            attack_power = a;
            attack_speed = b;
            bullet_count = c;

        }
    }
    public class Knife : Weapon
    {
        public Knife()
        {
            knife_shape = 4;
        }
        
        protected int knife_shape;
        public int combatPoint() => attack_power * attack_speed * knife_shape;
        public void setCombatPoint(int a, int b, int c)
        {
            attack_power = a;
            attack_speed = b;
            knife_shape = c;

        }
        internal override string getinfo() => $"공격력은 {attack_power}, 공격속도는 {attack_speed}, 날카로움은 {knife_shape} 입니다.\r\n";
        
        
    }


}
