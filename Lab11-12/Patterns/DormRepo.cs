using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11.Patterns
{
    class DormRepo : IRepository<Dormitory>
    {
        private ApplicationContext db;

        public DormRepo(ApplicationContext context)
        {
            this.db = context;
        }
        //done
        public void Create(Dormitory item)
        {
            db.dormitory.Add(item);
        }
        //done
        public void Delete(int id)
        {
            var result = db.dormitory.SingleOrDefault(u => u.ID == id);
            db.dormitory.Remove(result);
        }
        public Dormitory GetItem(int id)
        {
            var result = db.dormitory.SingleOrDefault(u => u.ID == id);
            return result;
        }
        //done
        public IEnumerable<Dormitory> GetItemList()
        {
            var users = db.dormitory.ToList();
            return users;
        }
        //done
        public void Save()
        {
            db.SaveChanges();
        }
        //done
        public void Update(Dormitory item)
        {
            Save();
        }
        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
