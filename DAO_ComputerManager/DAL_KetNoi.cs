using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_ComputerManager
{
    public class DAL_KetNoi
    {
        ComputerManagerDataContext dt;
        public ComputerManagerDataContext GetDataContext()
        {
            string str = @"Data Source=DESKTOP-50F1KAT;Initial Catalog=ComputerManagerment;Integrated Security=True";
            dt = new ComputerManagerDataContext(str);
            dt.Connection.Open();
            return dt;
        }
    }
}
