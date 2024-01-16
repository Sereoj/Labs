using System;

namespace lab_2
{
    class Program
    {
        public enum Figures
        {
            Romb,
            Circle,
            Rect
        }
        public struct Fdata
        {
            public int x0, y0; // координаты
            public int color; // цвет фигуры
            public Figures type; //тип фигуры
        }
        static void Main(string[] args)
        {
           var Figure =  new Fdata()
            {
                x0 = 1,
                y0 = 1,
                color = 0x2727FF,
                type = Figures.Romb
            };
            Console.WriteLine(Figure);
        }
    }
}
