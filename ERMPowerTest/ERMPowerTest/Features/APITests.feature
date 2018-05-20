Feature: APITests

Scenario: Validate login details for given id
	Given I get all login objects from the web service
	| ApiUrl                                     |
	| https://jsonplaceholder.typicode.com/posts |
	When I provide Id '97' to get specific login details
	Then I should receive correct login details
	| userId | title                                      | body                                                                                                                                                                                                                       |
	| 10     | quas fugiat ut perspiciatis vero provident | eum non blanditiis soluta porro quibusdam voluptas\nvel voluptatem qui placeat dolores qui velit aut\nvel inventore aut cumque culpa explicabo aliquid at\nperspiciatis est et voluptatem dignissimos dolor itaque sit nam |

Scenario: Validate total number of records returned by web service
	Given I get all login objects from the web service
	| ApiUrl                                     |
	| https://jsonplaceholder.typicode.com/posts |
	Then I should get '100' number of records