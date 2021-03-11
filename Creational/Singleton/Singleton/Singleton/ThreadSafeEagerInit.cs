using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
   public sealed class ThreadSafeEagerInit
    {
        private static readonly ThreadSafeEagerInit instance = new ThreadSafeEagerInit();
        // Explicit static constructor to tell C# compiler  
        // not to mark type as beforefieldinit  
        static ThreadSafeEagerInit()
        {
        }
        private ThreadSafeEagerInit()
        {
        }
        public static ThreadSafeEagerInit Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
