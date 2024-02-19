namespace ODataAPI.Data.Entities
{
    public record Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public decimal? Salary { get; set; }
        public string? JobRole { get; set; }
        public List<EmployeeAddresses> EmployeeAddresses { get; set; }
    }
    public record EmployeeAddresses
    {
        public int Id { get; set; }
        public string? HouseNumber { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
