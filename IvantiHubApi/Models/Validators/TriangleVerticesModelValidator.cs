namespace IvantiHubApi.Models.Validators
{
    using FluentValidation;

    /// <summary>
    /// Model validation logic for the <see cref="TriangleVerticesModel"/>.
    /// </summary>
    public class TriangleVerticesModelValidator : AbstractValidator<TriangleVerticesModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TriangleVerticesModelValidator"/> class.
        /// </summary>
        public TriangleVerticesModelValidator()
        {
            RuleFor(x => x.V1x)
                .GreaterThanOrEqualTo(0)
                .LessThanOrEqualTo(60)
                .WithMessage("The V1x coordinate must not within the grid layout.");

            RuleFor(x => x.V1y)
                .GreaterThanOrEqualTo(0)
                .LessThanOrEqualTo(60)
                .WithMessage("The V1y coordinate must not within the grid layout.");

            RuleFor(x => x.V2x)
                .GreaterThanOrEqualTo(0)
                .LessThanOrEqualTo(60)
                .WithMessage("The V1x coordinate must not within the grid layout.");

            RuleFor(x => x.V2y)
                .GreaterThanOrEqualTo(0)
                .LessThanOrEqualTo(60)
                .WithMessage("The V2y coordinate must not within the grid layout.");

            RuleFor(x => x.V3x)
                .GreaterThanOrEqualTo(0)
                .LessThanOrEqualTo(60)
                .WithMessage("The V3x coordinate must not within the grid layout.");

            RuleFor(x => x.V3y)
                .GreaterThanOrEqualTo(0)
                .LessThanOrEqualTo(60)
                .WithMessage("The V3y coordinate must not within the grid layout.");
        }
    }
}
