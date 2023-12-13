using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.Prac
{
    internal class Program
    {
        static void Main()
        {
            // Создаем объекты для дома, бригады и строителей
            House house = new House();
            Team team = new Team();

            // Добавляем строителей в бригаду
            team.AddWorker(new Worker(new Basement()));
            team.AddWorker(new Worker(new Wall()));
            team.AddWorker(new Worker(new Wall()));
            team.AddWorker(new Worker(new Wall()));
            team.AddWorker(new Worker(new Wall()));
            team.AddWorker(new Worker(new Door()));
            team.AddWorker(new Worker(new Window()));
            team.AddWorker(new Worker(new Window()));
            team.AddWorker(new Worker(new Window()));
            team.AddWorker(new Worker(new Window()));
            team.AddWorker(new Worker(new Roof()));

            // Добавляем бригадира в бригаду
            team.AddWorker(new TeamLeader());

            // Начинаем строительство
            team.StartBuilding(house);

            Console.WriteLine("Construction completed!");
        }
    }
    
}
