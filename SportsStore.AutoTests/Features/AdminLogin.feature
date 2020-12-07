Feature: AdminLogin

Scenario: User can login as admin with correct username and password
Given Admin panel of website is opened
When I enter username 'Admin'
And I enter password ''
Then I am authorized as admin