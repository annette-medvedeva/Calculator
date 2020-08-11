    Feature: AfterEqual
	In order to make long calculation
	As a user
	I want to perform action after pressed equal

   Background:
	Given Web calculator open in the browser

   Scenario Outline: Action after Equel
	When I press <first number> 
	When I press <action1>
	When I press <second number> 
	When I click equal
	When I press <action2>
	When I press <third number> 
	When I click equal
	Then <result> should be on the screen

	Examples:
		| first number | action1 | second number | action2 | third number | result   |
		| 10           | +       | 3             | *       | 5            | 65       |
		| 111          | -       | 77            | /       | 64           | 0.53125  |
		| 89           | *       | 100           | *       | 4            | 35600    |
		| 10           | -       | 88            | +       | 11           | -67      |

		 Scenario Outline: Click twice Equel after action
		 When I press <first number> 
		 When I press <action1>
		 When I press <second number> 
		 When I click equal
		 Then <result> should be on the screen

		 Examples:
		| first number | action1 | second number | result |
		| 5            | +       | 2             | 9      |
		| 7            | *       | 4             | 112    |
		| 5            | -       | 2             | 1      |
		| 10000        | /       | 10            | 100    |