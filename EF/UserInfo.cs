namespace GarantsBack.EF
{
    public class UserInfo
    {
        public int statusCode { get; set; }
        public object errorMessage { get; set; }
        public Result result { get; set; }
    }
    public partial class Result
    {
        public bool validated { get; set; }
        public int userId { get; set; }
        public string userFIO { get; set; }
        public string userName { get; set; }
        public string userEmail { get; set; }
        public string roleName { get; set; }
    }
}