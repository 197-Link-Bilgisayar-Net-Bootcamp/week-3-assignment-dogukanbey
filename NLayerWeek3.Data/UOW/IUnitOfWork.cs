using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerWeek3.Data.UOW
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        void Commit();
         void Dispose();
    }
}
