
using HotelManagementSystemEmreAyhan.DataServices;
using HotelManagementSystemEmreAyhan.Models;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystemEmreAyhan.ViewModels
{
    class RoomsViewModel : BindableBase
    {
        private readonly IRoomService service;

        public List<Room> Rooms { get; set; }

        public RoomsViewModel(IRoomService service)
        {
            this.service = service;
            Rooms = new List<Room>();
            LoadRooms();
            

        }

        public async Task LoadRooms()
        {
            var rooms = await service.GetRooms();
            foreach (var room in rooms)
            {
                Rooms.Add(room);
               
            }
        }
    }
}
