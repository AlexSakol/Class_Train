
namespace Class_Train
{
    public class Program
    {
        static void Main(string[] args)
        {
            Train train1 = new Train();
            Train train2 = new Train("2");
            Train train3 = new Train("3", 25, "Minsk", new double[] { 2, 3, 2, 1, 5 });
            Train train4 = new Train("4", 20, "Gomel", new double[] { 2, 3, 7, 9, 4 });
            Console.WriteLine(train1.ToString());
            Console.WriteLine(train2.ToString());
            Console.WriteLine(train3.ToString());
            Console.WriteLine(train4.ToString());
            Console.WriteLine("Проверка мощности");
            Console.Write("1. ");
            if (train1.IsPowerfull(train1.Power, train1.Massa) == true) Console.WriteLine("Мощности достаточно");
            else Console.WriteLine("Мощности не достаточно");
            Console.Write("2. ");
            if (train2.IsPowerfull(train2.Power, train2.Massa) == true) Console.WriteLine("Мощности достаточно");
            else Console.WriteLine("Мощности не достаточно");
            Console.Write("3. ");
            if (train3.IsPowerfull(train3.Power, train3.Massa) == true) Console.WriteLine("Мощности достаточно");
            else Console.WriteLine("Мощности не достаточно");
            Console.Write("4. ");
            if (train1.IsPowerfull(train4.Power, train4.Massa) == true) Console.WriteLine("Мощности достаточно");
            else Console.WriteLine("Мощности не достаточно");
            Console.WriteLine("Тяжелейший из 2-х между 3-м и 4-м");
            if (train3.Heavier(train4) == true) Console.WriteLine("3 тяжелее 4");
            else Console.WriteLine("4 тяжелее 3");
            Console.WriteLine("Тяжелейший из 3-х");
            Console.WriteLine(Train.HeavierFrom3(train2, train3, train4));
            Console.WriteLine("\nДве переменные ссылаются на один объект:");
            Train train = new("5", 25, "Moskva", new double[] { 1, 2, 5, 1, 5 }); ;
            Console.WriteLine(train.ToString());
            Train trainNew = train;
            trainNew.Power = 14;
            Console.WriteLine(train.ToString());
        }
    }
}
