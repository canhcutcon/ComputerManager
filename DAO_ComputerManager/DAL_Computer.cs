using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_ComputerManager;

namespace DAO_ComputerManager
{
    public class DAL_Computer
    {
        ComputerManagerDataContext dt;

        public DAL_Computer()
        {
            dt = new ComputerManagerDataContext();
        }

        public List<DTO_Computer> getListComputer()
        {
            var lstCom = dt.computers.Select(p => p).GroupBy(p => p.idComputer);

            List<DTO_Computer> lstComputer = new List<DTO_Computer>();

            foreach(computer i in lstCom )
            {
                DTO_Computer cp = new DTO_Computer();
                cp.IdComputer = i.idComputer;
                cp.Cpu = i.cpu;
                cp.Vga = i.vga;
                cp.Ram = i.ram;
                cp.Moniter = i.monitor;
                cp.IdRoom = i.idRoom;
                lstComputer.Add(cp);
            }
            return lstComputer;
        }

        public DTO_Computer getComputerGroupByIDComputer(string idComputer)
        {
            computer cp = dt.computers.Where(p => p.idComputer.Equals(idComputer)).FirstOrDefault();

            DTO_Computer newComputer = new DTO_Computer();
            newComputer.IdComputer = cp.idComputer;
            newComputer.Cpu = cp.cpu;
            newComputer.Vga = cp.vga;
            newComputer.Ram = cp.ram;
            newComputer.Hardisk = cp.hardisk;
            newComputer.Moniter = cp.monitor;
            newComputer.IdRoom = cp.idRoom;
            return newComputer;
        }
    }
}
