namespace FT.Objects
{
    public class Team
    {
        public Team() 
        {

        }
        public Guid Id { get; set; }
        public int ValidFrom { get; set; }
        public int ValidTo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid EngineManufacturerId { get; set; }
        public Guid TeamPrincipalId { get; set; }
        public Guid ChiefEngineerId { get; set; }
        public Guid ChiefStrategistId { get; set; }
        public Guid Car1Id { get; set; }
        public Guid Car2Id { get; set; }
        public Guid Driver1Id { get; set; }
        public Guid Driver2Id { get; set;}
    }
}
