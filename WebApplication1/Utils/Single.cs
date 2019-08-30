using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Utils
{
    public class Single<T> : IDisposable
    {
        private bool disposedValue = false;
        private static object _instance = null;

        protected virtual void Dispose(bool disposing)
        {
            if(!disposedValue)
            {
                if(disposing)
                {

                }

            }
            disposedValue = true;
        }
        public static T GetInstance()
        {
            if (_instance == null)
            {
                _instance = Activator.CreateInstance<T>();

            }
            return (T)_instance;
        }
        void IDisposable.Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        

    }
}