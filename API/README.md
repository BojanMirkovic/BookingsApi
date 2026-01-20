# Bookings API – DI & DRY

- I introduced interfaces IBookingService and IBookingRepository for proper Dependency Injection.
- Controllers depend only on IBookingService, services depend on IBookingRepository.
- This removes direct instantiation of concrete classes and improves testability.
- All business logic, including overlap checks, is centralized in BookingService (single source of truth).
- Controllers are thin and only map HTTP requests to service calls.
- Repository handles only data storage (CRUD), no business rules.
- This ensures the DRY principle: no duplicate overlap logic anywhere.
- Hard delete is implemented via repository; exceptions and async are avoided for simplicity.
- The design can easily scale to a real database with minimal changes.
