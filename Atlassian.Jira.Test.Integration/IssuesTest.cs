using System.Linq;
using Xunit;

namespace Atlassian.Jira.Test.Integration
{
    public class IssuesTest
    {
        [Theory]
        [ClassData(typeof(JiraProvider))]
        public void CreateInsightIssue(Jira jira)
        {
            var issue = jira.CreateIssue("SUP");
            var CustomInsightId = "SUP-423609"; // This is key of your insight Options
            issue.CustomFields.AddArray("Server", new { key = CustomInsightId });
            issue.Summary = "Test Summary";
            issue.Description = "Test Description";
            issue.Type = "Service Request";
            issue.SaveChanges();
            var newIssue = jira.Issues.GetIssueAsync(issue.Key.Value).Result;
            Assert.Equal($"({CustomInsightId})", newIssue["Server"].Value.Split(' ').Last());
        }
    }
}
