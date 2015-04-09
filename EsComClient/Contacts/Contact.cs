using EsComClient.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsComClient.Contacts
{
    public class Contact 
    {
        public int Id { get; set; }
        public string Realname { get; set; }
        public string Nickname { get; set; }
        public ContactStatus Status { get; set; }

    }
}
