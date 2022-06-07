// <auto-generated>

#nullable enable

using System;

namespace ShopwareSharp.Client
{
    /// <summary>
    /// The base for all tokens.
    /// </summary>
    public abstract class TokenBase
    {
        private DateTime _nextAvailable = DateTime.UtcNow;
        private object _nextAvailableLock = new object();
        private readonly System.Timers.Timer _timer = new System.Timers.Timer();


        internal TimeSpan? Timeout { get; set; }
        internal delegate void TokenBecameAvailableEventHandler(object sender);
        internal event TokenBecameAvailableEventHandler? TokenBecameAvailable;


        /// <summary>
        /// Initialize a TokenBase object.
        /// </summary>
        /// <param name="timeout"></param>
        internal TokenBase(TimeSpan? timeout = null)
        {
            Timeout = timeout;
            
            if (Timeout != null)
                StartTimer(Timeout.Value);
        }


        /// <summary>
        /// Starts the token's timer
        /// </summary>
        /// <param name="timeout"></param>
        internal void StartTimer(TimeSpan timeout)
        {
            Timeout = timeout;
            _timer.Interval = Timeout.Value.TotalMilliseconds;
            _timer.Elapsed += OnTimer;
            _timer.AutoReset = true;
            _timer.Start();
        }

        /// <summary>
        /// Returns true while the token is rate limited.
        /// </summary>
        public bool IsRateLimited => _nextAvailable > DateTime.UtcNow;

        /// <summary>
        /// Triggered when the server returns status code TooManyRequests
        /// Once triggered the local timeout will be extended an arbitrary length of time.
        /// </summary>
        public void BeginRateLimit()
        {
            lock(_nextAvailableLock)
                _nextAvailable = DateTime.UtcNow.AddSeconds(5);
        }

        private void OnTimer(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (TokenBecameAvailable != null && !IsRateLimited)
                TokenBecameAvailable.Invoke(this);
        }
    }
}