namespace IvantiHubApi.Tests.Bindings.Models.Validators.TriangleVerticesModelValidator
{
    using TechTalk.SpecFlow;

    [Binding]
    [Scope(Feature = "TriangleVerticesModelValidator")]
    public class WhenSteps
    {
        private readonly TriangleVerticesModelValidatorContext context;

        public WhenSteps(TriangleVerticesModelValidatorContext context)
        {
            this.context = context;
        }

        [When(@"I validate the model")]
        public void WhenIValidateTheModel()
        {
            context.ValidationResult = context.Validator.Validate(context.TriangleVerticesModel);
        }
    }
}
