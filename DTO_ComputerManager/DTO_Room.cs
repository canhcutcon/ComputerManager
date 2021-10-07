using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_ComputerManager
{
     public class DTO_Room
    {
        private string idRoom, nameRoom, building;
        private int floor;

        public DTO_Room()
        {

        }

        public DTO_Room(string idRoom, string nameRoom, string building, int floor)
        {
            this.idRoom = idRoom;
            this.nameRoom = nameRoom;
            this.building = building;
            this.floor = floor;
        }

        public string IdRoom { get => idRoom; set => idRoom = value; }
        public string NameRoom { get => nameRoom; set => nameRoom = value; }
        public string Building { get => building; set => building = value; }
        public int Floor { get => floor; set => floor = value; }
    }
}
