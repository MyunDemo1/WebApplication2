using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //特性的导包
using System.ComponentModel.DataAnnotations.Schema; // 专门用于设定列专有特特性的
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Grades
    {
        [Key]
        [Display(Name = "班级编号")]
        public int Id { get; set; }

        [Required] //唯一约束
        [StringLength(255)]
        [Column(TypeName = "varchar")]
        [Display(Name = "班级名称")]
        public string Title { get; set; }



    }
}