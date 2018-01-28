using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] twoDim = new int[3, 3];
            int[,,] threeDim = new int[3, 3, 3];

            int[][][] threeDimjaged = new int[3][][];
            threeDimjaged[0] = new int[3][];
            threeDimjaged[0][0] = new int[3];
        }
    }
}
