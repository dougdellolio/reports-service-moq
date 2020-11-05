using ReportService.Models;
using System.Collections.Generic;

namespace ReportService
{
    public class ReportsProvider : IReportsProvider
    {
        public List<Report> GetAllReports()
        {
            return new List<Report>()
            {
                new Report("Report1")
            };
        }
    }
}
