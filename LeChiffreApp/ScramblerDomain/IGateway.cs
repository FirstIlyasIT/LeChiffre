using System;
using LeChiffreApp.Models;

namespace LeChiffreApp.ScramblerDomain;

public interface IGateway
{
    public void Record(BaseModel baseModel);
    public void Delete(BaseModel baseModel);
    public BaseModel Create(Type type, string value);
}