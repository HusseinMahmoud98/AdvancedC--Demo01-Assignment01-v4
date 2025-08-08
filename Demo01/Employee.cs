using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class EmployeeEqualityComparerName : IEqualityComparer<Employee>
    {
        public int CompareTo(EmployeeEqualityComparerName? other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Employee? x, Employee? y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return HashCode.Combine(obj.Name);
        }
    }

    internal class EmployeeComparerSalary : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x.Salary.CompareTo(y.Salary);
        }
    }

    internal class EmployeeComparerNameLength : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x.Name.Length.CompareTo(y.Name);
        }
    }


    internal class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        //public int CompareTo(object? obj)
        //{
        //    if (obj is not null)
        //    {
        //        Employee emp = obj as Employee;
        //        return Id.CompareTo(emp.Id);
        //    }

        //    return 1;
        //}

        public int CompareTo(Employee? other)
        {
            if (other is not null)
            {
                return Id.CompareTo(other.Id);
            }

            return 1;
        }

        public bool Equals(Employee? other)
        {
            return other is not null ? this == other : false;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}, Age: {Age}";
        }

        public static bool operator ==(Employee left, Employee right)
        {
            return left.Id == right.Id && left.Name == right.Name && left.Age == right.Age && left.Salary == right.Salary;
        }

        public static bool operator !=(Employee left, Employee right)
        {
            return !(left.Id == right.Id && left.Name == right.Name && left.Age == right.Age && left.Salary == right.Salary);
        }
    }
}
