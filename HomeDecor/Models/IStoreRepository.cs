using System.Linq;
namespace HomeDecor.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}