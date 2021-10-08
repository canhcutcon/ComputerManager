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

        public bool addRoom(DTO_Room nRoom)
        {
            if (checkRoomExist(nRoom.IdRoom))
                return false;
            room db_room = new room();
            db_room.idRoom = nRoom.IdRoom;
            db_room.nameRoom = nRoom.NameRoom;
            db_room.building = nRoom.Building;
            db_room.floorR = nRoom.Floor;
            dt.rooms.InsertOnSubmit(db_room);
            dt.SubmitChanges();
            return true;
        }


        public bool deleteRoom(string id)
        {
            room db_room = dt.rooms.Where(p => p.idRoom.Equals(id)).FirstOrDefault();

            if(db_room != null)
            {
                dt.rooms.DeleteOnSubmit(db_room);
                dt.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool updateRoom(DTO_Room nRoom)
        {
            IQueryable<room> dbRoom = dt.rooms.Where(p => p.idRoom.Equals(nRoom.IdRoom));
            if(dbRoom.Count() >= 0)
            {
                try
                {
                    dbRoom.First().nameRoom = nRoom.NameRoom;
                    dbRoom.First().building = nRoom.Building;
                    dbRoom.First().floorR = nRoom.Floor;
                    dt.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
      
    }
}
