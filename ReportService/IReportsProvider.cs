using ReportService.Models;
using System.Collections.Generic;

namespace ReportService
{
    public interface IReportsProvider
    {
        List<Report> GetAllReports();
    }
}
