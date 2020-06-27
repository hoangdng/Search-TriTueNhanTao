using System;
namespace SearchDigits.Models
{
    public class State
    {
        public State preState;
        public Operator preOp;
        public int[,] d = new int[3, 3];

        public State()
        {
            int length = d.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    d[i, j] = (i * 3 + j + 1) % 9;
                }
            }
        }
        public State Clone()
        {
            int length = d.GetLength(0);
            State clone = new State();
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    clone.d[i, j] = this.d[i, j];
                }
            }
            return clone;
        }
        public void Print()
        {
            int length = d.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(d[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------");
        }
        public string GetKey()
        {
            int length = d.GetLength(0);
            String key = "";
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    key += d[i, j];
                }
            }
            return key;
        }
    }
}