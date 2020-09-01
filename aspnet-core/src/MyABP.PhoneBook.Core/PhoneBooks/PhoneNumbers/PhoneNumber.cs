using Abp.Domain.Entities.Auditing;
using MyABP.PhoneBook.PhoneBooks.Persons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyABP.PhoneBook.PhoneBooks.PhoneNumbers
{
    public class PhoneNumber : IHasCreationTime
    {
        [Required]
        [Phone]
        [MaxLength(11)]
        public string Number { get; set; }

        public PhoneNumberType Type { get; set; }

        public int PersonId { get; set; }

        public Person Person { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
