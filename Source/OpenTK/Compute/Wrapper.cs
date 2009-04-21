using System;

namespace OpenTK.Compute
{
    public abstract class Wrapper<T> : IDisposable, IEquatable<Wrapper<T>>
        where T : struct, IEquatable<T>
    {
        #region Fields
        
        protected readonly T Id;

        protected bool disposed;

        #endregion
        
        #region IDisposable Members
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool manual)
        {
        }

        #endregion

        #region IEquatable<T> Members

        public bool Equals(Wrapper<T> instance)
        {
            return Id.Equals(instance.Id);
        }
        
        #endregion
    }
}
