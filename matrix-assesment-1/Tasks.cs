using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional2Tasks
{
    public static class Tasks
    {
        public static int[] Task(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int[] result = new int[cols];

            
            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    result[j] += array[i, j];
                }
            }

            return result;
        }
    }
}
