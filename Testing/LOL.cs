using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    internal class LOL
    {
        private static LOL? singleton = null;

        public static LOL GetSingleton()
        {
            if (singleton == null) singleton = new LOL();
            return singleton;
        }

        public static LOL Singleton
        {
            get
            {
                if (singleton == null) singleton = new LOL();
                return singleton;
            }
        }

        private LOL()
        {

        }
    }
}
