using CCT.Horarios.BLL.Entities;
using CCT.Horarios.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CCT.Horarios.API.Controllers
{
        public class CampusController : ApiController
        {
            [HttpPost]
            [Route("Campus", Name = "CampusInsert")]
            public HttpResponseMessage Insert(CampusDTO campus)
            {

                var ret = new CampusBLL().Insert(campus);

                HttpResponseMessage response;

                if (ret == 1)
                {
                    response = Request.CreateResponse(HttpStatusCode.Created, ret);
                }
                else
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, ret);
                }
                return response;
            }

            [HttpGet]
            [Route("Campus", Name = "CampusList")]
            public HttpResponseMessage List()
            {

                var ret = new CampusBLL().List();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, ret);
                return response;
            }

            [HttpGet]
            [Route("Campus/{id}", Name = "CampusGet")]
            public HttpResponseMessage Get(int id)
            {

                var ret = new CampusBLL().Get(id);

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, ret);
                return response;
            }


            [HttpPut]
            [Route("Campus", Name = "CampusUpdate")]
            public HttpResponseMessage Update(CampusDTO campus)
            {

                var ret = new CampusBLL().Update(campus);

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, ret);
                return response;
            }


            [HttpDelete]
            [Route("Campus/{id}", Name = "CampusDelete")]
            public HttpResponseMessage Delete(int id)
            {

                var ret = new CampusBLL().Delete(id);

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, ret);
                return response;
            }
        }
}

