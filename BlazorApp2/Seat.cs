namespace BlazorApp2
{
    public class Seat
    {
        public Guid Id { get; set; }
        //public string UserName { get; set; }
        public string Code { get; set; }
        public string Row { get; set; }
        public int SeatColumn { get; set; }
        public double Price { get; set; }
        public EntityStatus Status { get; set; } = EntityStatus.Active;
    }
}
