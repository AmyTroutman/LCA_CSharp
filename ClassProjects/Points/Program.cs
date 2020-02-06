using System;

namespace Points
{
    public class Point2D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public override String ToString()
        {
            return String.Format("({0}, {1})", X, Y);
        }

        public Point2D() : this(0, 0)
        { }



        public Point2D(int x, int y)
        {
            // your code here
            X = x;
            Y = y;
        }
        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Point2D p = (Point2D)obj;
                return (X == p.X) && (Y == p.Y);
            }
        }
        public override int GetHashCode()
        {
            return (X << 2) ^ Y;
        }
    }

    // your code here
    

    public class Point3D : Point2D
    {
        public Point3D() : this(0, 0, 0)
        { }

        public Point3D(int x, int y, int z) : base(x, y)
        {
            // your code here
            Z = z;
        }

        // your code here
        public int Z { get; set; }
        public override String ToString()
        {
            return String.Format("({0}, {1}, {2})", X, Y, Z);
        }
        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Point3D p = (Point3D)obj;
                return (X == p.X) && (Y == p.Y) && (Z ==p.Z);
            }
        }
        public override int GetHashCode()
        {
            return (base.GetHashCode() << 2) ^ Z;
        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            Point2D p1 = new Point2D();
            Point2D p2 = new Point2D(7, 5);
            Point2D p3 = new Point2D(-2, 4);
            Point2D p4 = new Point2D(7, 5);

            Console.WriteLine("p1 = {0}", p1);
            Console.WriteLine("p2 = {0}", p2);
            Console.WriteLine("p3 = {0}", p3);
            Console.WriteLine("p4 = {0}", p4);

            Console.WriteLine("p2 == p3? {0}", p2 == p3);
            Console.WriteLine("p2.Equals(p3)? {0}", p2.Equals(p3));
            Console.WriteLine("p2 == p4? {0}", p2 == p4);
            Console.WriteLine("p2.Equals(p4)? {0}", p2.Equals(p4));

            Console.WriteLine("========");

            Point3D p5 = new Point3D();
            Point3D p6 = new Point3D(7, 5, 12);
            Point3D p7 = new Point3D(-2, 4, -4);
            Point3D p8 = new Point3D(7, 5, 12);

            Console.WriteLine("p5 = {0}", p5);
            Console.WriteLine("p6 = {0}", p6);
            Console.WriteLine("p7 = {0}", p7);
            Console.WriteLine("p8 = {0}", p8);

            Console.WriteLine("p6 == p7? {0}", p6 == p7);
            Console.WriteLine("p6.Equals(p7)? {0}", p6.Equals(p7));
            Console.WriteLine("p6 == p8? {0}", p6 == p8);
            Console.WriteLine("p6.Equals(p8)? {0}", p6.Equals(p8));

            Console.WriteLine("========");
        }
    }
}
