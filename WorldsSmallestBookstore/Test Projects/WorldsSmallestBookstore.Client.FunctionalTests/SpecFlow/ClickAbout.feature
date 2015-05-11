Feature: ClickAbout
	As Fred
	I want to see the About Page
	So that I can find out more information on the World's Smallest Online Bookstore

@mytag
Scenario: Click the About Page
	Given I am on the Home Page
	When I click About link
	Then the about Page will show on the screen
