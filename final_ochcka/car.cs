using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace final_ochcka
{
    struct CoordinatRacer
    {
        public int x;
        public int y;
    }

    class car
    {
        static int width = 20, height = 20;
        public List<CoordinatRacer> coordinatSnakes = new List<CoordinatRacer>();
        public char Navigation = 'L';
        public char WantNavigation = 'N';
        public car()
        {
            coordinatSnakes.Add(new CoordinatRacer() { x = width / 2, y = height / 2 });
            coordinatSnakes.Add(new CoordinatRacer() { x = width / 2 + 1, y = height / 2 });
        }
        public void Move()
        {
            if (WantNavigation != 'N')
            {
                if (WantNavigation == 'L' && Navigation != 'R') Navigation = WantNavigation;
                if (WantNavigation == 'R' && Navigation != 'L') Navigation = WantNavigation;
                if (WantNavigation == 'T' && Navigation != 'D') Navigation = WantNavigation;
                if (WantNavigation == 'D' && Navigation != 'T') Navigation = WantNavigation;
            }
            switch (Navigation)
            {
                case 'L':
                    {
                        var temp = coordinatSnakes[0];
                        temp.x--;
                        coordinatSnakes[0] = temp;
                        break;
                    }
                case 'R':
                    {
                        var temp = coordinatSnakes[0];
                        temp.x++;
                        coordinatSnakes[0] = temp;
                        break;
                    }
                case 'T':
                    {
                        var temp = coordinatSnakes[0];
                        temp.y--;
                        coordinatSnakes[0] = temp;
                        break;
                    }
                case 'D':
                    {
                        var temp = coordinatSnakes[0];
                        temp.y++;
                        coordinatSnakes[0] = temp;
                        break;
                    }
            }
        }
    }
}
