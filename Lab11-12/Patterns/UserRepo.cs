using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11.Patterns
{
    class UserRepo : IRepository<User>
    {
        private ApplicationContext db;

        public UserRepo(ApplicationContext context)
        {
            this.db = context;
        }
        //done
        public void Create(User item)
        {
            db.user.Add(item);
        }
        //done
        public void Delete(int id)
        {
            var result = db.user.SingleOrDefault(u => u.ID == id);
            db.user.Remove(result);
        }
        public User GetItem(int id)
        {
            var result = db.user.SingleOrDefault(u => u.ID == id);
            return result;
        }
        //done
        public IEnumerable<User> GetItemList()
        {
            var users = db.user.ToList();
            return users;
        }
        //done
        public void Save()
        {
            db.SaveChanges();
        }
        //done
        public void Update(User item)
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
