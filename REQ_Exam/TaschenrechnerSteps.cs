using System;
using TechTalk.SpecFlow;
using Xunit;

namespace REQ_Exam
{
    [Binding]
    public class TaschenrechnerSteps
    {
        string option;
        Double digit;
        Double result;

        [Given(@"the option is (.*)")]
        public void GivenTheOptionIs(string p0)
        {
            option = p0;
        }
        
        [Given(@"the parameter is (.*)")]
        public void GivenTheParameterIs(Double p0)
        {
            digit = p0;
        }
        
        [When(@"the calculate button is pressed")]
        public void WhenTheCalculateButtonIsPressed()
        {
            if (option == "sinus")
            {
                result = Math.Sin(Math.PI);
            }else if (option == "tangens")
            {
                result = Math.Tan(Math.PI);
            }else if (option == "cosinus")
            {
                result = Math.Cos(Math.PI);
            }
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            if (option == "sinus")
            {
                Assert.Equal(p0, result, 5);
            }
            else if (option == "tangens")
            {
                Assert.Equal(p0, result, 5);
            }
            else if (option == "cosinus")
            {
                Assert.Equal(p0, result, 5);
            }
        }
    }
}
