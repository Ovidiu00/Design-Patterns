using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
 
    /// <summary>
    /// Double check locking
    /// </summary>
    public sealed class ThreadSafeSingletonLazyInit
    {

        private ThreadSafeSingletonLazyInit() { }
        
        private static readonly object padlock = new object();
        private static ThreadSafeSingletonLazyInit instance = null;
        public static ThreadSafeSingletonLazyInit Instance
        {
            get
            {
                if (instance == null)

                 //se folsoeste double cheking deoarece exista cazul inc are threadul este in asteparea threadului.
                {
                    lock (padlock) //va bloca thread-ul current intre parantezele de la lock ,il va elibera la sfarsind permtiand urmatorului thread sa intre.
                    {
                        if (instance == null)
                        {
                            instance = new ThreadSafeSingletonLazyInit();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
