public class Address : BaseValueObject
{
    public Address()
    {
        
    }
    public string? Street { get;  set; }
    public string? City { get;  set; }
    public string? State { get;  set; }
    public string? PostalCode { get;  set; }
    public string? Country { get;  set; }
    public Address(string street, string city, string state, string postalCode, string country)
    {
        Street = street;
        City = city;
        State = state;
        PostalCode = postalCode;
        Country = country;
    }
    protected override bool EqualsCore(object obj)
    {
        var other = obj as Address;
        return Street == other.Street &&
               City == other.City &&
               State == other.State &&
               PostalCode == other.PostalCode &&
               Country == other.Country;
    }
    protected override int GetHashCodeCore()
    {
        return HashCode.Combine(Street, City, State, PostalCode, Country);
    }
}
