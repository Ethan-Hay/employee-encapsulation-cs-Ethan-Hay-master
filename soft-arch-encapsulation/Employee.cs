using System;


namespace soft_arch_encapsulation
{
    public class Employee
    {
        private const string REQUIRED_MSG = " is mandatory ";
    private const string NEWLINE = "\n";

    private string firstName;
    private string lastName;
    private string ssn;
    private bool metWithHr;
    private bool metDeptStaff;
    private bool reviewedDeptPolicies;
    private bool movedIn;
    private string cubeId;
    private DateTime orientationDate;
    private EmployeeReportService reportService = new EmployeeReportService();

    /*
        Notice we force certain mandatory properties by using a custom
        constructor. But we use the setter method to perform validation.
     */
    public Employee(string firstName, string lastName, string ssn) {
        setFirstName(firstName);
        setLastName(lastName);
        setSsn(ssn);
    }

    /*
        This should be private because it is useful only to this class and then,
        only as a helper method to other methods. This is method hiding - a type
        of encapsulation where we put frequently used code in one place for easy
        reuse and editing.
     */
    private string getFormattedDate() {
        return orientationDate.ToString("M/d/yy");
    }

    /*
        This method is public because it must be available to other classes in
        this project. Notice that it controls the order in which the helper methods
        are called. Order isn't always an issue, but here it obviously is, which
        may be an important requirement.
     */
    public void doFirstTimeOrientation(string cubeId) {
        orientationDate = DateTime.Now;
        meetWithHrForBenefitAndSalaryInfo();
        meetDepartmentStaff();
        reviewDeptPolicies();
        moveIntoCubicle(cubeId);
    }

    // The following methods may be public or private, depending on whether
    // they need to be called from other classes independently.
    // Assume this must be performed first, and assume that an employee
    // would only do this once, upon being hired. If that were true, this
    // method should not be public. It should only be available to this class
    // and should only be called as part of the larger task of:
    // doFirstTimeOrientation()
    private void meetWithHrForBenefitAndSalaryInfo() {
        metWithHr = true;
        reportService.addData(firstName + " " + lastName + " met with HR on "
                + getFormattedDate() + NEWLINE);
    }

    // Assume this must be performed first, and assume that an employee
    // would only do this once, upon being hired. If that were true, this
    // method should not be public. It should only be available to this class
    // and should only be called as part of the larger task of:
    // doFirstTimeOrientation()
    private void meetDepartmentStaff() {
        metDeptStaff = true;
        reportService.addData(firstName + " " + lastName + " met with dept staff on "
                + getFormattedDate() + NEWLINE);
    }

    // Assume this must be performed third. And assume that because department
    // policies may change that this method may need to be called
    // independently from other classes.
    public void reviewDeptPolicies() {
        reviewedDeptPolicies = true;
        reportService.addData(firstName + " " + lastName + " reviewed dept policies on "
                + getFormattedDate() + NEWLINE);
    }

    // Assume this must be performed 4th. And assume that because employees
    // sometimes change office locations that this method may need to be called
    // independently from other classes.
    public void moveIntoCubicle(string cubeId) {
        setCubeId(cubeId);

        this.movedIn = true;
        reportService.addData(firstName + " " + lastName + " moved into cubicle "
                + cubeId + " on " + getFormattedDate() + NEWLINE);
    }

    public string getFirstName() {
        return firstName;
    }

    // setter methods give the developer the power to control what data is
    // allowed through validation. Throwing ane exception is the best
    // practice when validation fails. Don't do a System.out.println()
    // to display an error message -- not the job of this class!
    public void setFirstName(string firstName) {
        if (firstName == null) {
            throw new ArgumentException("first name" + REQUIRED_MSG);
        }
        this.firstName = firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public void setLastName(string lastName) {
        if (lastName == null) {
            throw new ArgumentException("last name" + REQUIRED_MSG);
        }
        this.lastName = lastName;
    }

    public string getSsn() {
        return ssn;
    }

    public void setSsn(string ssn) {
        if (ssn == null || ssn.Length < 9 || ssn.Length > 11) {
            throw new ArgumentException("ssn" + REQUIRED_MSG + "and must be between 9 and 11 characters (if hyphens are used)");
        }
        this.ssn = ssn;
    }

    public bool hasMetWithHr() {
        return metWithHr;
    }

    public bool hasMetDeptStaff() {
        return metDeptStaff;
    }

    public bool hasReviewedDeptPolicies() {
        return reviewedDeptPolicies;
    }

    public bool hasMovedIn() {
        return movedIn;
    }

    public string getCubeId() {
        return cubeId;
    }

    public void setCubeId(string cubeId) {
        if (cubeId == null) {
            throw new ArgumentException("cube id" + REQUIRED_MSG);
        }
        this.cubeId = cubeId;
    }

    public DateTime getOrientationDate() {
        return orientationDate;
    }

    public void setOrientationDate(DateTime orientationDate) {
        if (orientationDate == null) {
            throw new ArgumentException("orientationDate" + REQUIRED_MSG);
        }
        this.orientationDate = orientationDate;
    }

    public void printReport() {
        reportService.outputReport();
    }

    
    public string toString() {
        return "Employee{" + "firstName=" + firstName + ", lastName=" + lastName + ", ssn=" + ssn + '}';
    }
    }
}