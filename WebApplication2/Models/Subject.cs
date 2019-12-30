using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }

        [Required] 
        [StringLength(255)]
        [Column(TypeName = "varchar")]
        public string Title { get; set; }

    }
}