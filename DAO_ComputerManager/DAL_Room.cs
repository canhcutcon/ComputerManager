using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_ComputerManager;
namespace DAO_ComputerManager
{
    public class DAL_Room
    {
        ComputerManagerDataContext dt;

        public DAL_Room()
        {
            dt = new ComputerManagerDataContext();
        }

        public List<DTO_Room> getListRoom()
        {
            var lst = dt.rooms.Select(p => p).OrderBy(p => p.idRoom);

            List<DTO_Room> lstRoom = new List<DTO_Room>();
            foreach(room i in lst)
            {
                DTO_Room room = new DTO_Room();
                room.IdRoom = i.idRoom;
                room.NameRoom = i.nameRoom;
                room.Building = i.building;
                room.Floor = i.floorR.Value;
            }
            return lstRoom;
        }

        public DTO_Room getRoomByID(string id)
        {
            room db_Room = dt.rooms.Where(p => p.idRoom.Equals(id)).FirstOrDefault();

            DTO_Room nRoom = new DTO_Room();
            nRoom.IdRoom = db_Room.idRoom;
            nRoom.NameRoom = db_Room.nameRoom;
            nRoom.Building = db_Room.building;
            nRoom.Floor = db_Room.floorR.Value;
            return nRoom;
        }

        public bool checkRoomExist(string id)
        {
            room db_Room = dt.rooms.Where(p => p.idRoom.Equals(id)).FirstOrDefault();
            if (db_Room != null)
                return true;

            return false;
        }    



      
    }
}
