using CCT.Horarios.DAL.Data;
using CCT.Horarios.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCT.Horarios.DAL.Entities
{
    public class CampusDAL
    {
        public int Insert(CampusDTO campusDTO)
        {

            using (var db = new Data.CCT())
            {
                var campus = new Campus();

                campus.nome = campusDTO.nome;
                campus.sigla = campusDTO.sigla;
                db.Campus.Add(campus);

                return db.SaveChanges();
            }

        }

        public int Update(CampusDTO campusDTO)
        {


            using (var db = new Data.CCT())
            {
                var campus = db.Campus.Single(x => x.id == campusDTO.id);

                campus.nome = campusDTO.nome;
                campus.sigla = campusDTO.sigla;

                return db.SaveChanges();
            }
        }

        public int Delete(int id)
        {

            using (var db = new Data.CCT())
            {
                var campus = db.Campus.Single(x => x.id == id);

                db.Campus.Remove(campus);

                return db.SaveChanges();

            }

        }

        public List<CampusDTO> List()
        {
            var campusDTO = new List<CampusDTO>();

            using (var db = new Data.CCT())
            {
                var campus = db.Campus.ToList();

                campusDTO = campus.ConvertAll<CampusDTO>(x =>
                {
                    return new CampusDTO
                    {
                        id = x.id,
                        nome = x.nome,
                        sigla = x.sigla
                    };
                });


            }
            return campusDTO;
        }

        public CampusDTO Get(int id)
        {
            CampusDTO campusDTO = new CampusDTO();


            using (var db = new Data.CCT())
            {
                var campus = db.Campus.Single(x => x.id == id);

                campusDTO.id = campus.id;
                campusDTO.nome = campus.nome;
                campusDTO.sigla = campus.sigla;

            }
            return campusDTO;
        }
    }
}
