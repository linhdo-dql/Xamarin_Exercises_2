# CustomRenderer là công cụ giúp tùy biến điều khiển cho từng nền tảng.
## Cách sử dụng:
### B1. Tạo 1 lớp con kế thừa điều khiển gốc.
### B2. Ghi đè phương thức hiển thị điều khiển gốc và các logic của điều khiển bằng Phương thức OnElementChanged được sử dụng ở lớp dẫn xuất ở mỗi nền tảng.
### B3. Thêm thuộc tính ExportRenderer vào lớp trình kết xuất tùy chỉnh ở mỗi nền tảng để chỉ định rằng nó sẽ được sử dụng để hiển thị điều khiển Xamarin.Forms.
## Một số custom trong Demo này:
> Entry
 
> ContentPage

> Button

> MapPin

> ListView

> ViewCell

> WebView
