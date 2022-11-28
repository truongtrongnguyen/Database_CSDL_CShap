namespace Scaffold_EntityFrameWork_B56_B57;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // Dùng để phát sinh code C# dựa vào một database đã có sẵn ta thực hiện lệnh:
        // dotnet ef dbcontext scaffold -o "Tên thư mục" -d "Chuỗi connect SQL" "Microsoft.EntityFrameWorkCore.SqlServer"
        // Vd: dotnet ef dbcontext scaffold -o "Models" -d "server=DESKTOP-OJA04UG\SQLEXPRESS; database=KinhDoanh; UID=sa;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true" "Microsoft.EntityFrameworkCore.SqlServer"
    }
}
