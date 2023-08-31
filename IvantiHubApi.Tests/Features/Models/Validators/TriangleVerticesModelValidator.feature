Feature: TriangleVerticesModelValidator
    In order to validate the coordinates of a triangle
    As IvantiHubApp
    I want to ensure they are within the specified bounds

Scenario: Validate coordinates for different bounds
    Given I have the TriangleVerticesModel with coordinates V1x <V1x>, V1y <V1y>, V2x <V2x>, V2y <V2y>, V3x <V3x>, and V3y <V3y>
    When I validate the model
    Then the validation result should be <IsValid>

Examples:
    | V1x | V1y | V2x | V2y | V3x | V3y | IsValid |
    | 0   | 0   | 0   | 0   | 0   | 0   | true    |
    | -1  | 0   | 0   | 0   | 0   | 0   | false   |
    | 0   | -1  | 0   | 0   | 0   | 0   | false   |
    | 61  | 0   | 0   | 0   | 0   | 0   | false   |
    | 0   | 61  | 0   | 0   | 0   | 0   | false   |
