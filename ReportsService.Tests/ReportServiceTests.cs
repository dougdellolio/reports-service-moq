using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ReportService;
using ReportService.Models;
using System.Collections.Generic;

namespace ReportsService.Tests
{
    [TestClass]
    public class ReportServiceTests
    {
        [TestMethod]
        public void ShouldGenerateReports()
        {
            var listOfReports = new List<Report>
            {
                new Report("Report1")
            };

            var mock = new Mock<IReportsProvider>();
            mock.Setup(report => report.GetAllReports()).Returns(listOfReports);

            var reportsService = new ReportsService(mock.Object);
            var response = reportsService.Generate("Report1");

            var reportsProvider = mock.Object;

            mock.Verify(rs => rs.GetAllReports(), Times.Exactly(1));

            Assert.AreEqual(response, "generated - path");
        }

        [TestMethod]
        public void ShouldReturnNullWhenThereAreNoMatchingReports()
        {
            var listOfReports = new List<Report>
            {
                new Report("Report1")
            };

            var mock = new Mock<IReportsProvider>();
            mock.Setup(report => report.GetAllReports()).Returns(listOfReports);

            var reportsService = new ReportsService(mock.Object);
            var response = reportsService.Generate("Report5");

            var reportsProvider = mock.Object;

            mock.Verify(rs => rs.GetAllReports(), Times.Exactly(1));

            Assert.AreEqual(response, null);
        }
    }
}
