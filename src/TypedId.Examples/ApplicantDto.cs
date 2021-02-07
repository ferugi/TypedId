using System;

namespace TypedId.Examples
{
    public class ApplicantDto : IIdentifiable<ApplicantId, ApplicantDto>
    {
        public ApplicantId Id { get; }

        public string FirstName { get; set; }
        public static ApplicantDto NewMessage(string content) => new ApplicantDto(Guid.NewGuid(), content);

        private ApplicantDto(Guid id, string firstName)
        {
            //this.Id = IdFor<ApplicantDto>.Wrap(id);
            this.FirstName = firstName;
        }
    }
}
