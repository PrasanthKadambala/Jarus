using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apijarus.Models
{
    public static class Memory
    {
         public static List<QuoteStatus> getQuotesStatus = new List<QuoteStatus>
        {
            new QuoteStatus { Text = "Basic", Value = "Basic" },
            new QuoteStatus { Text = "Premier", Value = "Premier" }
        };
         public static List<QuoteType> getQuotesTypes = new List<QuoteType>
        {
            new QuoteType { Text = "Pending", Value = "Pending" },
            new QuoteType { Text = "Issued", Value = "Issued" }
        };
        //public static List<Quote> getQuotes = new List<Quote>
        //{
        //    new Quote { QuoteId = 1, Applicant = "James Feather LLC", QuoteNumber = "Q92348", DateOfBirth ="30/09/1987", Coverage = "100%", QuoteDate = "30/09/1987", EffectiveDate = "20/06/1989", Status = getQuotesStatus },
        //    new Quote { QuoteId = 2, Applicant = "James Feather", QuoteNumber = "Q92349", DateOfBirth ="30/09/1987", Coverage = "100%", QuoteDate = "30/09/1987", EffectiveDate = "20/06/1989", Status = getQuotesStatus }

        //};
        public static List<Quote> getDummyQuoteData = new List<Quote>
        {
            new Quote { QuoteId = 1, quote = "Q92348", QuoteDate = "30/09/1987", EffectiveDate = "20/06/1989", Applicant = "James Feather LLC", quoteStatus = getQuotesStatus, quoteType = getQuotesTypes }//,
           // new Quote { QuoteId = 2, QuoteNumber = "Q92348", QuoteDate = "30/09/1987", EffectiveDate = "20/06/1989", quoteStatus = getQuotesStatus, quoteType = getQuotesTypes }
        };
        public static List<Person> getDummyPersonData = new List<Person>
        {
            new Person { PersonId = 1, PersonFirstName = "Mr.James Feather",PersonLastName = "Feather", PersonDOB = "30/09/1987" },
            new Person { PersonId = 2, PersonFirstName = "Mr.John Krakow",PersonLastName = "Krakow", PersonDOB = "30/09/1987" },
            new Person { PersonId = 3, PersonFirstName = "Mr.Red Hemmington", PersonLastName = "Hemmington", PersonDOB = "30/09/1987" }
        };
        public static List<AdditionalInsured> getAdditionalInsuredData = new List<AdditionalInsured>
        {
            new AdditionalInsured { AdditionalInsuredId = 1, AdditionalInsuredName = "Mr.Ron Eldrich", AdditionalInsuredDOB = "30/09/1987", AdditionalInsuredCoverage = "80%", PersonId = 1, QuoteId = 1 },
            new AdditionalInsured { AdditionalInsuredId = 2, AdditionalInsuredName = "Mr.Thom Crystal", AdditionalInsuredDOB = "30/09/1989", AdditionalInsuredCoverage = "100%", PersonId = 1, QuoteId = 2 },
            new AdditionalInsured { AdditionalInsuredId = 3, AdditionalInsuredName = "Mr.Thom Crystal", AdditionalInsuredDOB = "30/09/1987", AdditionalInsuredCoverage = "80%", PersonId = 2, QuoteId = 1 },
            new AdditionalInsured { AdditionalInsuredId = 4, AdditionalInsuredName = "Mr.Thomsan", AdditionalInsuredDOB = "30/09/1989", AdditionalInsuredCoverage = "100%", PersonId = 3, QuoteId = 2 }
        };


    }

}