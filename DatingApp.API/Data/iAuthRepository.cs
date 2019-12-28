using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface iAuthRepository
    {
        /*Task of type User Task<User> - What we will be returning, returning a task
        of user. Method will be called Register, User objected will be passed and 
        string of type password
        
        Task needs System.Threading.Tasks
        User needs DatingApp.API.Models*/
         Task<User> Register(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);
    }
}