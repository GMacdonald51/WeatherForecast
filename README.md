# WeatherForecast
Project for Wipro technical test

Running the Solution:
This solution has been written using Selenium WebDriver in C# using MS Visual Studio (Community Edition) as the IDE.
To run this solution, first install a version of MS Visual Studio.
Then:
In Git Hub, click on Clone or Download then select Download Zip
Paste the downloaded zip file into a suitable folder then Extract All the files
Open the extracted folder and click on WiproTestProject.sln file.
Select BuildBuild Solution from within Visual Studio.
From the Test Explorer Window, select the test(s) you want to run and then right click and select Run Selected Tests (Select Test->Windows->Test Explorer if window not already displayed)

Further testing if time had permitted:
As mentioned in the comments in the feature file, for the sake of brevity, I just checked the first day and only 1 city. If done for real, all the days would be checked for multiple cities. The same applies to the other scenarios.
I would also have checked that the correct values were displayed in each field (assuming that the test data was under our control and so predictable). 

Although not asked for in requirements, I did include a negative test, as you should always check for bad input data.

Observations
There are pressure data displayed in the forecast, but since they not mentioned in the requirements I have not tested them. In a real situation I would consult with the BA to see if this is meant to be in the application and, if so, what the requirements are. I would also seek clarification around what is meant by current/most dominant conditions as current conditions can only apply to the first day (which is what I have tested). It looks like the dominant conditions are not summarised correctly.






