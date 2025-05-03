using System.Diagnostics;
using System.Drawing;

public enum State
    {
        Idle,
        Move,
        Attack
    }
namespace Buoi6_1
{
    
    public class Character
    {
        public void Change(State state)
        {
            switch (state)
            {
                case State.Idle:
                    Console.WriteLine("Idle");
                    break;
                case State.Move:
                    Console.WriteLine("Move");
                    break;
            }
        }
    }

    internal class Program
    {
        //public static void Main(string[] args)
        //{
        //   Character player = new Character();
        //    player.Change(State.Idle);
        //}
        //static void Hien<T>(T x)
        //{
        //    Console.WriteLine(x);
        //}
        //public delegate void MyDeLangte();
        public delegate int MyDeLangte(int x,int y);

        public static int Cong (int x, int y)
        {
            return x + y;
        }
        public static int Tru (int x, int y)
        {
            return x - y;
        }

        public static void Hien0()
        {
            Console.WriteLine("Hien0");
        }
        
        public static void Hien1()
        {
            Console.WriteLine("Hien1");
        }
        public static void Hien2()
        {
            Console.WriteLine("Hien2");
        }

        public static void XXXX(Action action)
        {
            if (action == null)
            {
                return;
            }

            action();
        }

        public class Animal()
        {
            public virtual void In()
            {
                Console.WriteLine("0");
            }
        }

        public class Dog() : Animal
        {
            public override void In()
            {
                Console.WriteLine("1");
            }
        }

        public static void Main(string[] args)
        {
            //MyDeLangte myDeLangte = new MyDeLangte(Hien0);
            //MyDeLangte myDeLangte2 = new MyDeLangte(Hien1);
            //MyDeLangte myDeLangte3 = new MyDeLangte(Hien2);
            //Hien0();
            //Hien1();
            //Hien2();
            
            MyDeLangte del1 = new MyDeLangte(Cong);
            MyDeLangte del2 = new MyDeLangte(Tru);
            MyDeLangte del3 = del1 + del2;
            Console.WriteLine(del3(2, 1));

            Animal animal = new Dog();
            animal.In();
        }
    }
}