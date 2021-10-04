﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Atlassian.Jira
{
    /// <summary>
    /// Represents the operations on the issue statuses of jira.
    /// Maps to https://docs.atlassian.com/jira/REST/latest/#api/2/status.
    /// </summary>
    public interface IIssueStatusService
    {
        /// <summary>
        /// Returns all the issue statuses within JIRA.
        /// </summary>
        /// <param name="token">Cancellation token for this operation.</param>
        Task<IEnumerable<IssueStatus>> GetStatusesAsync(CancellationToken token = default(CancellationToken));

        /// <summary>
        /// Returns a full representation of the status having the given id or name.
        /// </summary>
        /// <param name="idOrName">The status identifier or name.</param>
        /// <param name="token">Cancellation token for this operation.</param>
        Task<IssueStatus> GetStatusAsync(string idOrName, CancellationToken token = default(CancellationToken));
    }
}