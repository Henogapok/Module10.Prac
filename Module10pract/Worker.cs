using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.Prac
{
    public class Worker : IWorker
    {
        private IPart part;

        public Worker(IPart part)
        {
            this.part = part;
        }

        public void Work(House house)
        {
           
                house.AddPart(part);
                Console.WriteLine($"Worker builds a {part.Name}.");
            
        }
    }
}
