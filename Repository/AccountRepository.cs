using Microsoft.EntityFrameworkCore;
using VotingAppAPI.Models;
using VotingAppAPI.Repository.IRepository;

namespace VotingAppAPI.Repository
{
    public class AccountRepository:IAccountRepository
    {
        VotingAppDBContext _dbContext;
        public AccountRepository(VotingAppDBContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public async Task<bool> login(string usn, string pwd)
        {
            VotingAppDBContext auth = new VotingAppDBContext();
            var message =  from p in auth.Users
                                 where p.Name == usn && p.Password == pwd
                                 select p;
            if (message.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
