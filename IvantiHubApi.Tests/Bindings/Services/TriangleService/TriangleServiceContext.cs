namespace IvantiHubApi.Tests.Bindings.Services.TriangleService
{
    using IvantiHubApi.Models;
    using IvantiHubApi.Services.Triangle;

    public class TriangleServiceContext
    {
        public TriangleServiceContext()
        {
            TriangleService = new TriangleService();
        }

        public TriangleService TriangleService { get; set; }

        public char Row { get; set; }

        public int Col { get; set; }

        public TriangleVerticesModel VerticesModel { get; set; }

        public TriangleVerticesModel CalculatedVerticesModel { get; set; }

        public string CalculatedRowCol { get; set; }
    }

}
