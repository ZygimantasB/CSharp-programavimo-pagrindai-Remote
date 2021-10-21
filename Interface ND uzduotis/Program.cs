using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ND_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAttack> organisms = new List<IAttack>();
            organisms.Add(new Monster());
            organisms.Add(new Monster());
            organisms.Add(new Monster());
            organisms.Add(new Monster());
            organisms.Add(new Monster());
            organisms.Add(new Monster());
            organisms.Add(new Player());


            foreach (IAttack item in organisms)
            {
                item.Attack();
            }

            Console.ReadLine();
        }
        
        public interface IRead
        {
            string Read();
        }
        
        public interface IAttack
        {
            void Attack();
        }

        public class Monster : IAttack
        {
            public void Attack()
            {
                Console.WriteLine("Kandu");
            }
        }
        public class Player : IAttack
        {
            public void Attack ()
            {
                Console.WriteLine("Kertu is kalavijo");
            }
        }
            

    }
}
