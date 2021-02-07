using System;

namespace TypedId.Examples
{
    public class Message : IIdentifiable<Message>
    {
        public IId<Message> Id { get; private set; }
        public IId<Person> SenderId { get; private set; }
        public IId<Person> RecipientId { get; private set; }
        public string Content { get; private set; }

        public static Message NewMessage(
            IId<Person> senderId,
            IId<Person> recipientId,
            string content)
        {
            var guidId = Guid.NewGuid();

            return new Message
            {
                Id = IdFor<Message>.Wrap(guidId),
                SenderId = senderId,
                RecipientId = recipientId,
                Content = content
            };
        }
    }
}
