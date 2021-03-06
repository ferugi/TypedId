﻿using System;

namespace TypedId.Examples
{
    public class Person : IIdentifiable<Person>
    {
        public IId<Person> Id { get; }

        public string FirstName { get; set; }
        public static Person NewMessage(string content) => new Person(Guid.NewGuid(), content);

        private Person(Guid id, string firstName)
        {
            this.Id = IdFor<Person>.Wrap(id);
            this.FirstName = firstName;
        }
    }
}
