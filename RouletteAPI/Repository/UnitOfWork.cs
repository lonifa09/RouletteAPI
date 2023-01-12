using RouletteAPI.Data;
using RouletteAPI.IRepository;
using System;
using System.Threading.Tasks;

namespace RouletteAPI.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;

        private IGenericRepository<Table> _tables;
        private IGenericRepository<TableSection> _tableSections;
        private IGenericRepository<Wheel> _wheels;
        private IGenericRepository<Spin> _spins;
        private IGenericRepository<Player> _players;
        private IGenericRepository<Bet> _bets;
        private IGenericRepository<PayOut> _payOuts;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        public IGenericRepository<Table> Tables => _tables ??= new GenericRepository<Table>(_context);

        public IGenericRepository<TableSection> TablesRepository => _tableSections ??= new GenericRepository<TableSection>(_context);

        public IGenericRepository<Wheel> Wheels => _wheels ??= new GenericRepository<Wheel>(_context);

        public IGenericRepository<Spin> Spins => _spins ??= new GenericRepository<Spin>(_context);

        public IGenericRepository<Player> Players => _players ??= new GenericRepository<Player>(_context);

        public IGenericRepository<Bet> Bets => _bets ??= new GenericRepository<Bet>(_context);

        public IGenericRepository<PayOut> PayOuts => _payOuts ??= new GenericRepository<PayOut>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
