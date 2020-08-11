Feature: SumFunction
	In order to  have For fast and accurate sumFunction
	As a user
	I want to able to add numbers

Background:
	Given Web calculator open in the browser

Scenario Outline: Sum two integer numbers
	When I press <first number>
	When I click sum button
	When I press <second number>
	When I click equal
	Then <result> should be on the screen

	Examples:
		| first number | second number | result |
		| 1            | 8             | 9      |

Scenario Outline: Sum two fractional numbers
	When I press <first number_part1>
	When I click point button
	When I press <first number_part2>
	When I click sum button
	When I press <second number_part1>
	When I click point button 
	When I press <second number_part2>
	When I click equal
	Then <result> should be on the screen

	Examples:
		| first number_part1 | first number_part2 | second number_part1 | second number_part2 | result |
		| 2                  | 8                  | 1                   | 5                   | 4.3    |

Scenario Outline: Sum fractional and integer numbers
	When I press <first number_part1>
	When I click point button
	When I press <first number_part2>
	When I click sum button
	When I press <second number>
	When I click equal
	Then <result> should be on the screen

	Examples:
		| first number_part1 | first number_part2 | second number | result |
		| 1                  | 5                  | 5             | 6.5    |