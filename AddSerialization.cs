using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization.Formatters.Soap;

namespace Serialization.Serialization
{
    [Serializable]
    class AddSerialization
    {
        public string Name
            {
                get;
                set;
            }

            public Int32 Age
            {
                get;
                set;
            }
        }
    }
