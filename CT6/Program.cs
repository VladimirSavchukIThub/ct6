using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT6
{
    class Test
    {
        static void Main(string[] args)
        {
            
            Factory f = new Factory();
            f.CreatePen(50);
            f.CreatePencile(50);
            f.ShowResources();
            f.ShowCost();
            Console.ReadLine();
            
            
        }
    }

    class Factory
    {
        int wood = 1000;
        int plastic = 1000;
        List<IForSale> saleList = new List<IForSale>();
        public void CreatePencile(int n)
        {
            for (var i = 0; i < n; i++)
            {
                Pencil pencil = new Pencil();
                saleList.Add(pencil);
                wood--;
            }

        }
        public void CreatePen(int n)
        {
            for (var i = 0; i < n; i++)
            {
                Pen pen = new Pen();
                saleList.Add(pen);
                plastic--;
            }

        }

        public void ShowResources()
        {
            Console.WriteLine("Кол-во дерева: " + wood);
            Console.WriteLine("Кол-во пластика: " + plastic);
        }
        
        public void ShowCost()
        {
            int m = 0;
            foreach (var el in saleList)
            {
                el.Sale();
                m+=el.Sale();
            }
            Console.WriteLine(m);
        }
    }

    interface IForSale
    {
        int Sale();
    }
    class Pencil: IForSale
    {
        public int Sale()
        {
            return 10;
        }
    }
    class Pen : IForSale
    {
        public int Sale()
        {
            Random rnd = new Random();
            int value = rnd.Next(3, 5);
            return value;
        }
    }

    
}
