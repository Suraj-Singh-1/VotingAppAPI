namespace VotingAppAPI.Repository.IRepository
{
    public interface IAccountRepository
    {
        public Task<bool> login(string usn, string pwd);
    }
}
