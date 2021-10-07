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

      
    }
}
