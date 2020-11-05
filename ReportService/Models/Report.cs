namespace ReportService.Models
{
    public class Report
    {
        public Report(string title)
        {
            Title = title;
        }

        public string Title { get; set; }

        public string Generate()
        {
            return "generated - path";
        }
    }
}
