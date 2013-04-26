using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVoid.Mockable
{
    public class DateTimeProvider : IProvideDateTime
    {
        public DateTime Now
        {
            get { return DateTime.Now; }
        }

        public DateTime Today
        {
            get { return DateTime.Today; }
        }
    }

    public class MockDateTimeProvider : IProvideDateTime
    {
        private readonly DateTime _now;
        public MockDateTimeProvider(DateTime now)
        {
            _now = now;
        }

        public DateTime Now
        {
            get { return _now; }
        }

        public DateTime Today
        {
            get { return _now.Date; }
        }
    }
}
