namespace IvantiHubApi.Tests.Bindings.Services.TriangleService
{
    using IvantiHubApi.Models;
    using TechTalk.SpecFlow;

    [Binding]
    [Scope(Feature = "TriangleService")]
    public class GivenSteps
    {
        private readonly TriangleServiceContext context;

        public GivenSteps(TriangleServiceContext context)
        {
            this.context = context;
        }

        [Given(@"the row is '(.+)' and the column is (.+)")]
        public void GivenTheRowIsAndTheColumnIs(char row, int col)
        {
            context.Row = row;
            context.Col = col;
        }

        [Given(@"the vertices model with V1x (.+), V1y (.+), V2x (.+), V2y (.+), V3x (.+), V3y (.+)")]
        public void GivenTheVerticesModel(int v1x, int v1y, int v2x, int v2y, int v3x, int v3y)
        {
            context.VerticesModel = new TriangleVerticesModel
            {
                V1x = v1x,
                V1y = v1y,
                V2x = v2x,
                V2y = v2y,
                V3x = v3x,
                V3y = v3y
            };
        }
    }
}
