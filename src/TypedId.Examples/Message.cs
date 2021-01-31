using System;

namespace TypedId.Examples
{
    public class Message : IIdentifiable<Message>
    {
        public IId<Message> Id { get; }
        public IId<Person> SenderId { get; set; }
        public IId<Person> RecipientId { get; set; }
        public string Content { get; set; }

        public static Message NewMessage(string content) => new Message(Guid.NewGuid(), content);

        private Message(Guid id, string content)
        {
            this.Id = IdFor<Message>.Wrap(id);
            this.Content = content;
        }
    }
}
