using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RouletteAPI.Data;
using System;
using System.Threading.Tasks;
using Table = RouletteAPI.Data.Table;

namespace RouletteAPI.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Table> Tables { get; }
        IGenericRepository<TableSection> TablesRepository { get;}
        IGenericRepository<Wheel> Wheels { get; }
        IGenericRepository<Spin> Spins { get; }
        IGenericRepository<Player> Players { get; }
        IGenericRepository<Bet> Bets { get; }
        IGenericRepository<PayOut> PayOuts { get; }

        Task Save();
    }
}
