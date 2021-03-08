@smoke
Feature: Smoke
	Simple calculator for adding two numbers

Scenario Outline: Web page is accessible and no JS errors on this page
	When I go to Url '<Url>'
	Then I see page header on the opened page
	#And There are no js errors in logs

	Examples: 
	| Url   |
	| Home  |
	| Cart  |
	| Admin |
