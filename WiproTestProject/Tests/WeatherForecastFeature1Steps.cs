using TechTalk.SpecFlow;
using WiproTestProject.Utilities;
using WiproTestProject.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace WiproTestProject
{
    [Binding]
    public class WeatherForecastFeature1Steps
    {
        //Class Variables
        ForecastPage theForecastPage;

        //Class Constructor
        public WeatherForecastFeature1Steps()
        {
            theForecastPage = new ForecastPage(Driver.driver);
        }

        [Given(@"I am on the forecast page")]
        public void GivenIAmOnTheForecastPage()
        {
            string forecastPageURL = "https://weather-acceptance.herokuapp.com/";
            string expectedPageTitle = "5 Weather Forecast";

            Driver.NavigateTo(forecastPageURL);
            //Pause() is used to give user time to see what is happening
            //Snychronization is done using explicit WebDriverWaits
            Driver.Pause(2000); 
            Assert.IsTrue(expectedPageTitle == Driver.GetPageTitle(), "check page title");   
        }

        [When(@"I have entered '(.*)' into the city field and pressed Enter")]
        public void WhenIHaveEnteredIntoTheCityFieldAndPressedEnter(string cityName)
        {
            theForecastPage.EnterCity(cityName);
            Driver.Pause(2000);

        }

        [Then(@"forecast details for all five days should be displayed on the screen")]
        public void ThenForecastDetailsForAllFiveDaysShouldBeDisplayedOnTheScreen()
        {
            Assert.IsTrue(theForecastPage.DayFieldsDisplayed(), "check day fields");
            Assert.IsTrue(theForecastPage.DateFieldsDisplayed(), "check date fields");
            Assert.IsTrue(theForecastPage.MainDescriptionFieldsDisplayed(), "check description fields");
            Assert.IsTrue(theForecastPage.MainMaxTempFieldsDisplayed(), "check max temp fields");
            Assert.IsTrue(theForecastPage.MainMinTempFieldsDisplayed(), "check min temp fields");
            Assert.IsTrue(theForecastPage.MainSpeedFieldsDisplayed(), "check speed fields");
            Assert.IsTrue(theForecastPage.MainDirectionFieldsDisplayed(), "check direction fields");
            Assert.IsTrue(theForecastPage.MainRainfallFieldsDisplayed(), "check rainfall fields");
        }

        [Given(@"I am on the forecast page with a five day forecast displayed for '(.*)'")]
        public void GivenIAmOnTheForecastPageWithAFiveDayForecastDisplayedFor(string cityName)
        {
            string forecastPageURL = "https://weather-acceptance.herokuapp.com/";
            string expectedPageTitle = "5 Weather Forecast";

            Driver.NavigateTo(forecastPageURL);
            Driver.Pause(2000);
            Assert.IsTrue(expectedPageTitle == Driver.GetPageTitle(), "check page title");
            theForecastPage.EnterCity(cityName);
            Driver.Pause(2000);
            Assert.IsTrue(theForecastPage.DayFieldsDisplayed(), "check day fields");
        }

        [When(@"I click on a day")]
        public void WhenIClickOnADay()
        {
            theForecastPage.clickDayOne();
            Driver.Pause(2000);
        }

        [Then(@"the three hourly forecast details for that date should be displayed on the screen")]
        public void ThenTheThreeHourlyForecastDetailsForThatDateShouldBeDisplayedOnTheScreen()
        {

            Assert.IsTrue(theForecastPage.AllElementsDisplayedFor3HourForecast(), "check all 3 hourly forecast fields");
        }


        [Then(@"the three hourly forecast details are hidden when I click on the day again")]
        public void ThenTheThreeHourlyForecastDetailsAreHiddenWhenIClickOnTheDayAgain()
        {
            theForecastPage.clickDayOne();
            Driver.Pause(2000);
            Assert.IsFalse(theForecastPage.CheckIf3DayForecastDisplayed(),"check first set of 3 hourly forecast fields");
            Driver.Pause(2000);
        }

        [Then(@"the summarised condition matches the current condition")]
        public void ThenTheSummarisedConditionMatchesTheCurrentCondition()
        {
            Assert.IsTrue(theForecastPage.CheckCurrentConditionDisplayedInSummary(),"check weather condition");
        }

        

        [Then(@"the summarised max and min temps match the values in the three hourly forecast")]
        public void ThenTheSummarisedMaxAndMinTempsMatchTheValuesInTheThreeHourlyForecast()
        {
            Assert.IsTrue(theForecastPage.CheckHighestTempDisplayedInSummary(), "check max temp");
            Assert.IsTrue(theForecastPage.CheckLowestTempDisplayedInSummary(), "check min temp");
        }



        [Then(@"the summarised windspeed and direction match the current values")]
        public void ThenTheSummarisedWindspeedAndDirectionMatchTheCurrentValues()
        {
            Assert.IsTrue(theForecastPage.CheckCurrentWindspeedDisplayedInSummary(), "check windspeed");
            Assert.IsTrue(theForecastPage.CheckCurrentWindDirectionDisplayedInSummary(), "check wind direction");

        }

        [Then(@"the aggregate rainfall is shown in the summary")]
        public void ThenTheAggregateRainfallIsShownInTheSummary()
        {
            Assert.IsTrue(theForecastPage.CheckAggRainfallDisplayedInSummary(), "check aggregate rainfall");
        }

        [Then(@"An error message should be displayed on the screen")]
        public void ThenAnErrorMessageShouldBeDisplayedOnTheScreen()
        {
            Assert.IsTrue(theForecastPage.CheckErrorMsgDisplayed(), "check error message");
        }


    }
}
