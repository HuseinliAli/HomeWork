namespace Core.Entities.Concrete
{
    class UserOperationClaim : IEntity
    {
        public int Id { get; set; }

        public int UserID { get; set; }

        public int OperationClaimID { get; set; }
    }
}
