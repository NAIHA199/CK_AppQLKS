# HƯỚNG DẪN FORM QUẢN LÝ PHÒNG (UC_QUANLYP)

## Giới thiệu
Form **UC_QUANLYP** được tạo dựa trên cấu trúc của form Quản lý Loại Phòng, với các tính năng mở rộng để quản lý đầy đủ thông tin phòng.

## Các tính năng chính

### 1. **Nhập thông tin phòng**
- **Số Phòng**: Nhập mã/số phòng (ví dụ: 101, 102, ...)
- **Đơn Giá**: Nhập giá phòng (VND)
- **Loại Phòng**: Chọn loại phòng
  - Đơn (1 giường)
  - Đôi (2 giường)
  - Vip (Phòng cao cấp)
- **Trạng Thái**: Chọn tình trạng hiện tại của phòng
  - Trống (Phòng không có khách)
  - Đang Thuê (Phòng có khách đang ở)
  - Đang Dọn Dẹp (Phòng đang được vệ sinh)

### 2. **Xem trước giá tham khảo**
Panel "Tham khảo" hiển thị:
- Loại phòng và trạng thái đã chọn
- Giá tiền tương ứng (cập nhật real-time)

### 3. **Các nút chức năng**
- **+ Thêm**: Thêm phòng mới
  - Kiểm tra số phòng không được trùng
  - Kiểm tra đơn giá hợp lệ

- **Sửa**: Cập nhật thông tin phòng
  - Chọn phòng từ bảng dữ liệu
  - Chỉnh sửa thông tin
  - Nhấn "Sửa" để lưu

- **Xóa**: Xóa phòng
  - Chọn phòng từ bảng dữ liệu
  - Xác nhận trước khi xóa

- **↺ Mới**: Xóa sạch form, đặt lại giá trị mặc định

### 4. **Bảng dữ liệu**
Hiển thị danh sách tất cả phòng với các cột:
- **SỐ PHÒNG**: Mã phòng
- **LOẠI PHÒNG**: Loại phòng (Đơn/Đôi/Vip)
- **TRẠNG THÁI**: Tình trạng (Trống/Đang Thuê/Đang Dọn Dẹp)
- **ĐƠN GIÁ**: Giá phòng

**Tính năng**: Nhấp vào một hàng để tải thông tin phòng lên form

## Cách sử dụng từng chức năng

### Thêm phòng mới:
1. Nhập Số Phòng (vd: 101)
2. Nhập Đơn Giá (vd: 500000)
3. Chọn Loại Phòng (Đơn/Đôi/Vip)
4. Chọn Trạng Thái (Trống/Đang Thuê/Đang Dọn Dẹp)
5. Nhấn "+ Thêm"

### Sửa thông tin phòng:
1. Nhấp vào phòng trong bảng dữ liệu
2. Chỉnh sửa thông tin cần thiết
3. Nhấn "Sửa"

### Xóa phòng:
1. Nhấp vào phòng trong bảng dữ liệu
2. Nhấn "Xóa"
3. Xác nhận xóa

### Làm mới form:
1. Nhấn "↺ Mới" để xóa sạch tất cả dữ liệu đã nhập

## Lưu ý
- Dữ liệu hiện tại được lưu trữ tạm thời trong RAM
- Để lưu vĩnh viễn, cần kết nối với Database
- Số phòng không được trùng lặp
- Đơn giá phải > 0

## Tích hợp với Database
Để kết nối với Database, bạn cần:
1. Tạo các phương thức truy vấn trong `DataProvider.cs`
2. Gọi các phương thức này thay vì sử dụng `List<>` tạm thời
3. Cập nhật lại `LoadDataGridView()` và các hàm CRUD

## Cấu trúc dữ liệu
```csharp
private List<(
    string SoPhong,        // Mã phòng
    string LoaiPhong,      // Loại: Đơn/Đôi/Vip
    string TrangThai,      // Trạng thái: Trống/Đang Thuê/Đang Dọn Dẹp
    long DonGia            // Giá phòng
)> danhSach = new();
```
