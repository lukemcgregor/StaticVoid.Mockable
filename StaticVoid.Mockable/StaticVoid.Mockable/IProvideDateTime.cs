using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVoid.Mockable
{
    /// <summary>
    /// DateTime is important part of applications and its not too easy to unit test
    /// that things are happening as expected (you need deltas and such gumph) so this
    /// interface lets you abstract out a few common DateTime bits so that you can 
    /// replace them with a mock for unit testing 
    /// </summary>
    public interface IProvideDateTime
    {
        /// <summary>
        /// Corresponds to DateTime.Now
        /// </summary>
        DateTime Now { get; }
        /// <summary>
        /// Corresponds to DateTime.Today
        /// </summary>
        DateTime Today { get; }
    }
}
