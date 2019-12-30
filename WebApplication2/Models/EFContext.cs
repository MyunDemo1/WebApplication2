using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    /// <summary>
    /// 数据库上下文类,主要起到的就是关联到数据库并实现创建数据库的表
    /// </summary>
    public class EFContext : DbContext
    {
        //EF 框架 Code First
        /*
           安装框架:install-package EntityFramework
           数据封装:Grades(年级表)  Student(学生表)  Subject(课程表)  Resultsets(课程表)

           写数据库上下文
           三条命令创建数据文
         */



        public EFContext()
            :base("EFCon")
        {

        }

        public DbSet<Grades> Grades { get; set; }
        public DbSet<Student> Student { get; set; }

        public DbSet<Subject> Subjects { get; set; }

    }
}