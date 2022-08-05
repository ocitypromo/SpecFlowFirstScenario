using System;
using TechTalk.SpecFlow;

namespace SpecFlowFirstScenario.StepDefinitions
{
    [Binding]
    public class RetrieveLocationDataStepDefinitions
    {
        [Given(@"the country code us and zip code (.*)")]
        public void GivenTheCountryCodeUsAndZipCode(int p0)
        {
           
        }

        [When(@"I request the locations corresponding to these codes")]
        public void WhenIRequestTheLocationsCorrespondingToTheseCodes()
        {
            
        }

        [Then(@"the response contains the place name Beverly Hills")]
        public void ThenTheResponseContainsThePlaceNameBeverlyHills()
        {
           
        }

        [Then(@"the response contains exactly (.*) locaton")]
        public void ThenTheResponseContainsExactlyLocaton(int p0)
        {
           
        }
    }
}
