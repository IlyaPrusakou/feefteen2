using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace feefteen2
{
    class game
    {
        public int size;
        public int zeroX;
        public int zeroY;
        public int position;
        public int[,] mas;



        public game(int Size)
        {
            if (Size < 2) { Size = 2; }
            if (Size > 5) { Size = 5; }
            size = Size;
            mas = new int[size, size];
        }

        public void Start()
        {
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    mas[x, y] = CoordToPosition(x, y) + 1;
                }
            }
            zeroX = size - 1;
            zeroY = size - 1;
            mas[zeroX, zeroY] = 0;
        }

        public int GetNumber(int position)
        {
            int x, y;
            PositionToCoord(position, out x, out y);
            if (x < 0 || x > size) { return 0; }
            if (y < 0 || y > size) { return 0; }
            return mas[x, y];
        }

        private int CoordToPosition(int x, int y)
        {
            return position = y * size + x;
        }

        private void PositionToCoord(int position, out int x, out int y)
        {
            x = position % size;
            y = position / size;
        }


    }
}
