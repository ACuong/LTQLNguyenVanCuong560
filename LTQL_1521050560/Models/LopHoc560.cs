using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTQL_1521050560.Models
{
    public class LopHoc560
    {
        [Key]
        [Display(Name = "Mã lớp")]
        public int MaLop { get; set; }

        [Display(Name = "Tên lớp")]
        public string TenLop { get; set; }

        public ICollection<NVCSinhVien560> NVCSinhVien560s { get; set; }
    }
}