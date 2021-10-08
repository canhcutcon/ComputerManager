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

        public List<DTO_Computer> getComputerByIDRoom(string idRoom)
        {
            var listCP = dt.computers.Select(p => p).OrderBy(p => p.idRoom.Equals(idRoom));

            List<DTO_Computer> lstComputer = new List<DTO_Computer>();
            foreach(computer cp in listCP)
            {
                DTO_Computer ncomputer = new DTO_Computer();
                ncomputer.IdComputer = cp.idComputer;
                ncomputer.Cpu = cp.cpu;
                ncomputer.Vga = cp.vga;
                ncomputer.Ram = cp.ram;
                ncomputer.Hardisk = cp.hardisk;
                ncomputer.Moniter = cp.monitor;
                ncomputer.IdRoom = cp.idRoom;
                lstComputer.Add(ncomputer);
            }
            return lstComputer;
        }

        public bool checkComputerExist(string id)
        {
            computer cp = dt.computers.Where(p => p.idComputer.Equals(id)).FirstOrDefault();
            if(cp != null)
            {
                return true;
            }
            return false;
        }

        public bool addComputer(DTO_Computer newComputer)
        {
            if(checkComputerExist(newComputer.IdComputer))
            {
                return false;
            }

            computer cp = new computer();
            cp.idComputer = newComputer.IdComputer;
            cp.cpu = newComputer.Cpu;
            cp.vga = newComputer.Vga;
            cp.ram = newComputer.Ram;
            cp.hardisk = newComputer.Hardisk;
            cp.monitor = newComputer.Moniter;
            cp.idRoom = newComputer.IdRoom;
            dt.computers.InsertOnSubmit(cp);
            dt.SubmitChanges();
            return true;
        }

        public bool deleteComputer(string idComputer)
        {
            computer cp = dt.computers.Where(p => p.idComputer.Equals(idComputer)).FirstOrDefault();
            if(cp != null)
            {
                dt.computers.DeleteOnSubmit(cp);
                dt.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool updateComputer(DTO_Computer ncomputer)
        {
            IQueryable<computer> cp = dt.computers.Where(p => p.idComputer.Equals(ncomputer.IdComputer));
            
            if( cp.Count() >= 0)
            {
                try
                {
                    cp.First().vga = ncomputer.Vga;
                    cp.First().cpu = ncomputer.Cpu;
                    cp.First().ram = ncomputer.Ram;
                    cp.First().hardisk = ncomputer.Hardisk;
                    cp.First().monitor = ncomputer.Moniter;
                    cp.First().idRoom = ncomputer.IdRoom;
                    dt.SubmitChanges();
                }
                catch
                {
                    return false;
                }
                return true;
            }
            return true;
        }
    }
}
