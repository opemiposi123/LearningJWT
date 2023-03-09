using LearningJWT.Implementation.Repository;
using LearningJWT.Implementation.Response;
using LearningJWT.Models;

namespace LearningJWT.Implementation.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _studentRepository;

        public UserService(IUserRepository studentRepository)
        {

            _studentRepository = studentRepository;
        }
        public async Task<CreateEditResponse> Create(UserModelDto request)
        {
            try
            {
                var student = new UserModel()

                {
                    Id = new Guid(),
                    Username = request.Username,
                    EmailAddress = request.EmailAddress,
                    GivenName = request.GivenName,
                    Password = request.Password,
                    Role = "Administrator",
                    Surname = request.Surname
                };

                var findUser = _studentRepository.GetById(student.Id);

                if (findUser == null)
                {
                    _studentRepository.AddUser(student);
                }
                else
                {
                    return new CreateEditResponse(false,
                                              "",
                                              "No such User exist..");
                }

            }
            catch (Exception)
            {
                return new CreateEditResponse(false,
                                             "",
                                             "Something Went wrong..");
            }

            return new CreateEditResponse(true,
                                              "",
                                              "User Record successfully created..");

        }

        public async Task<List<UserModelDto>> LoadAllUser()
        {
            return await  _studentRepository.GetAllStudentDto();

        }
    }
}
