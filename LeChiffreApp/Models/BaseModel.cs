using LeChiffreApp.ScramblerDomain;

namespace LeChiffreApp.Models;
public abstract class BaseModel
{
    public int Id { get; init; }
    private readonly IGateway _gateway;
    protected BaseModel(IGateway gateway) => _gateway = gateway;
    public void Save() => _gateway.Record(this);
    public void Delete() => _gateway.Delete(this);
}