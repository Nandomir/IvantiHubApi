using IvantiHubApi.Models;

namespace IvantiHubApi.Services.Triangle
{
    /// <summary>
    /// Service for triangle-related calculations.
    /// </summary>
    public class TriangleService : ITriangleService
    {
        /// <inheritdoc/>
        public TriangleVerticesModel CalculateTriangleCoordinates(char row, int col)
        {
            var rowIndex = row - 'A';
            var colIndex = (col - 1) / 2;
            var isEvenTriangle = col % 2 == 0;

            int v1x, v1y, v2x, v2y, v3x, v3y;

            v1x = colIndex * 10;
            v1y = rowIndex * 10;

            if (isEvenTriangle)
            {
                v2x = v1x + 10;
                v2y = v1y;

                v3x = v1x + 10;
                v3y = v1y + 10;
            }
            else
            {
                v2x = v1x;
                v2y = v1y + 10;

                v3x = v1x + 10;
                v3y = v1y + 10;
            }

            return new TriangleVerticesModel
            {
                V1x = v1x,
                V1y = v1y,
                V2x = v2x,
                V2y = v2y,
                V3x = v3x,
                V3y = v3y
            };
        }

        /// <inheritdoc/>
        public string CalculateTriangleRowCol(TriangleVerticesModel verticesModel)
        {
            var rowIndex = verticesModel.V1y / 10;
            var colIndex = verticesModel.V1x / 10;

            var row = (char)('A' + rowIndex);

            var isEvenTriangle = (verticesModel.V1y == verticesModel.V2y && verticesModel.V2y != verticesModel.V3y);

            int col;
            if (isEvenTriangle)
            {
                col = colIndex * 2 + 2;
            }
            else
            {
                col = colIndex * 2 + 1;
            }

            return $"{row}{col}";
        }
    }
}
