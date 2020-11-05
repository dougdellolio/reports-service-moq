using Moq;
using ReportService;
using ReportService.Models;
using System;
using System.Collections.Generic;

namespace ReportServiceTests
{
    public class ReportsServiceTests
    {
        //[Test]
        public void ShouldGenerateAReport()
        {
            var listOfReports = new List<Report>
            {
                new Report("Report1")
            };

            var mock = new Mock<IReportsProvider>();
            mock.Setup(report => report.GetAllReports()).Returns(listOfReports);

            var reportsProvider = mock.Object;

            mock.Verify(rs => true);
        }
    }
}
