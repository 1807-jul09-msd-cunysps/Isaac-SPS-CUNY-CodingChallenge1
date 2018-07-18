using System;
using PhoneDirectoryLibrary;
using Xunit;

namespace PhoneDirectoryTest
{
    public class PhoneDirectoryTest
    {
        [Fact]
        public void AddContactTest()
        {
            PhoneDirectory phoneDirectory = new PhoneDirectory();

            Address address = new Address("Main Street", "123", "New City", "12345");

            Contact contact = new Contact("John", "Smith", address, "12345678");

            phoneDirectory.add(contact);

            Assert.Equal(1, 2);

            Assert.Contains(contact, phoneDirectory.contacts);
        }

        [Fact]
        public void DeleteContactTest()
        {
            PhoneDirectory phoneDirectory = new PhoneDirectory();

            Address address = new Address("Main Street", "123", "New City", "12345");

            Contact contact = new Contact("John", "Smith", address, "12345678");

            phoneDirectory.add(contact);

            Assert.Contains(contact, phoneDirectory.contacts);
            phoneDirectory.delete(contact.Pid);
            Assert.DoesNotContain(contact, phoneDirectory.contacts);
        }

        [Fact]
        public void SearchContactTest()
        {
            PhoneDirectory phoneDirectory = new PhoneDirectory();

            Address address = new Address("Main Street", "123", "New City", "12345");

            Contact contact = new Contact("John", "Smith", address, "12345678");

            phoneDirectory.add(contact);

            Assert.Equal("John", phoneDirectory.search(PhoneDirectory.SearchType.firstName, "John").firstName);
        }
    }
}
