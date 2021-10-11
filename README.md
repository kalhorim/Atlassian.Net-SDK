# Atlassian.NET SDK

Contains utilities for interacting with  [Atlassian JIRA](http://www.atlassian.com/software/jira).

This repository creates for syncing with [Atlassian.Net SDK](https://bitbucket.org/farmas/atlassian.net-sdk). And solve issues in this repo.
So, for more information, visit the primary site [(Atlassian.Net SDK)](https://bitbucket.org/farmas/atlassian.net-sdk).

# Change List for this repo

- Solve [Issue #586 expected Object](https://bitbucket.org/farmas/atlassian.net-sdk/issues/586/expected-object)

	By this solution [Jira API - Insight object customfield](https://community.atlassian.com/t5/Jira-Service-Management/Jira-API-Insight-object-customfield/qaq-p/1276723)

	Some custom Insight fields have 'expected Object' or 'data was not an array' when saving.

	I create overload for AddArray method to get object array. for example:
	
	```
	issue.CustomFields.AddArray("InsightFieldName", new { key = CustomInsightId });
	```

- Sync with 12.4.0


# Test Environment and docker

Next, we will produce a valid test environment by docker image for testing any issues that can cause in this repository.