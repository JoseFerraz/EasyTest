using EasyTest.Data.DataContexts;
using EasyTest.Domain;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace EasyTest.Api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api")]
    public class DevelopersTalentsController : ApiController
    {
        private DevelopersTalentsDataContext dbDevelopersTalents = new DevelopersTalentsDataContext();

        [HttpGet]
        [Route("developers-talents")]
        public HttpResponseMessage GetDevelopersTalents()
        {
            var result = dbDevelopersTalents.DeveloperTalent.ToList();

            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpGet]
        [Route("developers-talents/{id}")]
        public HttpResponseMessage GetDeveloperTalent(int id)
        {
            if (id <= 0) return Request.CreateResponse(HttpStatusCode.BadRequest);

            var result = dbDevelopersTalents.DeveloperTalent.Include(x => x.Knowledge).Include(x => x.AdditionalInformation).Include(x => x.BankInformation).FirstOrDefault(x => x.Id == id);

            if (result == null) return Request.CreateResponse(HttpStatusCode.BadRequest);

            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpPut]
        [Route("developers-talents")]
        public HttpResponseMessage PutDeveloperTalent(DeveloperTalent developerTalent)
        {
            if (developerTalent == null) return Request.CreateResponse(HttpStatusCode.BadRequest);

            try
            {
                dbDevelopersTalents.Entry(developerTalent).State = EntityState.Modified;
                dbDevelopersTalents.Entry(developerTalent.Knowledge).State = EntityState.Modified;
                dbDevelopersTalents.Entry(developerTalent.AdditionalInformation).State = EntityState.Modified;
                dbDevelopersTalents.Entry(developerTalent.BankInformation).State = EntityState.Modified;

                dbDevelopersTalents.SaveChanges();

                var result = developerTalent;

                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        [HttpPost]
        [Route("developers-talents")]
        public HttpResponseMessage PostDeveloperTalent(DeveloperTalent developerTalent)
        {
            if (developerTalent == null) return Request.CreateResponse(HttpStatusCode.BadRequest);
            if (developerTalent.BankInformation == null)
            {
                developerTalent.BankInformation = new BankInformation();
            }

            try
            {
                dbDevelopersTalents.DeveloperTalent.Add(developerTalent);

                dbDevelopersTalents.SaveChanges();

                var result = developerTalent;

                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        [HttpDelete]
        [Route("developers-talents/{id}")]
        public HttpResponseMessage DeleteDeveloperTalent(int id)
        {
            if (id <= 0) return Request.CreateResponse(HttpStatusCode.BadRequest);

            try
            {
                dbDevelopersTalents.DeveloperTalent.Remove(dbDevelopersTalents.DeveloperTalent.Find(id));

                dbDevelopersTalents.SaveChanges();

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                dbDevelopersTalents.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
