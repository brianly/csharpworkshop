﻿using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var people = new List<Person>
            {
                new Person("Alice", "Wonderland", "alice@contoso.com", new DateTime(1979, 11, 19)),
                new Person("Bob", "Mycroserft", "bob@contoso.com", new DateTime(1995, 03, 10)),
                new Person("Carol", "Reho", "carol@contoso.com", new DateTime(1986, 05, 26))
            };
            foreach(var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
