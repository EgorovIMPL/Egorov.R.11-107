using System;
namespace Egorov.R._11_107.HomeWork_22._12._2021
{
    public class PlaneDot
    {
        protected int x;
        protected int y;
        public PlaneDot(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return x.ToString() + " " + y.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj is PlaneDot)
            {
                var dot = obj as PlaneDot;
                if (x == dot.x && y == dot.y)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        public override int GetHashCode()
        {
            return 31 * x * y % 10;
        }
    }

    public class SpaceDot: PlaneDot
    {
        private int z;
        public SpaceDot(int x, int y, int z): base(x, y)
        {
            this.z = z;
        }
        public override string ToString()
        {
            return x.ToString() + " " + y.ToString() + " " + z.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj is SpaceDot)
            {
                var dot = obj as SpaceDot;
                if (x == dot.x && y == dot.y && z == dot.z)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        public override int GetHashCode()
        {
            return 31 * x * y * z % 10;
        }
    }
}