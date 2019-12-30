using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        [Required]

        public DateTime Birthday { get; set; }

        [Required]
        [StringLength(4)]
        [Column(TypeName = "varchar")]
        public string Gender { get; set; }

        [Required]
        [StringLength(255)]
        [Column(TypeName = "varchar")]
        public string Tel { get; set; }

        [Required]
        [StringLength(255)]
        [Column(TypeName = "varchar")]
        public string Enmil { get; set; }

        //下面的为我们设定外键关系

        [ForeignKey(nameof(Grades))] //这个是用特性关联主键表
        public int GradesId { get; set; }//这个是外键列

        public Grades Grades { get; set; }//这个是代表指明外键关联表
        





    }
}