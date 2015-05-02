using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Interfaces;

namespace WebApi.Business
{
    public class Store
    {
        private Store() { }

        private static DataStoreBase _instance;
        public static DataStoreBase Instance {
            get
            {
                if(_instance == null)
                {
                    _instance = new DummyStore();
                }

                return _instance;
            }
        }
    }
}