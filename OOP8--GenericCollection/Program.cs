namespace OOP8__GenericCollection
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                Stack<Employee> StackOfEmployees = new Stack<Employee>();  // Create a stack of employees

                Employee employee1 = new Employee(1, "Malin", "Female", 50000);
                Employee employee2 = new Employee(2, "Robert", "Male", 45000);
                Employee employee3 = new Employee(3, "Susanne", "Female", 48000);  //The Employees 
                Employee employee4 = new Employee(4, "Pär", "Male", 46000);
                Employee employee5 = new Employee(5, "Dennis", "Male", 38000);

                StackOfEmployees.Push(employee1);
                StackOfEmployees.Push(employee2);
                StackOfEmployees.Push(employee3);    //This is to push all the employees in to the stack we created
                StackOfEmployees.Push(employee4);
                StackOfEmployees.Push(employee5);


                foreach (var employee in StackOfEmployees)  //This loop is to write out all employees in stack and count how many employees there is in stack
                {
                    Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}");
                    Console.WriteLine($"Employees in stack: {StackOfEmployees.Count}");

                }

                Console.WriteLine("--------------------------");
                Console.WriteLine(" Using Pop Method:");

                while (StackOfEmployees.Count > 0)        //Pop(); Method and a counter that counts how many employees there is left in stack 
                {
                    Employee PopEmployee = StackOfEmployees.Pop();
                    Console.WriteLine($"{PopEmployee.Id} - {PopEmployee.Name} - {PopEmployee.Gender} - {PopEmployee.Salary}");
                    Console.WriteLine($"Employees left in stack: {StackOfEmployees.Count} ");

                }

                StackOfEmployees.Push(employee1);
                StackOfEmployees.Push(employee2);
                StackOfEmployees.Push(employee3);    //This is to push all the employees back in to the stack again
                StackOfEmployees.Push(employee4);
                StackOfEmployees.Push(employee5);

                Console.WriteLine("--------------------------");  //Peek Method
                Console.WriteLine("Using peek method:");

                Employee Peekemployee1 = StackOfEmployees.Peek();
                Console.WriteLine($"{Peekemployee1.Id} - {Peekemployee1.Name} - {Peekemployee1.Gender} - {Peekemployee1.Salary}");
                Console.WriteLine($"Employees left in stack: {StackOfEmployees.Count}");

                Employee Peekemployee2 = StackOfEmployees.Peek();
                Console.WriteLine($"{Peekemployee2.Id} - {Peekemployee2.Name} - {Peekemployee2.Gender} - {Peekemployee2.Salary}");
                Console.WriteLine($"Employees left in stack: {StackOfEmployees.Count}");

                Console.WriteLine("--------------------------");


                Employee CheckEmployee = StackOfEmployees.ElementAtOrDefault(1);
                bool isEmployeeInStack = StackOfEmployees.Contains(CheckEmployee); //bool method to check if the employee is in stack

                if (isEmployeeInStack)
                {
                    Console.WriteLine("Employee number 2 is in stack.");
                }
                else
                {
                    Console.WriteLine("Employee number 2 is not in stack.");
                }

                Console.WriteLine("--------------------------");

                List<Employee> ListOfEmployees = new List<Employee>(); //create a list


                ListOfEmployees.Add(employee1);
                ListOfEmployees.Add(employee2);
                ListOfEmployees.Add(employee3);         //List of employees
                ListOfEmployees.Add(employee4);
                ListOfEmployees.Add(employee5);

                Employee checkEmployee = employee4;
                if (ListOfEmployees.Contains(checkEmployee))   //Checks if the employee contains in the list
                {
                    Console.WriteLine("Employee4 object exist in the list");
                }
                else
                {
                    Console.WriteLine("Employee4 object do not exist in the list");
                }

                Console.WriteLine();

                Employee firstMaleEmployeeinList = ListOfEmployees.Find(emp => emp.Gender == "Male");
                if (firstMaleEmployeeinList != null) //Finds the first male employee in list
                {
                    Console.WriteLine($"First Male employee in list is: {firstMaleEmployeeinList.Id} - {firstMaleEmployeeinList.Name} - {firstMaleEmployeeinList.Gender} - {firstMaleEmployeeinList.Salary}");
                }

                Console.WriteLine();

                List<Employee> allMaleEmployees = ListOfEmployees.FindAll(emp => emp.Gender == "Male");
                if (allMaleEmployees.Count > 0)  //Finds all of the male employees in list
                {
                    Console.WriteLine("All male employees in list:");
                    foreach (var emp in allMaleEmployees)
                    {
                        Console.WriteLine($"{emp.Id} - {emp.Name} - {emp.Gender} - {emp.Salary}");
                    }

                }

            }

    }
    
}