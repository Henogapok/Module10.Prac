using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.Prac
{
    public class TeamLeader : IWorker
    {
        public void Work(House house)
        {
            // Бригадир формирует отчет о построенных частях
            house.ShowParts();
        }
    }

}
