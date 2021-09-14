namespace GarantsBack.EF
{
    public class Filials
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string NameKz { get; set; }
        public bool Active { get; set; }
        public int RegionId { get; set; }
        public string FilialCode { get; set; }
        public bool IsNeedControl { get; set; }
    }
}