using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2Magnus
{
    public class Customer
    {
        #region Instance fields
        private string _name;
        private string _tlf;
        private string _email;
        private bool _customerClub;
        #endregion

        #region Constructor
        Customer(string name, string tlf, string email, bool customerClub)
        {
            _name = name;
            _tlf = tlf;
            _email = email;
            _customerClub = customerClub;
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
        }
        public string Tlf
        {
            get { return _tlf; }
        }
        public string Email
        {
            get { return _email; }
        }
        public bool CustomerClub
        {
            get { return _customerClub; }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return _name.ToString() + _tlf.ToString() + _email.ToString() + _customerClub.ToString();
        }
        #endregion
    }
}
