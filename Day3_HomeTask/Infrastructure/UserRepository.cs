using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Day3_HomeTask.Models;

namespace Day3_HomeTask.Infrastructure
{
    public static class UserRepository
    {
        static List<Person> users = new List<Person>();

        static UserRepository()
        {
            var a = new Person();
            a.Login = "Max0__o";
            users.Add(a);
        }

        public static Person GetPerson(int id = 1)
        {
            if (users.Count <= id)
            {
                return users[id-1];
            }
            return null;
        }
    }
}