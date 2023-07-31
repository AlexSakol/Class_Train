
namespace Class_Train
{
    internal class Train
    {
        string? number;
        double power;
        string? destination;
        double[] massa = new double[5];

        public Train() : this("1")
        { }
        public Train(string number) : this(number, 1, "unknown", new double[] { 0, 0, 0, 0, 0 })
        { }
        public Train(string number, double power, string destination, double[] massa)
        {
            Number = number;
            Power = power;
            Destination = destination;
            Massa = massa;
        }

        public string Number { get; set; }
        public double Power
        {
            get => power;
            set
            {
                if (value < 0) power = 0;
                else power = value;
            }
        }
        public string Destination { get; set; }
        public double[] Massa
        {
            get => massa;
            set
            {
                for (int i = 0; i < massa.Length; i++) massa[i] = 0;
                for (int i = 0; i < value.Length && i < massa.Length; i++)
                {
                    if (value[i] < 0) massa[i] = 0;
                    else massa[i] = value[i];
                }
            }
        }

        public double FullMassa(params double[] massa)
        {
            double summa = 0;
            for (int i = 0; i < massa.Length; i++)
            {
                summa += massa[i];
            }
            return summa;
        }

        public bool IsPowerfull(double power, params double[] massa)
        {
            if (power >= FullMassa(massa)) return true;
            else return false;
        }

        public bool Heavier(Train other)
        {
            if (this.FullMassa() > other.FullMassa()) return true;
            else return false;
        }

        public static Train HeavierFrom3(Train train1, Train train2, Train train3)
        {
            if ((train1.FullMassa() > train2.FullMassa()) && (train1.FullMassa() > train3.FullMassa()))
            {
                return train1;
            }
            else if ((train2.FullMassa() > train1.FullMassa()) && (train2.FullMassa() > train3.FullMassa()))
            {
                return train2;
            }
            else return train3;
        }

        public override string? ToString()
        {
            return $"Номер {Number} мощность (макс. допустимая масса состава в т.) {Power} назначение {Destination} общая масса вагонов в т. {FullMassa(Massa)}";
        }
    }
}
