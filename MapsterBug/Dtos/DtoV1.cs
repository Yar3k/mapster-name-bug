namespace MapsterBug.Dtos;

public record DtoV1
(
    DateOnly Date,
    int TemperatureC,
    int TemperatureF,
    string? Summary,
    Coordinates? AreaCoordinates
);
public record Coordinates
(
    string? ETRS89z32Ecoordinate,
    string? ETRS89z32Ncoordinate,
    string? Xcoordinate,
    string? Ycoordinate
);
public record DtoV2
(
    DateOnly Date,
    int TemperatureC,
    int TemperatureF,
    string? Summary,
    AreaCoordinates? AreaCoordinates
);