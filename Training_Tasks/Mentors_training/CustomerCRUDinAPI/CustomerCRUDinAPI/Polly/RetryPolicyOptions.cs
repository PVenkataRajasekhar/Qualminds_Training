namespace CustomerCRUDinAPI.Polly
{
    public class RetryPolicyOptions
    {
        public int MaxRetryAttempts { get; set; }
        public int DelayBetweenRetries { get; set; }
    }
}
