using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace DAL
{
    public class BaseDAL<T> where T : class, new() //T 代表了想要使用这个类,必须给他传递范型进来,后面的where是强调我们的泛型
    {
        //1.实例化数据库的上下文 这个里面包含了我们对数据库的操作(增删改查)
        EFContext db = new EFContext();

        /// <summary>
        /// 新增方法
        /// </summary>
        /// <param name="entity">要新增的对象</param>
        /// <returns>受影响行数</returns>
        public int Add(T entity)
        {
            db.Entry<T>(entity).State = EntityState.Added;//告诉我们现在执行的状态是新增
            //保存上面的数据,并且得到受影响行数
            return db.SaveChanges();
        }

        public int Edit(T entity)
        {
            db.Entry<T>(entity).State = EntityState.Modified;
            return db.SaveChanges();
        }

        public int Delete(T entity)
        {
            db.Entry<T>(entity).State = EntityState.Deleted;
            return db.SaveChanges();
        }

        /// <summary>
        /// 全查询
        /// </summary>
        /// <returns></returns>
        public List<T> GetData()
        {
            return db.Set<T>().ToList();
        }

        public List<T> GetData(Expression<Func<T, bool>> whereLambda)
        {
            return db.Set<T>().Where(whereLambda).ToList();
        }

        public T GetData(int id)
        {
            return db.Set<T>().Find(id);
        }

        //public void Dispose()
        //{
        //    db.Dispose();
        //}
    }
}
