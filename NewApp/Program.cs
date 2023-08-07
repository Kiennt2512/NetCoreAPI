using System.Security.AccessControl;
internal class Program 
{
    private static void Main(string[] args)
    {
        string str = "123"; // giá trị đầu vào để chuyển đổi
        int ketqua; // biến lưu kết quả sau chuyển đổi
        bool kiemtra = false // biến kiểm tra chuyển đổi có thành công không
        kiemtra = int.TryParse(str,out(ketqua));
        SystemAcl.Console.WriteLine("Ket Qua = " + ketqua);
    }
}