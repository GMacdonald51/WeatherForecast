Feature: WeatherForecastFeature1
	In order to check that the forecast application works
	As a user
	I want to be told the forcast details for specified cities

@mytag
Scenario Outline: Get 5 day forecast for Various Cities
	Given I am on the forecast page
	When I have entered '<city>' into the city field and pressed Enter
	Then forecast details for all five days should be displayed on the screen
	Examples:
	| city      |
	| Aberdeen  |
	| Dundee    |
	| Edinburgh |
	| Glasgow   |
	| Perth     |
	| sTirling  |
#Mixed case used on purpose in last example just to check for case sensitivity. 
#If it failed, this would be reported back to see if it should be in requirements

Scenario: Display and hide 3 hourly forecast
Given I am on the forecast page with a five day forecast displayed for 'Dundee'
When I click on a day
Then the three hourly forecast details for that date should be displayed on the screen
And the three hourly forecast details are hidden when I click on the day again
#For the sake of brevity, this just checks the first day and only 1 city. If done for real, all the 
#days would be checked for multiple cities. The same applies to the other scenarios.

Scenario: Current condition is shown in summary
Given I am on the forecast page with a five day forecast displayed for 'Dundee'
When I click on a day
Then the three hourly forecast details for that date should be displayed on the screen
And the summarised condition matches the current condition

Scenario: Max temp and min temp shown in the summary
Given I am on the forecast page with a five day forecast displayed for 'Dundee'
When I click on a day
Then the three hourly forecast details for that date should be displayed on the screen
And the summarised max and min temps match the values in the three hourly forecast

Scenario: WindSpeed and Direction shown in the summary
Given I am on the forecast page with a five day forecast displayed for 'Dundee'
When I click on a day
Then the three hourly forecast details for that date should be displayed on the screen
And the summarised windspeed and direction match the current values

Scenario: Aggregate Rainfall shown in the summary
Given I am on the forecast page with a five day forecast displayed for 'Dundee'
When I click on a day
Then the three hourly forecast details for that date should be displayed on the screen
And the aggregate rainfall is shown in the summary

#Negative test
Scenario: Display error message if city name not recognised
Given I am on the forecast page
When I have entered 'London' into the city field and pressed Enter
Then An error message should be displayed on the screen