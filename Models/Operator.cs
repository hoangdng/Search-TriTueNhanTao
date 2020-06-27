using System;
namespace SearchDigits.Models
{
    public class Operator
    {
        /*  0: Up
            1: Down
            2: Left
            3: Right  */
        public int dir; // i = 0..3
        public Operator(int dir)
        {
            this.dir = dir;
        }
        public State Move(State state)
        {
            switch (dir)
            {
                case 0:
                    return Up(state);
                case 1:
                    return Down(state);
                case 2:
                    return Left(state);
                case 3:
                    return Right(state);
            }
            return null;
        }
        private State Up(State state)
        {
            Point pointZero = new Point().GetZeroPoint(state);
            int length = state.d.GetLength(0);
            if (pointZero.x < length - 1)
            {
                State newState = state.Clone();
                newState.d[pointZero.x, pointZero.y] = newState.d[pointZero.x + 1, pointZero.y];
                newState.d[pointZero.x + 1, pointZero.y] = 0;
                return newState;
            }
            return null;
        }
        private State Down(State state)
        {
            Point pointZero = new Point().GetZeroPoint(state);
            int length = state.d.GetLength(0);
            if (pointZero.x > 0)
            {
                State newState = state.Clone();
                newState.d[pointZero.x, pointZero.y] = newState.d[pointZero.x - 1, pointZero.y];
                newState.d[pointZero.x - 1, pointZero.y] = 0;
                return newState;
            }
            return null;
        }
        private State Left(State state)
        {
            Point pointZero = new Point().GetZeroPoint(state);
            int length = state.d.GetLength(0);
            if (pointZero.y > 0)
            {
                State newState = state.Clone();
                newState.d[pointZero.x, pointZero.y] = newState.d[pointZero.x, pointZero.y - 1];
                newState.d[pointZero.x, pointZero.y - 1] = 0;
                return newState;
            }
            return null;
        }
        private State Right(State state)
        {
            Point pointZero = new Point().GetZeroPoint(state);
            int length = state.d.GetLength(0);
            if (pointZero.y < length - 1)
            {
                State newState = state.Clone();
                newState.d[pointZero.x, pointZero.y] = newState.d[pointZero.x, pointZero.y + 1];
                newState.d[pointZero.x, pointZero.y + 1] = 0;
                return newState;
            }
            return null;
        }
    }
}
