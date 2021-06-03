using System;

namespace Employees
{
  abstract partial class Employee
  {
    public class BenefitPackage
    {
      public enum BenefitPackageLevel
      {
        Standard, Gold, Platinum
      }
      // Assume we have other members that represent
      // dental/health benefits, and so on.
      public double ComputePayDeduction()
      {
        return 125.0;
      }
    }

    // Constructors.
    public Employee() { }
    public Employee(string name, int id, float pay, string empSsn) : this(name, 0, id, pay, empSsn, EmployeePayTypeEnum.Salaried) { }
    public Employee(string name, int age, int id, float pay, string empSsn, EmployeePayTypeEnum payType)
    {
      Name = name;
      Id = id;
      Age = age;
      Pay = pay;
      SocialSecurityNumber = empSsn;
      PayType = payType;
    }

    // Methods.
    public virtual void GiveBonus(float amount) => Pay += amount;

    public virtual void DisplayStats()
    {
      Console.WriteLine("Name: {0}", Name);
      Console.WriteLine("ID: {0}", Id);
      Console.WriteLine("Age: {0}", Age);
      Console.WriteLine("Pay: {0}", Pay);
    }
    // Accessor (get method).
    public string GetName() => _empName;

    // Mutator (set method).
    public void SetName(string name) => Name = name;
  }
}
