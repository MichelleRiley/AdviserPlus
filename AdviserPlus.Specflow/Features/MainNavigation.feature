Feature: MainNavigation
	As a user
	I want to navigate the site via a main navigation
	So that I can easily access content

Scenario Outline: Main navigation core links are displayed
	Given I am on the <page>
	Then core pages are displayed in the main navigation

	| Core Pages    |
	| How we help   |
	| Our solutions |
	| Our story     |
	| Resources     |
	| get in touch  |

	Examples:
		| page          |
		| how we help   |
		| our solutions |
		| our story     |
		| resources     |
		| contact       | 

@mobile
Scenario: Mobile view displays hamburger navigation
	Given I am on the homepage
	Then the hamburger navigation icon is present