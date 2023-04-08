using System;
namespace Bai1 
{
    class Program
    {
        static void Main(string[] args)
        {

            //// Hàm số chẵn lẻ
            // int n = int.Parse(Console.ReadLine());
            // if (n % 2 == 0)
            // {
            //     Console.WriteLine("EVEN");

            // }
            // else
            //     Console.WriteLine("ODD");



            //int n = int.Parse(Console.ReadLine());

            //if (n > 0)
            //{
            //    Console.WriteLine("POSITIVE");
            //}
            //else if (n < 0) 
            //{
            //    Console.WriteLine("NEGATIVE");

            //}
            //else
            //{
            //    Console.WriteLine("UNSIGNED");
            //}    

            //Phương trình bậc 1
            //double a, b, x;
            //a = Convert.ToDouble(Console.ReadLine());
            //b = Convert.ToDouble(Console.ReadLine());

            //if (a == 0)
            //{
            //    if (b == 0)
            //        Console.WriteLine("PTVSN");
            //    else
            //        Console.WriteLine("PTVN");
            //}
            //else

            //    Console.WriteLine(-b / a);            

            //Phuong trình bậc 2
            //double a, b, c, x;
            //a= Convert.ToDouble(Console.ReadLine());

            //b= Convert.ToDouble(Console.ReadLine());
            //c= Convert.ToDouble(Console.ReadLine());

            //if (a == 0)
            //{
            //    if (b == 0)
            //    {
            //        if (c == 0)

            //            Console.WriteLine("ptvsn");
            //        else

            //            Console.WriteLine("ptvn");
            //    }
            //     else 

            //        Console.WriteLine(Math.Round(-c / ( b), 2));
            //}
            //else
            //{
            //    x = (b * b) - 4 * a * c;

            //    if ( x<0)
            //    {
            //        Console.WriteLine("ptVN");

            //    }   
            //    else if (x==0)
            //    {
            //        Console.WriteLine("pt co nghiem kep : "+ Math.Round(-b / (2 * a), 2));
            //    } 
            //    else
            //    {
            //        Console.WriteLine("x1 = " + Math.Round(( -b + Math.Sqrt(x))/(2*a)),2);
            //        Console.WriteLine("x2 = " + Math.Round((-b - Math.Sqrt(x)) / (2 * a)),2);
            //    }    
            //}    


            //// Kiểm tra tam giac
            //int a, b, c;
            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());
            //c = int.Parse(Console.ReadLine());

            //if (a <0 || b <0 || c <0)
            //{
            //    Console.WriteLine("Nhap sai");
            //}
            //else
            //{

            //    if (a + b > c && b + c > a && c + a > c)
            //    {
            //        if (a * a == (b * b + c * c) || b * b == (c * c + a * a) || c * c == (a * a + b * b))
            //        {
            //            Console.WriteLine("tam giac vuong");
            //        }
            //        else
            //            Console.WriteLine("là tam giác thường");
            //    }

            //    else
            //        Console.WriteLine("Ko là tam giác");

            //}

            double n;
            n = Convert.ToDouble(Console.ReadLine());

            if (n < 0 || n > 10)
                Console.WriteLine("Nhap sai");
            else
            {
                if (n >= 9.0) { Console.WriteLine("A"); }
                else if (n >= 7.0 && n< 9.0) { Console.WriteLine("B"); }
                else if (n >= 5.0 && n < 7.0) { Console.WriteLine("C"); }
                else if (n >= 4.0 && n < 5.0) { Console.WriteLine("D"); }
                else { Console.WriteLine("F"); }
            }


        }
    }


}
