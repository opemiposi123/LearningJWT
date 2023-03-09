using LearningJWT.Implementation.Response;
using LearningJWT.Models;

namespace LearningJWT.Implementation.Service
{
    public interface IUserService
    {
        Task<CreateEditResponse> Create(UserModelDto request);
        Task<List<UserModelDto>> LoadAllUser();
    }
}
