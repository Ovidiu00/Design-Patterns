using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    /// <summary>
    /// Se va ocupa automat de thread safety.
    /// </summary>
    public sealed class  SingletonLazyKeyword
    {
        private SingletonLazyKeyword()
        {
        }

        private static readonly Lazy<SingletonLazyKeyword> lazy = new Lazy<SingletonLazyKeyword>(() => new SingletonLazyKeyword());
        public static SingletonLazyKeyword Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
