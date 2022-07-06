namespace Lab6
{
    class Program
    {
        static void Main(String[] args)
        {

            shape [] arrShapes = {new rectangle(), new triangle(), new circle(2,4,8)};
            int [] theAreas = {arrShapes[0].CalculateSurface(6,5), arrShapes[1].CalculateSurface(6,5), arrShapes[2].CalculateSurface(3,6)};
                int i = 0;
            foreach(int area in theAreas){               
                Console.WriteLine("The area of shape in index " + i + " is " + area);
                i++;
            }
        }
    }

         abstract class shape{
        public abstract int CalculateSurface(int width,int height);
    }

    class rectangle : shape{
        override public int CalculateSurface(int width, int height){
            return width * height;
        }
    }

    class triangle : shape{
        override public int CalculateSurface(int width, int height){
            return (width * height) / 2;
        }
    }

        abstract class circleArea{
                public abstract int CalcArea();
            }
        class circle : shape
        {
        private int width = 0;
        private int height = 0;
        private int radius = 0;

        public circle(int wth, int hht, int rad)
        {
            width = wth;
            height = hht;
            radius = rad;
        }

        override public int CalculateSurface(int width, int height)
        {
            return Convert.ToInt32(3.14 * (radius * radius));
        }
    }
}