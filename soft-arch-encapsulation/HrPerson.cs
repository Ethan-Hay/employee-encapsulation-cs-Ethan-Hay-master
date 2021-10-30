using System.Collections.Generic;



namespace soft_arch_encapsulation
{
    public class HrPerson
    {
        private List<Employee> employees = new List<Employee>();

    public HrPerson() {

    }

    public void hireEmployee(string firstName, string lastName, string ssn) {
        Employee e = new Employee(firstName, lastName, ssn);
        employees.Add(e);
        orientEmployee(e);
    }

    // HRManager delegates work to employee
    private void orientEmployee(Employee emp) {
        emp.doFirstTimeOrientation("B101");
    }

    public void outputReport(string ssn) {

        // find employee in list
        foreach (Employee emp in employees) {
            if (emp.getSsn().Equals(ssn)) {
                // if found run report
                if (emp.hasMetWithHr() && emp.hasMetDeptStaff()
                        && emp.hasReviewedDeptPolicies() && emp.hasMovedIn()) {
                    emp.printReport();
                }
                break;
            }
        }
    }

    }
}