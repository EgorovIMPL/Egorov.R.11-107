using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Egorov.R._11_107
{
   public class Triangle
   {
      public int Side1 { get; set; }
      public int Side2 { get; set; }
      public int Side3 { get; set; }
      /// <summary>
      /// Угол между Side1 и Side2
      /// </summary>
      public double Angle1 { get; set; }
      /// <summary>
      /// Угол между Side2 и Side3
      /// </summary>
      public double Angle2 { get; set; }
      /// <summary>
      /// Угол между Side3 и Side1
      /// </summary>
      public double Angle3 { get; set; }
      public Triangle(int s1, int s2, int s3, double a1, double a2)
      {
         if (a1 + a2 > 180 || a1 <= 0 || a2 <= 0)
         {
            Console.WriteLine("Ошибка. Углы должны быть больше 0 или сумма углов меньше 180");
         }
         else if (s1 + s2 <= s3 || s3 + s2 <= s1 || s1 + s3 <= s2)
         {
            Console.WriteLine("Ошибка. Соотношение сторон не соотвествует треугольнику");
         }
         else
         {
            Side1 = s1;
            Side2 = s2;
            Side3 = s3;
            Angle1 = a1;
            Angle2 = a2;
            Angle3 = 180 - a1 - a2;
         }
      }
      public int Perimetr()
      {
         return Side1 + Side2 + Side3;
      }
      public double Square()
      {
         double p = Perimetr() / 2;
         return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
      }
      public class RectangularTriangle : Triangle
      {
         public RectangularTriangle(int s1, int s2, int s3, int a2) : base(s1, s2, s3, 90, a2)
         {
            if (Side1 * Side1 + Side2 * Side2 != Side3 * Side3)
            {
               return;
            }
         }
         public double Square(double angle)
         {
            if (angle != 90)
            {
               Console.WriteLine("Ошибка. Угол должен быть 90");
               return 0;
            }
            else
               return Side1 * Side2 / 2;
         }
      }
      public class EarlyHipTriangle : Triangle
      {
         public double Height { get; set; }
         public EarlyHipTriangle(int s1, int s3, int a1) : base(s1, s1, s3, a1, 90 - a1 / 2)
         {
            Height = Math.Sqrt(Side1 * Side1 - Side3 * Side3 / 4);
         }
         public double Square(double height)
         {
            if (height != Height)
            {
               Console.WriteLine("Ошибка. Перепровь значение высоты");
               return 0;
            }
            else
            {
               return height * Side3 / 2;
            }
         }
      }
   }
}