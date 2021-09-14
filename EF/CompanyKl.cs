using System.Collections.Generic;

namespace GarantsBack.EF
{
    public class PurpFinName
    {
        public string nil { get; set; }
    }

    public class CommRate
    {
        public string commission { get; set; }
        public string commName { get; set; }
        public string currency { get; set; }
        public string rateComm { get; set; }
        public string rateFixed { get; set; }
        public string kau { get; set; }
        public string since { get; set; }
    }

    public class LoanCond
    {
        public string gid { get; set; }
        public string begDate { get; set; }
        public string endDate { get; set; }
        public string restr { get; set; }
        public string restrType { get; set; }
        public string payScheme { get; set; }
        public string sum { get; set; }
        public string rate { get; set; }
        public CommRate commRate { get; set; }
    }

    public class LoanConds
    {
        public string gid { get; set; }
        public List<LoanCond> loanCond { get; set; }
    }

    public class Delays
    {
        public string gid { get; set; }
        public List<object> delay { get; set; }
    }

    public class Account
    {
        public string acct { get; set; }
        public string currency { get; set; }
        public string acctType { get; set; }
        public string acctName { get; set; }
        public string amt { get; set; }
        public string amtCurr { get; set; }
    }

    public class Accounts
    {
        public string gid { get; set; }
        public Account account { get; set; }
    }

    public class RelLoans
    {
        public string gid { get; set; }
        public List<object> relLoan { get; set; }
    }

    public class Collateral
    {
        public string gid { get; set; }
        public string contCode { get; set; }
        public string contType { get; set; }
        public string contTypeName { get; set; }
        public string contClass { get; set; }
        public string location { get; set; }
        public string description { get; set; }
        public string addInform { get; set; }
        public string begDate { get; set; }
        public string endDate { get; set; }
        public string currency { get; set; }
        public string amt { get; set; }
        public string amtCurr { get; set; }
        public string corrCoeff { get; set; }
        public string collName { get; set; }
        public RelLoans relLoans { get; set; }
    }

    public class Collaterals
    {
        public string gid { get; set; }
        public List<Collateral> collateral { get; set; }
    }

    public class GrPayment
    {
        public string endDate { get; set; }
        public string debt { get; set; }
        public string proc { get; set; }
        public string total { get; set; }
    }

    public class GrPayments
    {
        public string gid { get; set; }
        public List<GrPayment> grPayment { get; set; }
    }

    public class CustRole
    {
        public string gid { get; set; }
        public string role { get; set; }
        public string custCat { get; set; }
        public string subject { get; set; }
        public string openDate { get; set; }
        public string closeDate { get; set; }
    }

    public class CustRoles
    {
        public string gid { get; set; }
        public List<CustRole> custRole { get; set; }
    }

    public class InsLoan
    {
        public string gid { get; set; }
        public string openDate { get; set; }
        public string docNum { get; set; }
        public string loanDocNum { get; set; }
        public string insCompName { get; set; }
        public string endDate { get; set; }
    }

    public class InsLoans
    {
        public string gid { get; set; }
        public List<InsLoan> insLoan { get; set; }
    }

    public class CredLinName
    {
        public string nil { get; set; }
    }

    public class Loan
    {
        public string gid { get; set; }
        public string product { get; set; }
        public string contCode { get; set; }
        public string parentContCode { get; set; }
        public string contract { get; set; }
        public string filialId { get; set; }
        public string branchId { get; set; }
        public string custCat { get; set; }
        public string custId { get; set; }
        public string credLinType { get; set; }
        public string currency { get; set; }
        public string begDate { get; set; }
        public string endDate { get; set; }
        public string closeDate { get; set; }
        public string availDate { get; set; }
        public string ges { get; set; }
        public string credAmt { get; set; }
        public string credLinAmt { get; set; }
        public string ccNum { get; set; }
        public string ccDate { get; set; }
        public string purpFin { get; set; }
        public PurpFinName purpFinName { get; set; }
        public string repDate { get; set; }
        public string repStatus { get; set; }
        public string totalDelay { get; set; }
        public string requestNumber { get; set; }
        public string amtCurrKL { get; set; }
        public string segment { get; set; }
        public LoanConds loanConds { get; set; }
        public Delays delays { get; set; }
        public Accounts accounts { get; set; }
        public Collaterals collaterals { get; set; }
        public GrPayments grPayments { get; set; }
        public CustRoles custRoles { get; set; }
        public InsLoans insLoans { get; set; }
        public CredLinName credLinName { get; set; }
    }

    public class Errors
    {
        public string gid { get; set; }
    }

    public class Loans
    {
        public string gid { get; set; }
        public List<Loan> loan { get; set; }
        public Errors errors { get; set; }
    }

    public class FicoLoanResp
    {
        public Loans loans { get; set; }
        public string xsi { get; set; }
    }

    public class ResponseData
    {
        public FicoLoanResp ficoLoanResp { get; set; }
    }

    public partial class Result
    {
        public string rqUID { get; set; }
        public string rqTm { get; set; }
        public string serviceCode { get; set; }
        public ResponseData responseData { get; set; }
    }

    public class CompanyKl
    {
        public int statusCode { get; set; }
        public object errorMessage { get; set; }
        public Result result { get; set; }
    }


}