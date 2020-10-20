using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace apijarus.Models
{
    public class Quote
    {
        public int QuoteId { get; set; }
        public string quote { get; set; }
        public string QuoteDate { get; set; }
        public string EffectiveDate { get; set; }
        public string QuoteType { get; set; }

        public string Applicant { get; set; }
        public IEnumerable<QuoteType> quoteType { get; set; }
        public string Status { get; set; }
        public List<QuoteStatus> quoteStatus { get; set; }
    }

    public class Person
    {
        public int PersonId { get; set; }
        public string PersonFirstName { get; set; }
        public string PersonLastName { get; set; }
        public string PersonDOB { get; set; }
   }

    public class AdditionalInsured 
    {
        public int AdditionalInsuredId { get; set; }
        public int PersonId { get; set; }
        public int QuoteId { get; set; }
        public string AdditionalInsuredName { get; set; }
        public string AdditionalInsuredDOB { get; set; }
        public string AdditionalInsuredCoverage { get; set; }
    }

    public class QuoteStatus
    {
        public string Text { get; set; }
        public string Value { get; set; }
    }

    public class QuoteType
    {
        public string Text { get; set; }
        public string Value { get; set; }
    }
}