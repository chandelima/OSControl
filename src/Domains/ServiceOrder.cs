namespace OSControl.Domains;

public class ServiceOrder
{
    public Guid ServiceTypeId { get; set; }
    public ServiceType ServiceType { get; set; }
    public string CustomerName { get; set; }
    public string AddressStreetName { get; set; }
    public string AddressNumber { get; set; }
    public string AddressComplement { get; set; }
    public string AddressNeighborhood { get; set; }
    public Guid CityId { get; set; }
    public City City { get; set; }
    public string ContactName { get; set; }
    public string ContactFone { get; set; }
    public decimal ServicePrice { get; set; }
    public decimal DisplacementPrice { get; set; }
}
