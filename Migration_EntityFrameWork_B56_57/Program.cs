namespace Migration_Scaffold_in_EntityFrameWork_B56_57;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        /*
            Để tạo ra Migration thực hiện lệnh:
                 dotnet ef migrations add Tên_Migration     --> Tạo ra folder có 3 file .cs
            Để kiểm tra xem ta đang có migration nào thực hiện lệnh: 
                dotnet ef migrations list
                20221127231728_V0 (Pending)     --> Có chữ "Pending" nghĩa là nó Chưa được cập nhật lên DB
            Để xóa đi 1 migrations thì:
                dotnet ef migrations remove
            Để cập nhật một migrations lên server thì:
                dotnet ef database update || dotnet ef database update Tên_Migrations
            Để Xóa daatabase thì ta dùng:
                dotnet ef database drop -f
            Để lưu các câu truy vấn của migrations ra file script thì:
                dotnet ef migrations script
                dotnet ef migrations script -o TênFile
                dotnet ef migrations script migrations1 migrations2
        
            Khi ta tạo thêm V1 thì code trong V1 nó sẽ chứa thông tin thay đổi từ V0 sang V1
            Nếu như ta không có thay đổi gì thì khi tạo trong V1(Up, Down) nó sẽ không có code 
        */
    }
}
