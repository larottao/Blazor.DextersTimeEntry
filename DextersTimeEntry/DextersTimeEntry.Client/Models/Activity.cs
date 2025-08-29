namespace DextersTimeEntry.Client.Models
{
    public class Activity
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string ProjectCode { get; set; } = "";
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";

        public string AAType { get; set; } = "";
        public List<DateTime> TimeSlots { get; set; } = new();
    }

}
