namespace NewApp.Models
{
    public class Employee : Person
    {
        //khai bao them cac thuoc tinh
        public string EmployeeID { get; set; }
        //khai bao them cac phuong thuc
        public void NhapThongTin()
        {
            base.NhapThongTin();
            Console.WriteLine("Ma nhan vien = ");
            EmployeeID = Console.ReadLine();
        }
        public void HienThi()
        {
            base.HienThi();
            Console.WriteLine(" - ma nhan vien: " + EmployeeID);
        }
    }
}