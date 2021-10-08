using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_ComputerManager;
using DAO_ComputerManager;

namespace BUS_ComputerManager
{
    public class BUS_Computer
    {
        DAL_Computer dbComputer;
        public BUS_Computer()
        {
            dbComputer = new DAL_Computer();
        }

        public List<DTO_Computer> getListComputer()
        {
            return dbComputer.getListComputer();
        }

        public DTO_Computer getListComputerByID(string ID)
        {
            return dbComputer.getComputerGroupByIDComputer(ID);
        }

        public List<DTO_Computer> getListComputerByIDRoom(string idRoom)
        {
            return dbComputer.getComputerByIDRoom(idRoom);
        }

        public bool addComputer(DTO_Computer ncomputer)
        {
            return dbComputer.addComputer(ncomputer);
        }

        public bool deleteComputer(string id)
        {
            return dbComputer.deleteComputer(id);
        }

        public bool updateComputer(DTO_Computer nComputer)
        {
            return dbComputer.updateComputer(nComputer);
        }
    }
}
