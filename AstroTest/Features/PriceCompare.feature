Feature: PriceCompare
	In order to compare iPhone8 price 
	As a user
	I search for iPhone8 in Amazon and Ebay website and compare the result by assending order


Scenario: Search iPhone8 in Amazon and Ebay and compare price
	Given I am on Amazon website
	And I search for iPhone in amazon
	And I get price in amazon
	And I am on Ebay website
	And I search for iPhone in ebay
	And I get price in ebay
	When I compare both price
	Then the result should sort in ascending order
