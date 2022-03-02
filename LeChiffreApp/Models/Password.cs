using LeChiffreApp.ScramblerDomain;

namespace LeChiffreApp.Models;
public class Password: BaseModel, IPassword
{
    public Password(IGateway gateway) : base(gateway)
    {
    }
}