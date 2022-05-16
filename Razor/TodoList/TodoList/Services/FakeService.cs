namespace TodoList.Services
{
    public class FakeService
    {
        private readonly Fake2Service _service;

        public FakeService(Fake2Service service)
        {
            _service = service;
        }
    }
}
