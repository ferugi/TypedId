namespace TypedId.Examples
{
    public struct ApplicantId : ISharedId<Applicant>, ISharedId<ApplicantDto>
    {
        public object Unwrap()
        {
            throw new System.NotImplementedException();
        }
    }
}
