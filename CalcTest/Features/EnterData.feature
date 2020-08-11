Feature: EnterData
	In order to enter data for next calculation
	As a user
	I want to have a numbers and operations buttons on the screen of calculator

Background:
	Given Web calculator open in the browser

Scenario Outline: Enter number
	When I press <first number>
	Then <result> should be on the screen

	Examples:
		| first number | result     |
		| 1234567890   | 1234567890 |

Scenario Outline: Start to enter data with point
	When I click point button
	When I press  <first number> 
	Then <result> should be on the screen

	Examples:
		| first number | result      |
		| 1            | 0.1         |
		| 22           | 0.22        |
		| 0            | 0           |

Scenario Outline: Enter dot after symbols
	When I press  <first number_part1> 
	When I click point button
	When I press  <first number_part2> 
	Then <result> should be on the screen

	Examples:
		| first number_part1 | first number_part2 | result      |
		| 1                  | 1                  | 1.1         |
		| 12                 | 12                 | 12.12       |
		| 123                | 123                | 123.123     |
		| 6789               | 6789               | 6789.6789   |
		| 1                  | 124356788          | 1.124356788 |

Scenario Outline: Delete numbers from enter field
	When I press  <first number> 
	When I click AC button
	Then <result> should be on the screen

	Examples:
		| first number | result |
		| 1            | 0      |
		| 22           | 0      |
		| 1234         | 0      |
		| 32323        | 0      |

     

	