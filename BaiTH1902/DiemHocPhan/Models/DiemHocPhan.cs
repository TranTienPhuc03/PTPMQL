using System.ComponentModel.DataAnnotations;

namespace HocPhanApp.Models
{
    public class HocPhanModel
    {
        [Required(ErrorMessage = "Vui lòng nhập điểm A")]
        [Range(0, 10, ErrorMessage = "Điểm A phải từ 0 đến 10")]
        public float DiemA { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập điểm B")]
        [Range(0, 10, ErrorMessage = "Điểm B phải từ 0 đến 10")]
        public float DiemB { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập điểm C")]
        [Range(0, 10, ErrorMessage = "Điểm C phải từ 0 đến 10")]
        public float DiemC { get; set; }

        public float DiemHocPhan => (DiemA * 0.6f) + (DiemB * 0.3f) + (DiemC * 0.1f);
    }
}
