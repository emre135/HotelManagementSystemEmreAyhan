using HotelManagementSystemEmreAyhan.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystemEmreAyhan.DataServices
{
    class RoomService : IRoomService
    {
        private readonly DatabaseDbContext dbContext;

        public RoomService(DatabaseDbContext DbContext)
        {
            dbContext = DbContext;
        }

        public async Task<List<Room>> GetRooms()
        {
            return await dbContext.Rooms.ToListAsync();
        }
    }
}
