Project Đồ án Lập trình Winform C# Quản lý cửa hàng bán sách
Sử dụng Visual Studio 2019, SQL Server Management Studio 2008
Database nằm trong thư mục DatabaseSQL
Source code gồm các giao diện (form):
- ADMIN:
    + frmMain, các form quản lý nhân viên, khách hàng, phiếu nhập và chi tiết phiếu nhập, hóa đơn và chi tiết hóa đơn
    + form quản lý sách, thể loại, tác giả, nhà cung cấp
    + form thống kê số lượng nhập, bán theo từng mã sách
- THU NGÂN:
    + form tra cứu thông tin
    + form quản lý hóa đơn, khách hàng
Các chức năng gồm:
- Đăng nhập (sử dụng mô hình 3 lớp): kiểm tra tài khoản đăng nhập, phiên đăng nhập
- Đăng xuất
- Thêm, sửa, xóa, tìm kiếm theo từng form
- In hóa đơn, phiếu nhập (sử dụng Microsoft RDLC Report Designer, Microsoft reportviewercontrol)
- Thống kê
