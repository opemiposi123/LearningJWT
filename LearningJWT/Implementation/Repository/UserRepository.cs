using Azure.Core;
using LearningJWT.Models;
using Microsoft.EntityFrameworkCore;
using Persistence.DataContext;

namespace LearningJWT.Implementation.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public UserRepository(ApplicationDbContext dbContex)
        {
            _dbContext = dbContex;
        }

        public List<UserModel> GetAllStudents()
        {
            return _dbContext.User.ToList();
        }
        public UserModel GetById(Guid id)
        {
            return _dbContext.User.Where(s => s.Id == id).FirstOrDefault();
        }

        public UserModel AddUser(UserModel student)
        {
            _dbContext.Add(student);
            _dbContext.SaveChanges();
            return student;
        }

        public async Task<List<UserModelDto>> GetAllStudentDto()
        {
            return await _dbContext.User.Select(x => new UserModelDto
            {
                Username = x.Username,
                EmailAddress = x.EmailAddress,
                GivenName = x.GivenName,
                Password = x.Password,
                Role = x.Role,
                Surname = x.Surname
            }).ToListAsync();
        }

    }
}
