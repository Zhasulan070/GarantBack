namespace GarantsBack.EF
{
    public class CompanyInfo
    {
        public int StatusCode { get; set; }
        public object ErrorMessage { get; set; }
        public Result Result { get; set; }
    }
    
    public partial class Result
    {
        public object Id { get; set; }
        public string Bin { get; set; }
        public object Name { get; set; }
        public int priznak_IP { get; set; }
        public int prizanak_FL { get; set; }
        public string name_Company { get; set; }
    }

    
}