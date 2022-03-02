using System;
using LeChiffreApp.Models;

namespace LeChiffreApp.ScramblerDomain;
public class Gateway : IGateway
{
    private IScrambler _scrambler;
    public Gateway(IScrambler scrambler) => _scrambler = scrambler ?? throw new NullReferenceException(
        $"{nameof(Gateway)}:an null-link was passed to the constructor");
    public void Record(BaseModel baseModel)
    {
    }
    public void Delete(BaseModel baseModel)
    {
    }
    public BaseModel Create(Type type, string value)
    {
        throw new NotImplementedException();
    }
}