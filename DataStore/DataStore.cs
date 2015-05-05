using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStore
{
    public class DataStore
    {
        private DataStore() { }

        private static DataStore _instance;
        public static DataStore Instance
        {
            get
            {
                if (_instance == null) {
                    _instance = new DataStore();
                    return _instance;
                }

                return _instance;
            }
        }

    }
}
