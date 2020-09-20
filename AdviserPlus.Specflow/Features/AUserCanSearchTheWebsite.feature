Feature: AUserCanSearchTheWebsite
	As a user
	I want to be able to search the website
	So that I can easily find the desired content

Scenario: A search term with no results
	Given the search form contains an invalid value
	When I submit the search form
	Then I am redirected to the results page
	And "No results could be found..." message is displayed