namespace Calendar.Infrastructure.Entities
{
    public class NagerModel
    {
        public string? Date { get; set; }
        public string? LocalName { get; set; }
        public string? Name { get; set; }
        public string? CountryCode { get; set; }
        public bool? Fixed { get; set; }
        public bool? Global {  get; set; }
        public string? Counties { get; set; }
        public int? LaunchYear { get; set; }
        public List<string> Types { get; set; } = new List<string>();
    }
}
