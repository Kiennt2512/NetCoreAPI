using NewApp.Models;
namespace NewApp.Models
{
    public class Person
    {
        //khai bao cac thuoc tinh
        public string hoten {get; set;}
        public string diachi {get; set;}
        public int tuoi  {get; set;} 
        //khai bao cac phuong thuc
        public void nhapdulieu()
        {
            System.Console.WriteLine("Ho ten =");
            hoten = Console.ReadLine();
            System.Console.WriteLine("Dia chi =");
            diachi = Console.ReadLine();
            System.Console.Write("Tuoi = ");      
            tuoi = Convert.ToInt32(Console.ReadLine());
        }
        public void hienthi()
        {
            System.Console.WriteLine("{0} - {1} - {2} tuoi",hoten, diachi, tuoi);
        }

    }
}