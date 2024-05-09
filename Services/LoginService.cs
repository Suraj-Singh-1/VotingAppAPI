using VotingAppAPI.Repository;
using VotingAppAPI.Services.IServices;
using VotingAppAPI.Repository.IRepository;

namespace VotingAppAPI.Services
{
    public class LoginService :ILoginService
    {
        IAccountRepository accountRepository;
        public LoginService(IAccountRepository _accountRepository) { 
            accountRepository = _accountRepository;
        }
        public async Task<bool> isUserValid(string username, string password)
        {
            if (string.IsNullOrEmpty(username)|| string.IsNullOrEmpty(password))
            {
                return false;
            }
            else
            {
                var isUser = await accountRepository.login(username, password);
                if (isUser)
                {
                    return true;
                }
                else { return false; }
            }
            
        }
    }
}
