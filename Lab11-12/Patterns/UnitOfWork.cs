using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11.Patterns
{
    class UnitOfWork : IDisposable
    {
        private ApplicationContext db = new ApplicationContext();

        private UserRepo usersRepository;

        private DormRepo dormRepository;

        public UserRepo Users
        {
            get
            {
                if (usersRepository == null)
                    usersRepository = new UserRepo(db);
                return usersRepository;
            }
        }
        public DormRepo dormitories
        {
            get
            {
                if (dormRepository == null)
                    dormRepository = new DormRepo(db);
                return dormRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
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
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
