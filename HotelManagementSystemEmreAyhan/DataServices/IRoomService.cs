using HotelManagementSystemEmreAyhan.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotelManagementSystemEmreAyhan.DataServices
{
    interface IRoomService
    {
        Task<List<Room>> GetRooms();
    }
}