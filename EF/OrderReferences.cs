using System.Collections.Generic;

namespace GarantsBack.EF
{
    public class OrderReferences
    {
        public int statusCode { get; set; }
        public object errorMessage { get; set; }
        public Result result { get; set; }
    }
    public class Requesttype
    {
        public int id { get; set; }
        public string name { get; set; }
        public int status { get; set; }
        public List<object> loanrequest { get; set; }
        public object statuses { get; set; }
    }

    public class Filial
    {
        public int id { get; set; }
        public string name { get; set; }
        public string nameKz { get; set; }
        public int active { get; set; }
        public int isNeedControl { get; set; }
        public int regionId { get; set; }
        public string filialCode { get; set; }
        public List<object> grantrequest { get; set; }
        public object kpmonitoringtable { get; set; }
        public List<object> loanrequest { get; set; }
        public List<object> mailing { get; set; }
        public List<object> monitoringtable { get; set; }
        public List<object> restructuringrequest { get; set; }
        public object kpmonitoringcompany { get; set; }
    }

    public class Segment
    {
        public int id { get; set; }
        public string name { get; set; }
        public string nameKz { get; set; }
        public int active { get; set; }
        public string codeName { get; set; }
        public List<object> loanrequest { get; set; }
        public object monitoringtable { get; set; }
        public object kpmonitoringtable { get; set; }
    }

    public class Currency
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string nameKz { get; set; }
        public int active { get; set; }
        public List<object> loanrequest { get; set; }
        public object loanrequestcl { get; set; }
    }

    public partial class Result
    {
        public List<Requesttype> requesttype { get; set; }
        public List<Filial> filials { get; set; }
        public List<Segment> segments { get; set; }
        public List<Currency> currencies { get; set; }
    }
}