namespace IvantiHubApi.Tests.Bindings.Services.TriangleService
{
    using TechTalk.SpecFlow;

    [Binding]
    [Scope(Feature = "TriangleService")]
    public class WhenSteps
    {
        private readonly TriangleServiceContext context;

        public WhenSteps(TriangleServiceContext context)
        {
            this.context = context;
        }

        [When(@"I calculate triangle coordinates")]
        public void WhenICalculateTriangleCoordinates()
        {
            context.CalculatedVerticesModel = context.TriangleService.CalculateTriangleCoordinates(context.Row, context.Col);
        }

        [When(@"I calculate triangle row and column")]
        public void WhenICalculateTriangleRowAndColumn()
        {
            context.CalculatedRowCol = context.TriangleService.CalculateTriangleRowCol(context.VerticesModel);
        }
    }
}
