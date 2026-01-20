using BookingsApi.Models;

namespace BookingsApi.Interfaces
{
    public interface IBookingRepository
    {
        Booking Add(Booking booking);
        void Delete(int id);
        IEnumerable<Booking> GetAll();
        Booking? GetById(int id);
    }
}
