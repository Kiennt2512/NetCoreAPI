using System;
namespace NewApp.Models
{
    // khai bao cac thuoc tinh
    public class Employee
    {
        public  string hoten {get; set;}
        public  string diachi {get; set;}
        public  int tuoi {get; set;}
    // khai bao cac phuong thuc 
        public void nhapthongtin()
        {
            System.Console.WriteLine("Ho ten = ");
            hoten = Console.ReadLine();
            System.Console.WriteLine("Dia chi = ");
            diachi = Console.ReadLine();
            System.Console.WriteLine("Tuoi = ");
            tuoi = Convert.ToInt32(Console.ReadLine());
        }
        public void hienthi()
        {
            System.Console.WriteLine("{0} - {1} - {2} tuoi", hoten, diachi, tuoi);
        }
    }
}