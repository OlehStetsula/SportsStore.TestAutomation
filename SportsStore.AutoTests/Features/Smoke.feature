@smoke
Feature: Smoke

Scenario Outline: Web page is accessible
	When I go to Url '<Url>'
	Then I see page header on the opened '<Url>' page

	Examples: 
	| Url   |
	| Home  |
	| Cart  |
	| Admin |
