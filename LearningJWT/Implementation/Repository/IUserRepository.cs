using LearningJWT.Models;

namespace LearningJWT.Implementation.Repository
{
    public interface IUserRepository
    {
        List<UserModel> GetAllStudents();
        UserModel GetById(Guid id);
        Task<List<UserModelDto>> GetAllStudentDto();
        UserModel AddUser(UserModel student);
    }
}
