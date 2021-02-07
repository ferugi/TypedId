using System;

namespace TypedId.Examples
{
    public class Applicant : IIdentifiable<ApplicantId, Applicant>
    {
        public ApplicantId Id { get; }

        public string FirstName { get; set; }

        public static Applicant NewMessage(string content) => new Applicant(Guid.NewGuid(), content);

        private Applicant(Guid id, string firstName)
        {
            //this.Id = IdFor<Person>.Wrap(id);
            this.FirstName = firstName;
        }
    }
}
