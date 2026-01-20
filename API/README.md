# Bookings API – DI & DRY

- Introduced IBookingService and IBookingRepository for proper Dependency Injection.
- Controllers depend only on IBookingService, services depend on IBookingRepository (no direct instantiation).
- All business logic, including overlap checks, is centralized in BookingService (single source of truth, DRY).
- Controllers are thin and only map HTTP requests to service calls.
- Repository handles only data storage (CRUD), no business rules.
- Hard delete is implemented; exceptions and async are avoided for simplicity.
- Overall, the API is cleaner, maintainable, and can be easily adapted to a database or async service.