using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using WiproTestProject.Utilities;

namespace WiproTestProject.Pages
{
    public class ForecastPage
    {
        //Constructor
        public ForecastPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver,this);
        }

        //Fields
        [FindsBy(How = How.Id, Using = "city")]
        private IWebElement cityField;

        [FindsBy(How = How.CssSelector, Using = "[data-test='error']")]
        private IWebElement errorMessage;

        [FindsBy(How = How.CssSelector, Using = "[data-test='day-1']")]
        private IWebElement dayOne;
        [FindsBy(How = How.CssSelector, Using = "[data-test='day-2']")]
        private IWebElement dayTwo;
        [FindsBy(How = How.CssSelector, Using = "[data-test='day-3']")]
        private IWebElement dayThree;
        [FindsBy(How = How.CssSelector, Using = "[data-test='day-4']")]
        private IWebElement dayFour;
        [FindsBy(How = How.CssSelector, Using = "[data-test='day-5']")]
        private IWebElement dayFive;

        [FindsBy(How = How.CssSelector, Using = "[data-test='date-1']")]
        private IWebElement dateOne;
        [FindsBy(How = How.CssSelector, Using = "[data-test='date-2']")]
        private IWebElement dateTwo;
        [FindsBy(How = How.CssSelector, Using = "[data-test='date-3']")]
        private IWebElement dateThree;
        [FindsBy(How = How.CssSelector, Using = "[data-test='date-4']")]
        private IWebElement dateFour;
        [FindsBy(How = How.CssSelector, Using = "[data-test='date-5']")]
        private IWebElement dateFive;

        [FindsBy(How = How.CssSelector, Using = "[data-test='description-1']")]
        private IWebElement descriptionOne;
        [FindsBy(How = How.CssSelector, Using = "[data-test='description-2']")]
        private IWebElement descriptionTwo;
        [FindsBy(How = How.CssSelector, Using = "[data-test='description-3']")]
        private IWebElement descriptionThree;
        [FindsBy(How = How.CssSelector, Using = "[data-test='description-4']")]
        private IWebElement descriptionFour;
        [FindsBy(How = How.CssSelector, Using = "[data-test='description-5']")]
        private IWebElement descriptionFive;

        [FindsBy(How = How.CssSelector, Using = "[data-test='maximum-1']")]
        private IWebElement maxOne;
        [FindsBy(How = How.CssSelector, Using = "[data-test='maximum-2']")]
        private IWebElement maxTwo;
        [FindsBy(How = How.CssSelector, Using = "[data-test='maximum-3']")]
        private IWebElement maxThree;
        [FindsBy(How = How.CssSelector, Using = "[data-test='maximum-4']")]
        private IWebElement maxFour;
        [FindsBy(How = How.CssSelector, Using = "[data-test='maximum-5']")]
        private IWebElement maxFive;

        [FindsBy(How = How.CssSelector, Using = "[data-test='minimum-1']")]
        private IWebElement minOne;
        [FindsBy(How = How.CssSelector, Using = "[data-test='minimum-2']")]
        private IWebElement minTwo;
        [FindsBy(How = How.CssSelector, Using = "[data-test='minimum-3']")]
        private IWebElement minThree;
        [FindsBy(How = How.CssSelector, Using = "[data-test='minimum-4']")]
        private IWebElement minFour;
        [FindsBy(How = How.CssSelector, Using = "[data-test='minimum-5']")]
        private IWebElement minFive;

        [FindsBy(How = How.CssSelector, Using = "[data-test='speed-1']")]
        private IWebElement speedOne;
        [FindsBy(How = How.CssSelector, Using = "[data-test='speed-2']")]
        private IWebElement speedTwo;
        [FindsBy(How = How.CssSelector, Using = "[data-test='speed-3']")]
        private IWebElement speedThee;
        [FindsBy(How = How.CssSelector, Using = "[data-test='speed-4']")]
        private IWebElement speedFour;
        [FindsBy(How = How.CssSelector, Using = "[data-test='speed-5']")]
        private IWebElement speedFive;

        [FindsBy(How = How.CssSelector, Using = "[data-test='direction-1']")]
        private IWebElement directionOne;
        [FindsBy(How = How.CssSelector, Using = "[data-test='direction-2']")]
        private IWebElement directionTwo;
        [FindsBy(How = How.CssSelector, Using = "[data-test='direction-3']")]
        private IWebElement directionThree;
        [FindsBy(How = How.CssSelector, Using = "[data-test='direction-4']")]
        private IWebElement directionFour;
        [FindsBy(How = How.CssSelector, Using = "[data-test='direction-5']")]
        private IWebElement directionFive;

        [FindsBy(How = How.CssSelector, Using = "[data-test='rainfall-1']")]
        private IWebElement rainfallOne;
        [FindsBy(How = How.CssSelector, Using = "[data-test='rainfall-2']")]
        private IWebElement rainfallTwo;
        [FindsBy(How = How.CssSelector, Using = "[data-test='rainfall-3']")]
        private IWebElement rainfallThree;
        [FindsBy(How = How.CssSelector, Using = "[data-test='rainfall-4']")]
        private IWebElement rainfallFour;
        [FindsBy(How = How.CssSelector, Using = "[data-test='rainfall-5']")]
        private IWebElement rainfallFive;

        //Methods
        public void EnterCity(string cityName)
        {
            cityField.Clear();
            Driver.EnterText(cityField, cityName);
            Driver.PressEnter(cityField);
        }

        public Boolean CityFieldDisplayed()
        {
            Driver.WaitForElement(cityField);
            return cityField.Displayed;
        }
        
        public Boolean DayFieldsDisplayed()
        {
            Boolean AllDaysDisplayed = false;

            if(dayOne.Displayed && dayTwo.Displayed && dateThree.Displayed 
                && dayFour.Displayed && dayFive.Displayed)                
                AllDaysDisplayed = true;
            
            return AllDaysDisplayed;
        }

        public Boolean DateFieldsDisplayed()
        {
            Boolean AllDatesDisplayed = false;
            
            if (dateOne.Displayed && dateTwo.Displayed && dateThree.Displayed
                && dateFour.Displayed && dateFive.Displayed)
                AllDatesDisplayed = true;
            
            return AllDatesDisplayed;
        }
        
        public Boolean MainDescriptionFieldsDisplayed()
        {
            Boolean MainDescriptionsAllPresent = false;
            
            if (descriptionOne.Displayed && descriptionTwo.Displayed && descriptionThree.Displayed
                && descriptionFour.Displayed && descriptionFive.Displayed)
                MainDescriptionsAllPresent = true;

            return MainDescriptionsAllPresent;
        }

        public Boolean MainMaxTempFieldsDisplayed()
        {
            Boolean MainMaxTempAllPresent = false;

            if (maxOne.Displayed && maxTwo.Displayed && maxThree.Displayed
                && maxFour.Displayed && maxFive.Displayed)
                MainMaxTempAllPresent = true;

            return MainMaxTempAllPresent;
        }

        public Boolean MainMinTempFieldsDisplayed()
        {
            Boolean MainMinTempAllPresent = false;

            if (minOne.Displayed && minTwo.Displayed && minThree.Displayed
                && minFour.Displayed && minFive.Displayed)
                MainMinTempAllPresent = true;

            return MainMinTempAllPresent;
        }

        public Boolean MainSpeedFieldsDisplayed()
        {
            Boolean MainSpeedAllPresent = false;

            if (speedOne.Displayed && speedTwo.Displayed && speedThee.Displayed
                && speedFour.Displayed && speedFive.Displayed)
                MainSpeedAllPresent = true;

            return MainSpeedAllPresent;
        }

        public Boolean MainDirectionFieldsDisplayed()
        {
            Boolean MainDirectionAllPresent = false;

            if (directionOne.Displayed && directionTwo.Displayed && directionThree.Displayed
                && directionFour.Displayed && directionFive.Displayed)
                MainDirectionAllPresent = true;

            return MainDirectionAllPresent;
        }

        public Boolean MainRainfallFieldsDisplayed()
        {
            Boolean MainRainfallAllPresent = false;

            if (rainfallOne.Displayed && rainfallTwo.Displayed && rainfallThree.Displayed
                && rainfallFour.Displayed && rainfallFive.Displayed)
                MainRainfallAllPresent = true;

            return MainRainfallAllPresent;
        }

        public void clickDayOne()
        {
            Driver.clickOnElement(dayOne);
        }

        public Boolean AllElementsDisplayedFor3HourForecast()
        {
            //To save having to find each individual element in the 3 hour forecast,
            //this finds lists of each element group by using the ^= matcher
            //which matches on elements beginning with the specified string
            IList<IWebElement> hourList
                = Driver.driver.FindElements(By.CssSelector("[data-test^='hour-1-']"));
            IList<IWebElement> descriptionList
                        = Driver.driver.FindElements(By.CssSelector("[data-test^='description-1-']"));
            IList<IWebElement> maxtempList
                        = Driver.driver.FindElements(By.CssSelector("[data-test^='maximum-1-']"));
            IList<IWebElement> mintempList
                        = Driver.driver.FindElements(By.CssSelector("[data-test^='minimum-1-']"));
            IList<IWebElement> speedList
                        = Driver.driver.FindElements(By.CssSelector("[data-test^='speed-1-']"));
            IList<IWebElement> directionList
                        = Driver.driver.FindElements(By.CssSelector("[data-test^='direction-1-']"));
            IList<IWebElement> rainfaillList
                        = Driver.driver.FindElements(By.CssSelector("[data-test^='rainfall-1-']"));
            Boolean allElementsDisplayed = true;

            allElementsDisplayed = checkElementsInListDisplayed(hourList);
            allElementsDisplayed = checkElementsInListDisplayed(descriptionList);
            allElementsDisplayed = checkElementsInListDisplayed(maxtempList);
            allElementsDisplayed = checkElementsInListDisplayed(mintempList);
            allElementsDisplayed = checkElementsInListDisplayed(speedList);
            allElementsDisplayed = checkElementsInListDisplayed(directionList);
            allElementsDisplayed = checkElementsInListDisplayed(rainfaillList);

            return allElementsDisplayed;

        }

        private Boolean checkElementsInListDisplayed(IList<IWebElement> listToCheck)
        {
            Boolean status = true;
            foreach (IWebElement element in listToCheck)
                if (!element.Displayed)
                    status = false;
            return status;

        }

        public Boolean CheckIf3DayForecastDisplayed()
        {
            Boolean forecastDisplayed = true;

            IList<IWebElement> hourList
                = Driver.driver.FindElements(By.CssSelector("[data-test^='hour-1-']"));

            forecastDisplayed = checkElementsInListDisplayed(hourList);

            return forecastDisplayed;

        }

        public Boolean CheckCurrentConditionDisplayedInSummary()
        {
            Boolean currentAndSummarisedMatch = false;

            IWebElement summarisedCondition= 
                Driver.driver.FindElement(By.CssSelector("[data-test='description-1']"));
            IWebElement currentCondtion =
                Driver.driver.FindElement(By.CssSelector("[data-test='description-1-1']"));

            if (summarisedCondition.GetAttribute("aria-label") == currentCondtion.GetAttribute("aria-label"))
                currentAndSummarisedMatch = true;

            return currentAndSummarisedMatch;
        }
      
        private List<int> getMaxTempList()
        {
            IList<IWebElement> maxTempElements =
                Driver.driver.FindElements(By.CssSelector("[data-test^='maximum-1-']"));
            List<int> tempsList = new List<int>();

            //Strip off the degree symbol and create list of temps
            foreach (IWebElement ele in maxTempElements)
            {
                string theString = ele.Text;
                char lastChar = '°';
                string temp = theString.TrimEnd(lastChar);
                
                tempsList.Add(int.Parse(temp));
            }
            
            return tempsList;

        }

        private List<int> getMinTempList()
        {
            IList<IWebElement> minTempElements =
                Driver.driver.FindElements(By.CssSelector("[data-test^='minimum-1-']"));
            List<int> tempsList = new List<int>();

            //Strip off the degree symbol and create list of temps
            foreach (IWebElement ele in minTempElements)
            {
                string theString = ele.Text;
                char lastChar = '°';
                string temp = theString.TrimEnd(lastChar);

                tempsList.Add(int.Parse(temp));
            }

            return tempsList;

        }

        private List<int> getRainfallList()
        {
            IList<IWebElement> rainfallElements =
                Driver.driver.FindElements(By.CssSelector("[data-test^='rainfall-1-']"));
            List<int> rainfallList = new List<int>();

            //Strip off the mm symbol and create list of temps
            foreach (IWebElement ele in rainfallElements)
            {
                string theString = ele.Text;
                string rainfall = theString.Remove(theString.Length - 2);
                
                rainfallList.Add(int.Parse(rainfall));
            }

            return rainfallList;

        }

        public Boolean CheckHighestTempDisplayedInSummary()
        {
            Boolean highestAndSummarisedMatch = false;
            List<int> tempList = getMaxTempList();

            //find max temp
            int highestTemp = tempList.Max();

            //Strip off the degree symbol
            string theString = maxOne.Text;
            char lastChar = '°';
            string temp = theString.TrimEnd(lastChar);

            if (temp == highestTemp.ToString())
                highestAndSummarisedMatch = true;
            
            return highestAndSummarisedMatch;
        }

        public Boolean CheckLowestTempDisplayedInSummary()
        {
            Boolean lowestAndSummarisedMatch = false;
            List<int> tempList = getMinTempList();

            //find min temp
            int lowestTemp = tempList.Min();

            //Strip off the degree symbol from the summary
            string theString = minOne.Text;
            char lastChar = '°';
            string temp = theString.TrimEnd(lastChar);

            if (temp == lowestTemp.ToString())
                lowestAndSummarisedMatch = true;

            return lowestAndSummarisedMatch;
        }

        public Boolean CheckCurrentWindspeedDisplayedInSummary()
        {
            Boolean currentAndSummarisedMatch = false;
            IWebElement summarisedWindspeed =
                Driver.driver.FindElement(By.CssSelector("[data-test='speed-1']"));
            IWebElement currentWindspeed =
                Driver.driver.FindElement(By.CssSelector("[data-test='speed-1-1']"));
                        
            if (summarisedWindspeed.Text == currentWindspeed.Text)
                currentAndSummarisedMatch = true;
            
            return currentAndSummarisedMatch;
        }

        public Boolean CheckCurrentWindDirectionDisplayedInSummary()
        {
            Boolean currentAndSummarisedMatch = false;

            //Wind directions do have any data-test attribute. This might mean that I am 
            //not really expected to check this, but requirements say that I should and this
            //seems be the easiest way to get hold of the part that contains 
            //the rotate(degrees) information.
            IList<IWebElement> windDirections = 
                Driver.driver.FindElements(By.CssSelector("[viewBox='0 0 32 32']"));
            if (windDirections[0].GetAttribute("style") == windDirections[1].GetAttribute("style"))
                currentAndSummarisedMatch = true;
            
            return currentAndSummarisedMatch;
        }

        public Boolean CheckAggRainfallDisplayedInSummary()
        {
            Boolean aggregateAndSummarisedMatch = false;
            List<int> rainfallList = getRainfallList();

            //calculate aggregate rainfall
            int aggRainfall = rainfallList.Sum();

            //Strip off the mm symbol from the summary
            string theString = rainfallOne.Text;
            string rainfall = theString.Remove(theString.Length - 2);

            if (rainfall == aggRainfall.ToString())
                aggregateAndSummarisedMatch = true;
          
            return aggregateAndSummarisedMatch;
        }

        public Boolean CheckErrorMsgDisplayed()
        {
            Boolean errorMsgDisplayed = false;

            try
            {
                Driver.WaitForElement(errorMessage);
                errorMsgDisplayed = true;
                return errorMsgDisplayed;
            }
            catch (Exception) 
            {
                return errorMsgDisplayed;
            }

            
        }
    }
}
