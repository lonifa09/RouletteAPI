using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RouletteAPI.Data;
using RouletteAPI.Models;
using Table = RouletteAPI.Data.Table;

namespace RouletteAPI.Configurations
{
    public class MapperInitializer : Profile
    {
        public MapperInitializer()
        {
            CreateMap<Table, TableDTO>().ReverseMap();
            CreateMap<Table, CreateTableDTO>().ReverseMap();
            CreateMap<TableSection, TableSectionDTO>().ReverseMap();
            CreateMap<TableSection, CreateTableSectionDTO>().ReverseMap();
            CreateMap<Wheel, WheelDTO>().ReverseMap();
            CreateMap<Wheel, CreateWheelDTO>().ReverseMap();
            CreateMap<Wheel, CreateWheelDTO>().ReverseMap();
            CreateMap<Player, PlayerDTO>().ReverseMap();
            CreateMap<Player, CreatePlayerDTO>().ReverseMap();
            CreateMap<Bet, BetDTO>().ReverseMap();
            CreateMap<Bet, CreateBetDTO>().ReverseMap();
            CreateMap<Spin, SpinDTO>().ReverseMap();
            CreateMap<Spin, CreateSpinDTO>().ReverseMap();
            CreateMap<PayOut, PayOutDTO>().ReverseMap();
            CreateMap<PayOut, CreatePayOutDTO>().ReverseMap();
        }
    }
}
