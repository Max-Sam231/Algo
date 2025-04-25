//2. Идут гонки лощадей. 
// Каждый объект характеризуется начальным положением и именем лошади
// (начальное положение, если по оси x, то оно одинаковое, так как старт один). 
// В каждый момент времени за счет рандомного изменения скорости положение лошади меняется. 
// Есть значение положения финиша. Обработать события победы одной из лошадей.

internal class Program
{
    public class Horse
    {
        public int Position { get; set; }
        public string Name { get; set; }
        public Horse(string name, int position)
        {
            Name = name;
            Position = position;
        }
        public delegate void RaceFinishedHandler(string winnerName);
        public event RaceFinishedHandler onFinish;

        public void Move()
        {
            Random random = new Random();
            int step = random.Next(5, 21);
            Position += step;
            Console.WriteLine($"{Name} дистанция: {Position}");
            if (Position >= 100)
            {
                onFinish(Name);
            }
        }
    }


    public class RaceFinished
    {
        public void Message(string name)
        {
            Console.WriteLine($"Победила {name}");
        }
    }

    static void Main(string[] args)
    {
        var horses = new List<Horse>
        {
            new Horse("DDD", 0),
            new Horse("FFF", 0),
            new Horse("GGG", 0)
        };
        RaceFinished finished = new RaceFinished();

        foreach (Horse horse in horses)
        {
            horse.onFinish += finished.Message;
        }

        bool raceEnded = false;
        while (!raceEnded)
        {
            foreach (var horse in horses)
            {
                horse.Move();
            }

            foreach (var horse in horses)
            {
                if (horse.Position >= 100)
                {
                    raceEnded = true;
                    break;
                }
            }
            Thread.Sleep(500);
        }
    }


}

