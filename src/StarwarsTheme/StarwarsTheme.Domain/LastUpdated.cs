using System;

namespace StarwarsTheme.Domain
{
    public record LastUpdated
    {
        public static LastUpdated Never { get; } = new LastUpdated(new DateTime());
        public DateTime DateTime { get; }
        public LastUpdated(DateTime dateTime) => (DateTime) = (dateTime);
    }
}
