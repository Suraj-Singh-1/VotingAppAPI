namespace VotingAppAPI.Services.IServices
{
    public interface ILoginService
    {
        public Task<bool> isUserValid(string username, string password);
    }
}
