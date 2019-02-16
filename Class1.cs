using System;

class Employee
{
    private string Surname;
    private int Age;

    public Employee()
    {
        Surname = string.Empty;
        Age = 0;
    }

    public Employee(string s, int a)
    {
        Surname = s;
        Age = a;
    }

    public Employee(string s)
    {
        Surname = s;
    }

    private string GetAge()
    {
        return "Age: {Employee.age}";
    }


    public void ChangeEmployeeSurname()
    {
        Employee NewSurname = new Employee();

        
    }



    public string GetEmployeeInfo()
    {
        return "Surname: {Employee.surname}, Age: {Employee.age}";
    }
}
