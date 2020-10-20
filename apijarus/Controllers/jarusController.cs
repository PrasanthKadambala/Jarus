using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using apijarus.Models;
using Newtonsoft.Json;

namespace apijarus.Controllers
{
    public class jarusController : ApiController
    {
        // GET: Product
        [Route("api/jarus/GetQuotes")]
        public Quote GetQuotes()
        {
            Quote quote = Memory.getDummyQuoteData.SingleOrDefault();
            return quote;
         }
        [Route("api/jarus/getpeople")]
        public IEnumerable<Person> GetPeople()
        {
            List<Person> people = Memory.getDummyPersonData;
            return people.AsEnumerable();

        }
        [Route("api/jarus/FindPeople")]
        [HttpGet]
        public IEnumerable<Person> FindPeople(string Firstname, string Lastname)
        {
            List<Person> people = Memory.getDummyPersonData.Where(P => P.PersonFirstName.ToLower().Contains(Firstname.ToLower()) || P.PersonLastName.ToLower().Contains(Lastname.ToLower())).ToList();
            if (people.Count == 0)
                return null;
            return people.AsEnumerable();
        }

        //public AdditionalInsured GetAdditionalInsured(int PersonId)
        //{
        //    AdditionalInsured additionalInsured = Memory.getAdditionalInsuredData.Where(P => P.PersonId == PersonId).SingleOrDefault();
        //    return additionalInsured;
        //}

        public IEnumerable<AdditionalInsured> GetAdditionalInsured(int PersonId)
        {
            List<AdditionalInsured> additionalInsured = Memory.getAdditionalInsuredData.Where(P => P.PersonId == PersonId).ToList();
            //return Json(additionalInsured, )
            return additionalInsured.AsEnumerable();
        }

    }
}
