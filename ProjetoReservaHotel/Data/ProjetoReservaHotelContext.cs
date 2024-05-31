using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoReservaHotel.Models;

namespace ProjetoReservaHotel.Data
{
    public class ProjetoReservaHotelContext : DbContext
    {
        public ProjetoReservaHotelContext (DbContextOptions<ProjetoReservaHotelContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoReservaHotel.Models.Reserva> Reserva { get; set; } = default!;
    }
}
