
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2
{
    public class SeatRepo : ISeatRepo
    {
        readonly DBSeat _dBSeat;

        public SeatRepo(DBSeat dBSeat)
        {
            _dBSeat = dBSeat;
        }

        public async Task<List<Seat>> GetAllAsync()
        {
            return await _dBSeat.Seats.ToListAsync();
        }
    }
}
