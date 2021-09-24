using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
 
    /// <summary>
    /// Double check locking, necesar pentru variantele mai vechi a .net , acum initalizarea eager statica este folosita pentru thread safety
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
             //Conditie pentru a nu creea un lock la fiecare apelare a get-ului, ci doar atunci cand nu exista deja o instanta
                if (instance == null)

                 //se folsoeste double cheking deoarece exista cazul inc are threadul este in asteparea lock-ului.
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
