using System;

namespace SerilogMetrics
{
    /// <summary>
    /// Measures a timing operation
    /// </summary>
    public interface ITimedOperation : IDisposable
    {
        /// <summary>
        /// Adds properties after the timed operation has started
        /// </summary>
        /// <param name="values"></param>
        void AddProperties(params object[] values);
    }
}