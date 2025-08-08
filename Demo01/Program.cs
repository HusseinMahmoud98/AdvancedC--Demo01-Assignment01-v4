namespace Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generics [Swap Function]
            ////For integer
            //Console.WriteLine("********** Before Swapping **********");
            //int X = 1, Y = 2;
            //Console.WriteLine($"X = {X}, Y = {Y}");
            //Helper.Swap<int>(ref X, ref Y);
            //Console.WriteLine("********** After Swapping **********");
            //Console.WriteLine($"X = {X}, Y = {Y}");


            ////For double
            //Console.WriteLine("********** Before Swapping **********");
            //double L = 1.2, K = 2.3;
            //Console.WriteLine($"L = {L}, K = {K}");
            //Helper.Swap<double>(ref L, ref K);
            //Console.WriteLine("********** After Swapping **********");
            //Console.WriteLine($"X = {L}, Y = {K}");


            ////For Point
            //Console.WriteLine("********** Before Swapping **********");
            //Point P01 = new() { X = 1, Y = 2 };
            //Point P02 = new() { X = 3, Y = 4 };
            //Console.WriteLine($"P01 = {P01.X}, Y = {P01.Y}");
            //Console.WriteLine($"P02 = {P02.X}, Y = {P02.Y}");
            //Helper.Swap<Point>(ref P01, ref P02);
            //Console.WriteLine("********** After Swapping **********");
            //Console.WriteLine($"P01 = {P01.X}, Y = {P01.Y}");
            //Console.WriteLine($"P02 = {P02.X}, Y = {P02.Y}");
            #endregion

            #region Generics [Linear Search]
            //int[] arr = { 1, 2, 5, 8, 0, -5, 60 };

            //Employee E01 = new Employee() { Id = 1, Name = "Hussein", Age = 20, Salary = 11000 };
            //Employee E02 = new Employee() { Id = 2, Name = "Mahmoud", Age = 21, Salary = 15000 };
            //Employee E03 = new Employee() { Id = 3, Name = "Fouad", Age = 25, Salary = 17000 };
            //Employee E04 = new Employee() { Id = 4, Name = "Esraa", Age = 30, Salary = 19000 };

            //Employee[] employees = { E01, E02, E03, E04 };


            //Console.WriteLine(Helper.LinearSearch<int>(arr, -5));
            //Console.WriteLine(Helper.LinearSearch<Employee>(employees, E01)); 
            #endregion

            #region Generics [Equality]
            //Employee E01 = new Employee() { Id = 1, Name = "Hussein", Age = 21, Salary = 15000 };
            //Employee E02 = new Employee() { Id = 2, Name = "Hussein", Age = 21, Salary = 15000 };


            //if (E01 == E02)
            //    Console.WriteLine("E01 = E02");

            //else
            //    Console.WriteLine("E01 != E02");    
            #endregion

            #region Generics [Bubble Sort]
            //int[] arr = { 1, 2, 5, 8, 0, -5, 60 };

            ////For integer
            //Helper.BubbleSort(arr);
            //Helper.PrintArray(arr);

            ////For User Defined Data type Ponit
            //Point P01 = new() { X = 1, Y = 2 };
            //Point P02 = new() { X = 0, Y = 4 };
            //Point P03 = new() { X = 5, Y = 6 };
            //Point P04 = new() { X = 5, Y = 0 };

            //Point[] points = { P01, P02, P03, P04 };
            //Helper.BubbleSort(points);
            //Helper.PrintArray(points);

            ////For User Defined Data type Employee
            //Employee E01 = new Employee() { Id = 4, Name = "Hussein", Age = 20, Salary = 11000 };
            //Employee E02 = new Employee() { Id = 3, Name = "Mahmoud", Age = 21, Salary = 15000 };
            //Employee E03 = new Employee() { Id = 1, Name = "Fouad", Age = 25, Salary = 17000 };
            //Employee E04 = new Employee() { Id = 2, Name = "Esraa", Age = 30, Salary = 19000 };

            //Employee[] employees = { E01, E02, E03, E04 };

            //Helper.BubbleSort(employees);
            //Helper.PrintArray(employees); 
            #endregion

            #region [Built-in Generic Interface] IEquatable
            //Employee E01 = new Employee() { Id = 2, Name = "Hussein", Age = 21, Salary = 15000 };
            //Employee E02 = new Employee() { Id = 2, Name = "Hussein", Age = 21, Salary = 15000 };


            //if (E01.Equals(E02))
            //    Console.WriteLine("E01 = E02");

            //else
            //    Console.WriteLine("E01 != E02");

            #endregion

            #region [Built-in Generic Interface] IEqualityComparer
            //Employee E01 = new Employee() { Id = 2, Name = "Hussein", Age = 21, Salary = 15000 };
            //Employee E02 = new Employee() { Id = 2, Name = "Hussein", Age = 21, Salary = 15000 };


            //if (E01.Equals(E02))
            //    Console.WriteLine("E01 = E02");

            //else
            //    Console.WriteLine("E01 != E02");
            #endregion

            #region Generics [Linear Search with EmployeeEqualityComparer]
            //Employee E01 = new Employee() { Id = 1, Name = "Hussein", Age = 20, Salary = 11000 };
            //Employee E02 = new Employee() { Id = 2, Name = "Mahmoud", Age = 21, Salary = 15000 };
            //Employee E03 = new Employee() { Id = 3, Name = "Fouad", Age = 25, Salary = 17000 };
            //Employee E04 = new Employee() { Id = 4, Name = "Esraa", Age = 30, Salary = 19000 };

            //Employee[] employees = { E01, E02, E03, E04 };

            //int index = Helper.LinearSearch<Employee>(employees, new Employee() { Name = "Mahmoud"}, new EmployeeEqualityComparerName());
            //Console.WriteLine(index);

            #endregion

            #region Generics [IComparable With Bubble Sort]
            //int[] arr = { 1, 2, 5, 8, 0, -5, 60 };

            ////For integer
            //Helper.BubbleSort(arr);
            //Helper.PrintArray(arr);

            ////For User Defined Data type Ponit
            //Point P01 = new() { X = 1, Y = 2 };
            //Point P02 = new() { X = 0, Y = 4 };
            //Point P03 = new() { X = 5, Y = 6 };
            //Point P04 = new() { X = 5, Y = 0 };

            //Point[] points = { P01, P02, P03, P04 };
            //Helper.BubbleSort(points);
            //Helper.PrintArray(points);

            //For User Defined Data type Employee
            //Employee E01 = new Employee() { Id = 4, Name = "Hussein", Age = 20, Salary = 11000 };
            //Employee E02 = new Employee() { Id = 3, Name = "Mahmoud", Age = 21, Salary = 15000 };
            //Employee E03 = new Employee() { Id = 1, Name = "Fouad", Age = 25, Salary = 1000 };
            //Employee E04 = new Employee() { Id = 2, Name = "Esraa", Age = 30, Salary = 19000 };

            //Employee[] employees = { E01, E02, E03, E04 };

            //Helper.BubbleSort(employees, new EmployeeComparerSalary());
            //Helper.PrintArray(employees);
            #endregion

            #region Genarics Constraints
            // Generic Constraints:
            // 1. Primary Constraint (class, struct, special type, enum, notnull) [0 : 1] constraints range
            // 2. Secondary Constraint (implement interface) [0 : N] constraints range
            // 3. Constuctor Constraints (Ex: new() --> means that the class must implement parameterless constructor)

            #endregion
        }
    }
}
