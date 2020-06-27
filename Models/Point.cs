namespace SearchDigits.Models
{
    public class Point
    {
        public int x, y;
        public Point()
        {
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point GetZeroPoint(State s)
        {
            int length = s.d.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (s.d[i, j] == 0)
                        return new Point(i, j);
                }
            }
            return null;
        }
    }
}