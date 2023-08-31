Feature: TriangleService  
  I want to validate the behavior of TriangleService
  As IvantiHubApp
  So that I can be sure it functions as expected

Scenario: Calculate coordinates for an even triangle
  Given the row is 'A' and the column is 2
  When I calculate triangle coordinates
  Then the resulting coordinates should be V1x 0, V1y 0, V2x 10, V2y 0, V3x 10, V3y 10

Scenario: Calculate row and column for a set of vertices
  Given the vertices model with V1x 0, V1y 0, V2x 10, V2y 0, V3x 10, V3y 10
  When I calculate triangle row and column
  Then the resulting row and column should be "A2"
