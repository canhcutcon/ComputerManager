using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_ComputerManager
{
    public class DTO_Computer
    {
       private string idComputer, cpu, vga, hardisk,ram, moniter, idRoom;

        public DTO_Computer()
        {

        }

        public DTO_Computer(string idComputer, string cpu, string vga, string hardisk, string ram, string moniter, string idRoom)
        {
            this.idComputer = idComputer;
            this.cpu = cpu;
            this.vga = vga;
            this.hardisk = hardisk;
            this.ram = ram;
            this.moniter = moniter;
            this.idRoom = idRoom;
        }

        public string IdComputer { get => idComputer; set => idComputer = value; }
        public string Cpu { get => cpu; set => cpu = value; }
        public string Vga { get => vga; set => vga = value; }
        public string Hardisk { get => hardisk; set => hardisk = value; }
        public string Ram { get => ram; set => ram = value; }
        public string Moniter { get => moniter; set => moniter = value; }
        public string IdRoom { get => idRoom; set => idRoom = value; }
    }
}
