using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace box_factory
{
    class Panel : IEquatable<Panel>, IComparable<Panel>
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Panel(int width, int height)
        {
            Width = width;
            Height = height;
        } 
        
        public bool Equals(Panel p)
        {
            return this.Width == p.Width && this.Height == p.Height;
        }

        public int CompareTo(Panel comparePanel)
        {            
            if (comparePanel == null)
                return 1;

            else
                return this.Height.CompareTo(comparePanel.Height);
        }
        
        public override string ToString()
        {
            return $"[{Width},{Height}]";
        }
    }

    class Box
    {
        public Panel First { get; }
        public Panel Second { get; }
        public Panel Third { get; }

        public Box(Panel first, Panel second, Panel third)
        {
            First = first;
            Second = second;
            Third = third;
        }

        public static List<Box> GetBoxes(List<Panel> panelsExist, int volume)
        {
            List<Box> boxes = new List<Box>();

            panelsExist.Sort();

            var grByHeight = panelsExist.GroupBy(p => p.Height).Select(y => y.First());            

            var areaList = grByHeight.Select(p => new { Area = volume / p.Height, p.Width, p.Height }).ToArray();
            
            var grByWidth = panelsExist.GroupBy(p => p.Width).Select(y => y.First());

            foreach (var item in areaList)
            {
                foreach (var aitem in grByWidth)
                {
                    int a = aitem.Width;

                    int b = item.Area / a;

                    if (a == item.Width)
                    {
                        Panel first = new Panel(a, b);
                        Panel second = new Panel(b, item.Height);
                        Panel third = new Panel(item.Width, item.Height);

                        if (panelsExist.Contains(first) && panelsExist.Contains(second) && panelsExist.Contains(third))
                        {
                            boxes.Add(new Box(first, second, third));

                            Console.WriteLine($"[{a},{b}] , [{b},{item.Height}], [{item.Width},{item.Height}] - {item}");
                        }
                    }
                }
            }
            return boxes;
        }

        public override string ToString()
        {
            return $"{First}, {Second}, {Third}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //[(2, 4), (2, 3), (1, 3), (2, 2), (3, 5), (1, 2), (3, 4), (1, 4), (2, 5)] 
            List<Panel> panelList = new List<Panel>()
            {
                new Panel(2,4),
                new Panel(2,3),
                new Panel(1,3),
                new Panel(2,2),
                new Panel(3,5),
                new Panel(1,2),
                new Panel(3,4),
                new Panel(1,4),
                new Panel(2,5)
            };

            int volume = 12;            

            List<Box> boxes = Box.GetBoxes(panelList,volume);

            Console.WriteLine("Boxes:");

            foreach (var item in boxes)            
                Console.WriteLine($"{item}");

            Console.ReadLine();
        }
    }
}
