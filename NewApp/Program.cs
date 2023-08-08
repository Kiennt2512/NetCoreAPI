using System.Security.Cryptography.X509Certificates;
using NewApp.Models;
public class Program
{
    public static void Main(string[] args)
    {
        Person ps = new Person();
        ps.nhapdulieu();
        ps.hienthi();
        Employee emp = new Employee();
        emp.nhapdulieu();
        emp.hienthi();
    }
    
}

        
    