using System;
namespace NewApp.Models
{
    // khai bao cac thuoc tinh
    public class Employee
    {
        public  string quequan {get; set;}
        public  string hocvan {get; set;}
        public  int cccd {get; set;}
    // khai bao cac phuong thuc 
        public void nhapdulieu()
        {
            System.Console.WriteLine("Que Quan = ");
            quequan = Console.ReadLine();
            System.Console.WriteLine("Trinh do hoc van = ");
            hocvan = Console.ReadLine();
            System.Console.WriteLine("CCCD/CMT = ");
            cccd = Convert.ToInt32(Console.ReadLine());
        }
        public void hienthi()
        {
            System.Console.WriteLine("Que quan: {0} - Trinh do hoc van: {1} - So CCCD/CMT: {2} ", quequan, hocvan, cccd);
        }
    }
}