namespace BlazorSample.Data
{
    public class CounterService : ICounterService
    {
        private int _count { get; set; }

        public void Increment()
        {
            _count++;
        }

        int ICounterService.Count()
        {
            return _count;
        }
    }
}