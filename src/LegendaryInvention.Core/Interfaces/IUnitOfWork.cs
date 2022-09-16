using System;
using System.Threading.Tasks;

namespace LegendaryInvention.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> Commit();
    }
}
