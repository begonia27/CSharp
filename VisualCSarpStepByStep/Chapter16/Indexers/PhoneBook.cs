using System;
using Windows.Web.Syndication;

namespace Indexers
{
    sealed class PhoneBook
    {
        private int used;
        private Name[] names;
        private PhoneNumber[] phoneNumbers;

        public PhoneBook()
        {
            int initialSize = 0;
            used = 0;
            names = new Name[initialSize];
            phoneNumbers = new PhoneNumber[initialSize];
        }

        public void Add(Name name, PhoneNumber number)
        {
            EnlargeIfFull();
            names[used] = name;
            phoneNumbers[used] = number;
            used++;
        }

        public Name this[PhoneNumber number]
        {
            get
            {
                int i = Array.IndexOf(phoneNumbers, number);

                if (i != -1)
                {
                    return names[i];
                }
                else
                {
                    return new Name();
                }
            }
        }

        public PhoneNumber this[Name name]
        {
            get
            {
                int i = Array.IndexOf(names, name);

                if (i != -1)
                {
                    return phoneNumbers[i];
                }
                else
                {
                    return new PhoneNumber();
                }
            }
        }

        private void EnlargeIfFull()
        {
            if (used == names.Length)
            {
                int bigger = used + 16;

                Name[] moreNames = new Name[bigger];
                names.CopyTo(moreNames, 0);

                PhoneNumber[] morePhoneNumbers = new PhoneNumber[bigger];
                phoneNumbers.CopyTo(morePhoneNumbers, 0);

                names = moreNames;
                phoneNumbers = morePhoneNumbers;
            }
        }
    }
}
