using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.Serialization
{
    class SoapCLass
    { 

            private int myaccountnumber = 172;

            [NonSerialized()]

            private string password = "Hello";
            public int MyAccNum
            {
                get

                {
                    return myaccountnumber;
                }

                set

                {

                myaccountnumber = value;
                }

            }

            public string Passwd

            {
                get

                {
                    return password;
                }
                set
                {
                    password = value;
                }
            }

            public SoapCLass()

            {

            }
        }
    }

