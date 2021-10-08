using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_ComputerManager;
using DAO_ComputerManager;

namespace BUS_ComputerManager
{
    public class BUS_Room
    {
        DAL_Room dbRoom;
        public BUS_Room()
        {
            dbRoom = new DAL_Room();
        }

        public List<DTO_Room> getListRoom()
        {
            return dbRoom.getListRoom();
        }

        public DTO_Room getRoomByID(string id)
        {
            return dbRoom.getRoomByID(id);
        }

        public bool addRoom(DTO_Room nRoom)
        {
            return dbRoom.addRoom(nRoom);
        }

        public bool deleteRoom(string id)
        {
            return dbRoom.deleteRoom(id);
        }

        public bool updateRoom(DTO_Room nRoom)
        {
            return dbRoom.updateRoom(nRoom);
        }

    }
}
