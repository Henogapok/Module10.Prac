using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.Prac
{
    public class Team
    {
        private List<IWorker> workers = new List<IWorker>();

        public void AddWorker(IWorker worker)
        {
            workers.Add(worker);
        }

        public void StartBuilding(House house)
        {
            foreach (var worker in workers)
            {
                worker.Work(house);
            }
        }
    }
}
