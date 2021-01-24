using System;
using System.Collections.Generic;
using System.Text;

namespace OOPReCap1
{
    class Customer
    {
        public int Id { get; set; }

        //encapsulation- get ve set bloklarını kullanmak demek. set demek o propertye değer atandığında o değer ile ilgili yapmamız gereken işlemlerdir. get ise o propertyi getirme işlemi yapar.

        private string _firstName; //field tanımlanır. set ve get edilecek değer.
        public string FirstName {
            get
            {
                return "Sevgili " + _firstName;
            }
            set
            {
                _firstName = value; //value set etmeye çalıştığımız değere karşılık gelir.
            }
        }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
