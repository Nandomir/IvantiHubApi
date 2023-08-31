namespace IvantiHubApi.Tests.Bindings.Models.Validators.TriangleVerticesModelValidator
{
    using FluentValidation.Results;
    using IvantiHubApi.Models;
    using IvantiHubApi.Models.Validators;

    public class TriangleVerticesModelValidatorContext
    {
        public TriangleVerticesModelValidatorContext()
        {
            this.Validator = new TriangleVerticesModelValidator();
        }

        public TriangleVerticesModel TriangleVerticesModel { get; set; }

        public ValidationResult ValidationResult { get; set; }

        public TriangleVerticesModelValidator Validator { get; set; }
    }
}
