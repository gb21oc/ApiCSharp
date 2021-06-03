using System.Threading.Tasks;
using Api.Domain.Dtos;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.User;
using Api.Domain.Repository;

namespace Api.Service.Services
{
    public class LoginService: ILoginService
    {
        private IUserRepository _repository;

        public LoginService(IUserRepository repository)
        {
            _repository = repository;
        }
        public async Task<object> FindByLogin(LoginDto user)
        {
            var baseuser = new UserEntity();
            if(user != null && !string.IsNullOrWhiteSpace(user.Email)){
                baseuser = await _repository.FindByLogin(user.Email);
                if(baseuser == null){
                    return null;
                }else{
                    return baseuser;
                }
            }else{
                return null;
            }
            //return await _repository.FindByLogin(user.Email);
        }
    }
}