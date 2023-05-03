using System.Drawing;
namespace PolessUp_Task_21
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Rectangle1 rect1 = new Rectangle1(-3, 0, 3, 4);
            
           
            Rectangle1 rect2 = new Rectangle1(0, -1, 9, 2);
            Rectangle1[] rectangle1s = {rect1, rect2};
            
            if ((rect1.X1 < rect2.X1 && rect1.Y1 < rect2.Y1 && rect1.X2 < rect2.X2 && rect1.Y2 < rect2.Y2) || (rect2.X1 < rect1.X1 && rect2.Y1 < rect2.Y1 && rect2.X2 < rect1.X2 && rect2.Y2 < rect2.Y2))
            {
                var res = rectangle1s.Sum(a => a.Area);
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Прямоугольники пересекаются");

            }


        }
    }
}
