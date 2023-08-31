using IvantiHubApi.Models;

namespace IvantiHubApi.Services.Triangle
{
    /// <summary>
    /// Represents an contract for the for triangle calculation services.
    /// </summary>
    public interface ITriangleService
    {
        /// <summary>
        /// Calculates the vertex coordinates for a given row and column.
        /// </summary>
        /// <param name="row">The row label, from 'A' to 'F'.</param>
        /// <param name="col">The column number, from 1 to 12.</param>
        /// <returns>A model representing the vertex coordinates of the triangle.</returns>
        public TriangleVerticesModel CalculateTriangleCoordinates(char row, int col);

        /// <summary>
        /// Calculates the row and column for a given set of vertex coordinates.
        /// </summary>
        /// <param name="verticesModel">The vertices model containing the vertex coordinates.</param>
        /// <returns>A string representing the row and column labels of the triangle.</returns>
        public string CalculateTriangleRowCol(TriangleVerticesModel verticesModel);
    }
}
