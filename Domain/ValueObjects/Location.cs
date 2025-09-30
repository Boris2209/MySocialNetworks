namespace Domain.ValueObjects;

public record Location
{
    public string Country { get; } = default!;
    public string Region { get; } = default!;
    public string City { get; } = default!;
    public string State { get; } = default!;
    public string HouseNumber { get; } = default!;
    public string Index { get; } = default!;

    private Location(string country, string region, string city, string state, string houseNumber, string index)
    {
        Country = country;
        Region = region;
        City = city;
        State = state;
        HouseNumber = houseNumber;
        Index = index;
    }

    public static Location Of(string country, string region, string city, string state, string houseNumber, string index)
    {
        //Проверка на отсутствие значения
        ArgumentException.ThrowIfNullOrWhiteSpace(country);
        ArgumentException.ThrowIfNullOrWhiteSpace(region);
        ArgumentException.ThrowIfNullOrWhiteSpace(city);
        ArgumentException.ThrowIfNullOrWhiteSpace(state);
        ArgumentException.ThrowIfNullOrWhiteSpace(houseNumber);
        ArgumentException.ThrowIfNullOrWhiteSpace(index);

        return new Location(country, region, city, state, houseNumber, index);
    }

}
