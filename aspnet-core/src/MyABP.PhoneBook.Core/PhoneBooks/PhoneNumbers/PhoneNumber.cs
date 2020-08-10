using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyABP.PhoneBook.PhoneBooks.PhoneNumbers
{
    public class PhoneNumber : IHasCreationTime
    {
        public string Number { get; set; }

        public PhoneNumberType Type { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
