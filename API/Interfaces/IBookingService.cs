using BookingsApi.Models;

namespace BookingsApi.Interfaces
{
    public interface IBookingService
    {
        void Cancel(int id);
        Booking Create(Booking booking);
        IEnumerable<Booking> GetAll();
        Booking? GetById(int id);
    }
}
