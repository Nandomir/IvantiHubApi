namespace IvantiHubApi.Models
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Represents the coordinates of the vertices of a triangle.
    /// </summary>
    [ExcludeFromCodeCoverage(Justification = "Data model.")]
    public class TriangleVerticesModel
    {
        /// <summary>
        /// Gets or sets the x-coordinate of the first vertex.
        /// </summary>
        public int V1x { get; set; }

        /// <summary>
        /// Gets or sets the y-coordinate of the first vertex.
        /// </summary>
        public int V1y { get; set; }

        /// <summary>
        /// Gets or sets the x-coordinate of the second vertex.
        /// </summary>
        public int V2x { get; set; }

        /// <summary>
        /// Gets or sets the y-coordinate of the second vertex.
        /// </summary>
        public int V2y { get; set; }

        /// <summary>
        /// Gets or sets the x-coordinate of the third vertex.
        /// </summary>
        public int V3x { get; set; }

        /// <summary>
        /// Gets or sets the y-coordinate of the third vertex.
        /// </summary>
        public int V3y { get; set; }
    }

}
