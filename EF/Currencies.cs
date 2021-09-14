namespace GarantsBack.EF
{
    public class Currencies
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string NameKz { get; set; }
        public bool Active { get; set; }
    }
}