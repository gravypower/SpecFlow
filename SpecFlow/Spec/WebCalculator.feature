@Web
Feature: WebCalculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of numbers

Scenario: Add one number
	Given I have entered 50 into the calculator
	When I press add
	Then the result should be 50 on the screen

Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario: Add three numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	And I have entered 10 into the calculator
	When I press add
	Then the result should be 130 on the screen

Scenario: Add no numbers
	When I press add
	Then the user is presented with an message with error class applyed



