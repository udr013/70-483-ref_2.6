using System;

namespace DisposePattern
{
    class ResourceHolder : IDisposable 
        // Also see 2.4 DisposableConnection "using"which ensures 
        // the disposable method is called on the object.
    {
        // #region lets you specify a block of code that you can expand or collapse when 
        // using the outlining feature of the Visual Studio Code Editor.
        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
         ~ResourceHolder()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(false);
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }
        #endregion

    }

    class Program
    {
        static void Main(string[] args)
        {
            ResourceHolder resourceHolder = new ResourceHolder();
            resourceHolder.Dispose();
            // To re-enable the finalization again (as it is disabeld in the DisposablePattern above
            GC.ReRegisterForFinalize(resourceHolder);
        }
    }
}
