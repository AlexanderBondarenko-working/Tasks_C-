using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2_2
{
    class SquareMatrix
    {
        private int[] diagonal;
        public int Size => diagonal.Length;

        public SquareMatrix(params int[] elements)
        {
            if (elements != null)
            {
                diagonal = new int[elements.Length];
                for (int i = 0; i < diagonal.Length; i++)
                {
                    diagonal[i] = elements[i];
                }
            }
            else
            {
                diagonal = new int[0];
            }
        }

        public int this[int i, int j]
        {
            get
            {
                if((i < diagonal.Length) && (j < diagonal.Length))
                {
                    if(i == j)
                    {
                        return diagonal[i];
                    }
                    return 0;
                }
                return 0;
            }
            set
            {
                if ((i < diagonal.Length) && (j < diagonal.Length) && (i == j))
                {
                    diagonal[i] = value;
                }
            }
        }

        public int Track()
        {
            int sum = 0;
            foreach(var element in diagonal)
            {
                sum += element;
            }
            return sum;
        }
        
        public string MatrixTostring()
        {
            string result = "";
            for(int i = 0; i < diagonal.Length; i++)
            {
                for(int j = 0; j < diagonal.Length; j++)
                {
                    if(i == j)
                    {
                        result += diagonal[i].ToString();
                    }
                    else
                    {
                        result += "0";
                    }
                }
                result += '\n';
            }
            return result;
        }

        public SquareMatrix Add(SquareMatrix matrix)
        {
            int[] newDiagonal = new int[Math.Max(this.Size, matrix.Size)];
            for (int i = 0; i < Math.Min(this.Size, matrix.Size); i++)
            {
                newDiagonal[i] = this.diagonal[i] + matrix[i, i];
            }
            if(this.Size > matrix.Size)
            {
                for(int i = matrix.Size; i < this.Size; i++)
                {
                    newDiagonal[i] = this.diagonal[i];
                }
            }
            else if(this.Size < matrix.Size)
            {
                for (int i = this.Size; i < matrix.Size; i++)
                {
                    newDiagonal[i] = matrix[i,i];
                }
            }
            SquareMatrix result = new SquareMatrix(newDiagonal);
            return result;
        }
    }
}
