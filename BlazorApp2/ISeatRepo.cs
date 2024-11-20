namespace BlazorApp2
{
    public interface ISeatRepo
    {
        public Task<List<Seat>> GetAllAsync();
    }
}
