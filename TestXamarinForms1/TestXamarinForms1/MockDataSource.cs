using System;
using System.Collections.Generic;
using System.Text;
using TestXamarinForms1.Model;

namespace TestXamarinForms1
{
    public class MockDataSource
    {
        public User FakeUser = new User();

        public MockDataSource()
        {
            FakeUser.ID = 1234;
            FakeUser.Name = "Mike Hunt";
            FakeUser.Address = "555 Fake Street";
        }
    }
}


