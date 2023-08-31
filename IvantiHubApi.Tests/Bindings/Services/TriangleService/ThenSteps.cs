namespace IvantiHubApi.Tests.Bindings.Services.TriangleService
{
    using NUnit.Framework;
    using TechTalk.SpecFlow;

    [Binding]
    [Scope(Feature = "TriangleService")]
    public class ThenSteps
    {
        private readonly TriangleServiceContext context;

        public ThenSteps(TriangleServiceContext context)
        {
            this.context = context;
        }

        [Then(@"the resulting coordinates should be V1x (.+), V1y (.+), V2x (.+), V2y (.+), V3x (.+), V3y (.+)")]
        public void ThenTheResultingCoordinatesShouldBe(int v1x, int v1y, int v2x, int v2y, int v3x, int v3y)
        {
            Assert.That(context.CalculatedVerticesModel.V1x, Is.EqualTo(v1x));
            Assert.That(context.CalculatedVerticesModel.V1y, Is.EqualTo(v1y));
            Assert.That(context.CalculatedVerticesModel.V2x, Is.EqualTo(v2x));
            Assert.That(context.CalculatedVerticesModel.V2y, Is.EqualTo(v2y));
            Assert.That(context.CalculatedVerticesModel.V3x, Is.EqualTo(v3x));
            Assert.That(context.CalculatedVerticesModel.V3y, Is.EqualTo(v3y));
        }

        [Then(@"the resulting row and column should be ""(.+)""")]
        public void ThenTheResultingRowAndColumnShouldBe(string expectedRowCol)
        {
            Assert.AreEqual(expectedRowCol, context.CalculatedRowCol);
        }
    }
}
