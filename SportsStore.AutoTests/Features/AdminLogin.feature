Feature: AdminLogin

Scenario: User can login as admin with correct username and password
Given Admin panel of website is opened
When I enter username 'Admin' and password 'Secret123$'
Then I am authorized as admin