using System;
using System.Diagnostics.CodeAnalysis;

namespace Baitap
{
    class Program
    {
        public static void Main(string[] args)
        {
            //------------------------------------bai 1
            //int a, sum = 0;                                        

            //Console.WriteLine($"Nhap so nguyen duong: ");
            // a = int.Parse(Console.ReadLine());

            //----------------------------dem tu 1 den n


            //if( a <= 0 )
            //{
            //    Console.WriteLine($"Con so khong hop le");
            //}    

            //else
            //{
            //    for (int i = 1; i <= a; i++)          
            //    {
            //        Console.WriteLine(i);
            //    }

            //----------------------tinh tong den n

            //for (int i = 1; i <= a; i++)          
            //{
            //    sum += i;
            //}
            //Console.WriteLine($"Tong: " + sum);

            //--------------------------tinh tong duong chan tu 1 den n

            //for (int i = 1; i <= a; i++)             
            //{
            //    if (i % 2 == 1)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        sum += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine($"Tong cac so chan: " + sum);

            //}

            //-------------------------------------bai 2

            //Console.WriteLine($"Nhap so (nhap 0 de tinh tong va so luong cac gia tri): ");
            // int a = int.Parse(Console.ReadLine());
            //int sum = 0;
            //int i = 0;
            //while (a != 0)
            //{
            //    i += a;
            //    Console.WriteLine($"Nhap so tiep theo: ");
            //    a = int.Parse(Console.ReadLine());
            //    sum++;
            //}
            //Console.WriteLine("Tong: " + i);
            //Console.WriteLine("So luong gia tri: " + sum);

            //--------------------------------------------bai 3

            //int a = 8;
            //int b = 10;
            //Console.WriteLine("Ta co so a=" + a);
            //Console.WriteLine("Ta co so b=" + b);
            //Console.WriteLine("========Menu=======");
            //Console.WriteLine("1.Tinh tong 2 so");
            //Console.WriteLine("2.Tinh hieu 2 so");
            //Console.WriteLine("3.Tinh tich 2 so");
            //Console.WriteLine("0.Thoat");
            //Console.WriteLine("===================");
            //int c;
            //do
            //{
            //    Console.WriteLine("Nhap Lua chon: ");
            //     c = int.Parse(Console.ReadLine());

            //    switch (c)
            //    {
            //        case 1:
            //            Console.WriteLine($"Tong: "+ (a + b));
            //            break;
            //        case 2:
            //            Console.WriteLine($"Hieu: " + (a - b));
            //            break;
            //        case 3:
            //            Console.WriteLine($"Tich: "+ (a * b));
            //            break;
            //        default:
            //            break;
            //    }

            //}
            //while (c != 0);

            //--------------------Bai4

            //for(int i = 1; i <= 50; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        continue;
            //    }
            //    else if (i % 7 ==0)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //-------------------------bai 5

            double a = 0;
            int sum = 0;
            double i = 0;
            while ( a != -1 )
            {
                Console.WriteLine($"Nhap diem tu 0 den 10 (nhap -1 de tinh diem trung binh): ");
                a = double.Parse(Console.ReadLine());

                if (a < 0)
                {
                    
                    Console.WriteLine($"Diem khong hop le, vui long nhap lai");
                    
                }
                else if (a > 10)
                {
                    
                    Console.WriteLine($"Diem khong hop le, vui long nhap lai");
                    
                }
                else
                {
                    Console.WriteLine($"Nhap diem tu 0 den 10 (nhap -1 de tinh diem trung binh): ");
                    a = double.Parse(Console.ReadLine());
                    sum++;
                    i += a;
                }
            }
            Console.WriteLine($"Diem trung tinh cac sinh vien: " + (i / sum));
        }
    }
}

