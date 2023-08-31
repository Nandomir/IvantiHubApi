namespace IvantiHubApi.Controllers
{
    using FluentValidation;
    using FluentValidation.AspNetCore;
    using IvantiHubApi.Models;
    using IvantiHubApi.Services.Triangle;
    using Microsoft.AspNetCore.Mvc;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Triangle controller for triangle calculations.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [ExcludeFromCodeCoverage(Justification = "Controller does not contain logic to test.")]
    public class TriangleController : ControllerBase
    {
        private readonly IValidator<TriangleVerticesModel> triangleVerticesModelValidator;

        /// <summary>
        /// Initializes a new instance of the <see cref="TriangleController"/> class.
        /// </summary>
        /// <param name="triangleVerticesModelValidator">Validator for the <see cref="TriangleVerticesModel"/>.</param>
        public TriangleController(IValidator<TriangleVerticesModel> triangleVerticesModelValidator)
        {
            this.triangleVerticesModelValidator = triangleVerticesModelValidator;
        }

        /// <summary>
        /// Gets the vertex coordinates based on a given row and column.
        /// </summary>
        [HttpGet("findCoordinates/{row}/{col}")]
        public ActionResult GetTriangleCoordinatesAsync(char row, int col, [FromServices] ITriangleService triangleService)
        {
            if ((row < 'A' || row > 'F') || (col < 1 || col > 12))
            {
                return BadRequest($"Invalid row '{row}' or column '{col}'. Rows should be between A and F, and columns should be between 1 and 12.");
            }

            var result = triangleService.CalculateTriangleCoordinates(row, col);
            return Ok(result);
        }

        /// <summary>
        /// Gets the row and column based on given vertex coordinates.
        /// </summary>
        [HttpPost("findRowCol")]
        public async Task<IActionResult> GetTriangleRowAndColumn([FromBody] TriangleVerticesModel verticesModel, [FromServices] ITriangleService triangleService)
        {
            var result = await triangleVerticesModelValidator.ValidateAsync(verticesModel);

            if (!result.IsValid)
            {
                result.AddToModelState(ModelState);
                return BadRequest(ModelState);
            }
            return Ok(triangleService.CalculateTriangleRowCol(verticesModel));
        }
    }

}
