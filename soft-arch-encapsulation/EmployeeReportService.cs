using System;

namespace soft_arch_encapsulation
{
    public class EmployeeReportService
    {
        private string report = "";

    public void addData(string data) {
        report += data;
    }

    public void outputReport() {
        Console.WriteLine(report);
    }

    public void clearReport() {
        report = "";
    }

    }
}