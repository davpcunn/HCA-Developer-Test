using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1.General
{
    abstract class Patient
    {
      string MedicalRecordNumber;
      string FirstName;
      string LastName;
      string StreetAddress;
      List<InsurancePolicy> Insurance;
      public bool validation(){
        InsurancePolicy ins;
        if (MedicalRecordNumber == null || MedicalRecordNumber == "") return false;
        if (FirstName == null || FirstName == "") return false;
        if (LastName == null || LastName == "") return false;
        if (StreetAddress == null || StreetAddress == "") return false;
        ins = Insurance.Any();
        foreach (InsurancePolicy ins in Insurance)
          if (ins.valid()) return true;
        }
        return false;
      }
      public void GetDisplayText1(){
        InsurancePolicy ins;
        string s = "";
        s = s + FirstName + " " + LastName;
        foreach (ins in Insurance){
          if (ins.valid()){
            s = s + " - " + ins.ProviderName + " " + ins.PolicyNumber;
            break
          }
        }
        Console.WriteLine(s);
      }
      public void GetDisplayText2(){
        InsurancePolicy ins;
        StringBuilder sb = new StringBuilder();
        sb.Append(FirstName);
        sb.Append(" ");
        sb.Append(LastName);
        foreach (ins in Insurance){
          if (ins.valid()){
            sb.Append(" - ");
            sb.Append(ins.ProviderName);
            sb.Append(" ")
            sb.Append(ins.PolicyNumber);
            break;
          }
        Console.WriteLine(sb.toString());
      }
      public void GetDisplayText3(){
        InsurancePolicy ins;
        string s = "";
        s.Join(FirstName);
        s.Join(" ");
        s.Join(LastName);
        foreach (ins in Insurance){
          if (ins.valid()){
            s.Join(" - ");
            s.Join(ins.ProviderName);
            s.Join(" ")
            s.Join(ins.PolicyNumber);
            break;
          }
        }
        Console.WriteLine(s);
      }
      public void CleanUp{
        MedicalRecordNumber = null;
        FirstName = null;
        LastName = null;
        StreetAddress = null;
        InsurancePolicy = null;
      }
    }
    class InsurancePolicy{
      string ProviderName;
      string PolicyNumber;
      public bool valid(){
        if (ins.ProviderName != null && ins.ProviderName != "" && ins.PolicyNumber != null && ins.PolicyNumber != "") return true;
        return false;
      }
    }
}
