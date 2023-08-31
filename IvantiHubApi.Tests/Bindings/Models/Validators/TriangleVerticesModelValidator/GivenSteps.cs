namespace IvantiHubApi.Tests.Bindings.Models.Validators.TriangleVerticesModelValidator
{
    using IvantiHubApi.Models;
    using TechTalk.SpecFlow;

    [Binding]
    [Scope(Feature = "TriangleVerticesModelValidator")]
    public class GivenSteps
    {
        private readonly TriangleVerticesModelValidatorContext context;

        public GivenSteps(TriangleVerticesModelValidatorContext context)
        {
            this.context = context;
        }

        [Given(@"I have the TriangleVerticesModel with coordinates V1x (.+), V1y (.+), V2x (.+), V2y (.+), V3x (.+), and V3y (.+)")]
        public void GivenIHaveTheTriangleVerticesModelWithCoordinates(int V1x, int V1y, int V2x, int V2y, int V3x, int V3y)
        {
            context.TriangleVerticesModel = new TriangleVerticesModel
            {
                V1x = V1x,
                V1y = V1y,
                V2x = V2x,
                V2y = V2y,
                V3x = V3x,
                V3y = V3y
            };
        }
    }
}
