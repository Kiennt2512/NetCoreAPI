using System.Collections;

namespace NewApp.Models
{
    public class Person
    {
        //khai bao cac thuoc tinh
        public string HoTen { get; set; }
        public string DiaChi { get; set;}
        public int NamSinh { get; set; }
        //xay dung cac phuong thuc
        //Phuong thuc Nhap thong tin nhan vien
        public void NhapThongTin()
        {
            Console.WriteLine("Ho ten = ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Dia chi = ");
            DiaChi = Console.ReadLine();
            Console.WriteLine("Nam Sinh = ");
            NamSinh = Convert.ToInt16(Console.ReadLine());
        }
        public void HienThi()
        {
            Console.Write("Công dân: " + HoTen);
            Console.Write(" - Sinh năm " + NamSinh);
            Console.Write(" - Quê quán " + DiaChi);
        }
        public void Add(ArrayList psList)
        {
            Person ps = new Person();
            ps.NhapThongTin();
            psList.Add(ps);
        }
        public void DisPlay(ArrayList psList)
        {
            foreach (Person p in psList)
            {
                p.HienThi();
            }
        }
    }
}