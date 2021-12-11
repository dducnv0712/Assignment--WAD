using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment_WAD.Models
{

    public class StudentLate
    {
        [DisplayName("#")]
        public int Id { get; set; }
        [DisplayName("Mã Sinh Viên")]
        [Required(ErrorMessage = "Vui Lòng Nhập Mã Sinh Viên")]
        public string rollNumber { get; set; }
        [DisplayName("Họ Và Tên")]
        [Required(ErrorMessage = "Vui Lòng Nhập Họ Tên")]
        public string fullName { get; set; }
        [Required(ErrorMessage = "Vui Lòng Chọn Phương Thức Đóng Phạt")]
        [DisplayName("Phương Thức Đóng Phạt")]
        public string Method { get; set; }
        [Required(ErrorMessage = "Vui Lòng Nhập Phương Thức Đóng Phạt")]
        [DisplayName("Nộp Phạt")]
        public string Fines { get; set; }
        [Required(ErrorMessage = "Vui Lòng Nhập Nguyên Nhân Đóng Phạt")]
        [DisplayName("Nguyên Nhân")]
        public string Cause { get; set; }
        private DateTime? dateCreated;
        [DisplayName("Ngày Nộp Phạt")]
        public DateTime Date
        {
            get { return dateCreated ?? DateTime.Now; }
            set { dateCreated = value; }
        }
    }
/*    public enum Fines
    {
        Monney,
        PushUp,
        Other
    }*/
}