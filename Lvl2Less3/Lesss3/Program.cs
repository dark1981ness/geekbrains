using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesss3
{
    class Program
    {

        class Source
        {
            public event Action<Source> Run;

            public void Start()
            {
                Console.WriteLine("RUN");
                Run?.Invoke(this);
            }
        }
        class Observer1 // Наблюдатель 1
        {
            public void Do(object o)
            {
                Console.WriteLine("Первый. Принял, что объект {0} побежал", o);
            }
        }
        class Observer2 // Наблюдатель 2
        {
            public void Do(object o)
            {
                Console.WriteLine("Второй. Принял, что объект {0} побежал", o);
            }
        }

        static void Main(string[] args)
        {
            Source s = new Source();
            Action<Source> o1 = new Observer1().Do;
            Action<Source> o2 = new Observer2().Do;
            s.Run += o1;
            s.Run += o2;
            s.Start();
            s.Run -= o1;
            s.Start();
        }

       
    }
}
