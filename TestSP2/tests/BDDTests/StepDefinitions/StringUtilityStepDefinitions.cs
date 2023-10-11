using TwoKatas;

namespace BDDTests.StepDefinitions
{
    [Binding]
    public sealed class StringUtilityStepDefinitions
    {
        StringUtility stringUtil = new StringUtility();
        string inputString;
        string outputString;

        [Given("the input is a string")]
        public void GivenInputIsAString()
        {
            inputString = "TESTstring";
            stringUtil.setText(inputString);
            typeof(string).IsAssignableFrom(stringUtil.getText().GetType());
        }

        [When("the reverse method is called")]
        public void WhenTheReverseMethodIsCalled()
        {
            outputString = stringUtil.reverse(inputString);
        }

        [Then("the input string should be reversed")]
        public void ThenThInputStringShouldBeReversed()
        {
            Assert.Equal(inputString.Reverse(), outputString);
        }

        [When("the capitalize method is called")]
        public void WhenTheCapitalizeMethodIsCalled()
        {
            outputString = stringUtil.capitalize(inputString);
        }

        [Then("the input string should be capitalized")]
        public void ThenThInputStringShouldBeCapitalized()
        {
            Assert.Equal(inputString.ToUpper(), outputString);
        }

        [When("the lowercase method is called")]
        public void WhenTheLowercaseMethodIsCalled()
        {
            outputString = stringUtil.lowercase(inputString);
        }

        [Then("the input string should be lowercase")]
        public void ThenThInputStringShouldBeLowercase()
        {
            Assert.Equal(inputString.ToLower(), outputString);
        }
    }
}