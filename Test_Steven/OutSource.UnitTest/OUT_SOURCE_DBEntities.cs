using System;

namespace OutSource.UnitTest
{
    internal class OUT_SOURCE_DBEntities : IDisposable
    {
        public object Users { get; internal set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}