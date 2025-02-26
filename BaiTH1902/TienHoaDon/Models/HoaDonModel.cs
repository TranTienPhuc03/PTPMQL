using System.ComponentModel.DataAnnotations;

namespace HoaDonApp.Models
{
    public class HoaDonModel
    {
        [Required(ErrorMessage = "Vui lòng nhập số lượng")]
        [Range(1, int.MaxValue, ErrorMessage = "Số lượng phải lớn hơn 0")]
        public int SoLuong { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập đơn giá")]
        [Range(1, double.MaxValue, ErrorMessage = "Đơn giá phải lớn hơn 0")]
        public decimal DonGia { get; set; }

        public decimal ThanhTien => SoLuong * DonGia;
    }
}
