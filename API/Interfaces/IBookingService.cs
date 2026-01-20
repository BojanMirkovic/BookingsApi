using BookingsApi.Models;

namespace BookingsApi.Interfaces
{
    public interface IBookingService
    {
        bool Cancel(int id);
        Booking Create(Booking booking);
        IEnumerable<Booking> GetAll();
        Booking? GetById(int id);
    }
}
