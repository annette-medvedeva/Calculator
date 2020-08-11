Feature: DivisionOperation
	I order To have For fast and accurate division
	As a user
	I want to able to divide numbers

Background:
	Given Web calculator open in the browser

Scenario Outline: Integer division
	When I press <first number>
	When I click on division
	When I press <second number>
	When I click equal
	Then <result> should be on the screen

	Examples:
		| first number | second number | result |
		| 5            | 2             | 2.5    |

Scenario Outline: Fractional division
	When I press <first number_part1> 
	When I click point button
	When I press <first number_part2 > 
	When I click on division
	When I press <second number>
	When I click equal
	Then <result> should be on the screen

	Examples:
		| first number_part1 | first number_part2 | second number | result |
		| 4                  | 5                  | 3             | 1.5    |

Scenario Outline: Division of integers and fractional numbers
	When I press <first number>
	When I click on division
	When I press <second number_part1>
	When I click point button
	When I press <second number_part2>
	When I click equal
	Then <result> should be on the screen

	Examples:
		| first number | second number_part1 | second number_part2 | result |
		| 2            | 0                   | 5                   | 4      |

Scenario Outline: Division by zero
	When I press <first number>
	When I click on division
	When I press <second number>
	When I click equal
	Then <result> should be on the screen

	Examples:
		| first number | numeral2 | result |
		| 1            | 0        | Error  |