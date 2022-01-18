using HomeWork_9_Delegat;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Homework_9_Delegats
{
    public class Tests
    {
        public List<User> user = new List<User>()
        {
            new User
            {
                Name = "Tamara",
                Gender = "female",
                Age = 33

            },
        new User
            {
                Name = "Oleg",
                Gender = "male",
                Age = 45

            },
        new User
            {
                Name = "Alice",
                Gender = "female",
                Age = 20

            },
        new User
            {
                Name = "Kostya",
                Gender = "male",
                Age = 19

            },
        new User
            {
                Name = "Galya",
                Gender = "female",
                Age = 89

            }
        };
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Helper helper = new Helper();
            var x = helper.SortByDescByAge(user);
            var y = x == user;
            Assert.IsFalse(y);
        }

        [Test]
        public void Test2()
        {
            var user1 = new User()
            {
                Name = "Tamara",
                Gender = "female",
                Age = 33

            };
            Helper helper = new Helper();
            string name = "Tamara";
            var result = helper.SingleName(user, name);
            Assert.AreEqual(user1.Name, result.Name);  // почему не проходит не могу понять, если не указывать поля, из-за ссылок?
        }

        [Test]
        [TestCase(5)]
        public void Test3(int expectedresult)
        {
            Helper helper = new Helper();
            var result = helper.Count_Users(user);
            Assert.AreEqual(expectedresult, result);
        }
    }
}