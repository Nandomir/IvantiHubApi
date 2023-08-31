namespace IvantiHubApi.Tests.Bindings.Models.Validators.TriangleVerticesModelValidator
{
    using TechTalk.SpecFlow;

    [Binding]
    [Scope(Feature = "TriangleVerticesModelValidator")]
    public class ThenSteps
    {
        private readonly TriangleVerticesModelValidatorContext context;

        public ThenSteps(TriangleVerticesModelValidatorContext context)
        {
            this.context = context;
        }

        [Then(@"the validation result should be (.+)")]
        public void ThenTheValidationResultShouldBe(bool expected)
        {
            Assert.That(context.ValidationResult.IsValid, Is.EqualTo(expected));
        }
    }
}
