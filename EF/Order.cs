using System;
using System.Collections.Generic;

namespace GarantsBack.EF
{
    public class KlArray
    {
        public int id { get; set; }
        public int currency { get; set; }
        public string CurrencyName { get; set; }
        public string kl_type { get; set; }
        public double summa { get; set; }
        public int validDate { get; set; }
    }
    
    public class Order
    {
        public string Uin { get; set; }
        public int FilialId { get; set; }
        public string FilialName { get; set; }
        public string Filialcode { get; set; }
        public int RequestType { get; set; }
        public string RequestName { get; set; }
        public int SegmentId { get; set; }
        public string SegmentName { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public string Bin { get; set; }
        public string Name { get; set; }
        public List<KlArray> kl_array { get; set; }
        public string Beneficator { get; set; }
    }

    public class OrderModel
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public int FilialId { get; set; }
        public int SegmentId { get; set; }
        public int StatusId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime? FinishDateTime { get; set; }
        public string Bin { get; set; }
        public string CompanyName { get; set; }
        public double Summ { get; set; }
        public int CurrencyId { get; set; } 
        public int Month { get; set; }
        public string KmEmail { get; set; }
        public string LoanNumber { get; set; }
        public string Beneficator { get; set; }
        public string RequestType { get; set; }
        public string Filial { get; set; }
        public string FilialCode { get; set; }
        public string Segment { get; set; }
        public string Status { get; set; }
    }
    
    public class OrderModelWithKl
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string KmEmail { get; set; }
        public string RequestType { get; set; }
        public int TypeId { get; set; }
        public string Filial { get; set; }
        public int FilialId { get; set; }
        public string FilialCode { get; set; }
        public string Segment { get; set; }
        public int SegmentId { get; set; }
        public string Status { get; set; }
        public int StatusId { get; set; }
        public string Bin { get; set; }
        public string CompanyName { get; set; }
        public string Beneficator { get; set; }
        public string KlNumber { get; set; }
        public double Summ { get; set; }
        public string CurrencyName { get; set; }
        public int CurrencyId { get; set; }
        public int Mounth { get; set; }
    }
}