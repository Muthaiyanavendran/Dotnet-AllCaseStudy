public interface IEmployee<T> where T : Employee
{
    string PrintEmployeeDetails(T employee);
}
