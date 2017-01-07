using CCT.Horarios.DAL.Entities;
using CCT.Horarios.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCT.Horarios.BLL.Entities
{
    public class CampusBLL
    {
        public int Insert(CampusDTO campusDTO)
        {
            return new CampusDAL().Insert(campusDTO);
        }

        public int Update(CampusDTO campusDTO)
        {
            return new CampusDAL().Update(campusDTO);
        }

        public int Delete(int id)
        {
            return new CampusDAL().Delete(id);
        }

        public List<CampusDTO> List()
        {
            return new CampusDAL().List();
        }

        public CampusDTO Get(int id)
        {
            return new CampusDAL().Get(id);
        }
    }
}
