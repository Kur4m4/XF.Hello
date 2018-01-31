using System;
using System.Collections.Generic;
using System.Text;

namespace XF.Hello
{
    class ConfigData
    {
        private bool swtEmail;
        private string email;

        public bool SwtEmail
        {
            get
            {
                return swtEmail;
            }
            set
            {
                swtEmail = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
    }
}
