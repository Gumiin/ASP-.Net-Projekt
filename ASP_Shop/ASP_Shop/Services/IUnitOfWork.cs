namespace ASP_Shop.Services
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category{ get; }
        IProductRepository Product { get; }
        IProducentRepository Producent { get; }
        void Save();
    }
}
