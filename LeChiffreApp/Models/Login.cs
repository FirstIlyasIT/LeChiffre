using LeChiffreApp.ScramblerDomain;

namespace LeChiffreApp.Models;
public class Login: BaseModel, ILogin
{
    public Login(IGateway gateway) : base(gateway)
    {
    }
}