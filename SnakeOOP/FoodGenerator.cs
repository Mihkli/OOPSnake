using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class FoodGenerator
    {
        int mapWidth;
        int mapHeight;
        char symb;
        Random rnd = new Random();

        public FoodGenerator(int _mapWidth, int _mapHeight, char _symb)
        {
            mapHeight = _mapHeight;
            mapWidth = _mapWidth;
            symb = _symb;
        }

        public point GenerateFood()
        {
            int x = rnd.Next(2, mapWidth - 2);
            int y = rnd.Next(2, mapWidth - 2);
            return new point(x, y, symb);
        }

    }
}
