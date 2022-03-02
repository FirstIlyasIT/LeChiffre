using LeChiffreApp.ScramblerDomain;

namespace LeChiffreApp.Models;
public class Category: BaseModel, ICategory
{
    public Category(IGateway gateway) : base(gateway)
    {
    }
}