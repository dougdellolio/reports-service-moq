using ReportService;

namespace ReportsService
{
    public class ReportsService
    {
        private readonly IReportsProvider ReportsProvider;

        public ReportsService(IReportsProvider reportsProvider)
        {
            ReportsProvider = reportsProvider;
        }

        public string Generate(string title)
        {
            var reports = ReportsProvider.GetAllReports();

            foreach (var report in reports)
            {
                if (report.Title == title)
                {
                    return report.Generate();
                }
            }

            return null; //fix if report not found
        }
    }
}
