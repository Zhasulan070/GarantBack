using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarantsBack.EF
{
    public class LoanRequest
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public int SubTypeId { get; set; }
        public int ChanelId { get; set; }
        public int FilialId { get; set; }
        public int SegmentId { get; set; }
        public int StatusId { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? FinishDateTime { get; set; }
        public string Bin { get; set; }
        public string CompanyName { get; set; }
        public double Summ { get; set; }
        public int CurrencyId { get; set; }
        public int? Month { get; set; }
        public double CreditRate { get; set; }
        public string FilePath { get; set; }
        public string KmEmail { get; set; }
        public string LoanNumber { get; set; }
        public string ScanDocsUrl { get; set; }
        public string ContractsUrl { get; set; }
        public string ContractsRemarksUrl { get; set; }
        public string ChangeCategories { get; set; }
        public int? Ka1Id { get; set; }
        public int? Ka2Id { get; set; }
        public string CheckerId { get; set; }
        public string MonitoringId { get; set; }
        public string Comments { get; set; }
        public int SoklNum { get; set; }
        public int SoklNum1 { get; set; }
        public int SoklNewNum { get; set; }
        public int SoklNewDamuNum { get; set; }
        public int DzNum { get; set; }
        public int DzNum1 { get; set; }
        public int DzNum2 { get; set; }
        public int DzNum3 { get; set; }
        public int DzdpNum { get; set; }
        public int DzdpNum1 { get; set; }
        public int DzdpNum2 { get; set; }
        public int DzdpNum3 { get; set; }
        public int DgNum { get; set; }
        public int DgdpNum { get; set; }
        public int Dpsokl { get; set; }
        public int DsorderNum { get; set; }
        public int DsterminationNum { get; set; }
        public int DzfutureNum { get; set; }
        public int Dzothers { get; set; }
        public string UniqNumSb { get; set; }
        public string Target { get; set; }
        public DateTime? RequestDate { get; set; }
        public int IsOUworks { get; set; }
        public DateTime? CreditDate { get; set; }
        public string DecisionFilePath { get; set; }
        public string OrderFilePath { get; set; }
        public string InitCl { get; set; }
        public string Doc24Id { get; set; }
        public bool IsGovermentGrant { get; set; }
        public bool IsIndividualGraph { get; set; }
    }
}