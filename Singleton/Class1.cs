using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Singleton
{
    public class SingletonExample
    {
        private static SingletonExample singletonExample;

        private SingletonExample()
        {
        }

        public static SingletonExample GetInstance()
        {
            // для исключения возможности создания двух объектов 
            if (singletonExample == null)
            {
                lock (typeof(ConfigurationManager))
                {
                    if (singletonExample == null)
                        singletonExample = new SingletonExample();
                }
            }

            return singletonExample;
        }
    }
}
