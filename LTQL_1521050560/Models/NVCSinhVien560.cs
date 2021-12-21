using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTQL_1521050560.Models
{
    public class NVCSinhVien560
    {
        [Key]
        [Display(Name = "Mã Sinh Viên")]
        public string MaSinhVien { get; set; }

        [Display(Name = "Họ Tên")]
        public string HoTen { get; set; }

        public string MaLop { get; set; }

        public LopHoc560 LopHoc560 { get; set; }
    }
}