# Atlassian.NET SDK

Contains utilities for interacting with  [Atlassian JIRA](http://www.atlassian.com/software/jira).

This repository creates for syncing with [Atlassian.Net SDK](https://bitbucket.org/farmas/atlassian.net-sdk). And solve issues in this repo.
So, for more information, visit the primary site [(Atlassian.Net SDK)](https://bitbucket.org/farmas/atlassian.net-sdk).

# Change List for this repo

- Sync with 12.4.0

- Issue [Issue #586](https://bitbucket.org/farmas/atlassian.net-sdk/issues/586/expected-object)
	Solution [Jira API - Insight object customfield](https://community.atlassian.com/t5/Jira-Service-Management/Jira-API-Insight-object-customfield/qaq-p/1276723)
	Some Custome fields In Insight have problem to save. For example, you can face with 'expected Object' Or 'data was not an array' errors.
	creating overload of AddArray to get object array. for example:
	
	```
	issue.CustomFields.AddArray("InsightFieldName", new { key = CustomInsightId });
	```

# Test Environment and docker

Next, we will produce a valid test environment by docker image for testing any issues that can cause in this repository.