namespace EmployeeImportance;


public class Employee {
    public int id;
    public int importance;
    public IList<int> subordinates;
}

public class Solution
{
    public int GetImportance(IList<Employee> employees, int id)
    {
        var queue = new Queue<Employee>();
        var employeeDictionary = new Dictionary<int, Employee>();
        foreach (var employee in employees)
        {
            if (employee.id == id)
            {
                queue.Enqueue(employee);
            }
            
            employeeDictionary[employee.id] = employee;
        }
        
        var sum = 0;
        while (queue.Count > 0)
        {
            var emp = queue.Dequeue();
            foreach (var subordinateId in emp.subordinates)
            {
                queue.Enqueue(employeeDictionary[subordinateId]);
            }

            sum += emp.importance;
        }

        return sum;
    }
}