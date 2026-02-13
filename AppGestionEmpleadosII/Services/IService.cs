namespace AppGestionEmpleadosII.Services;

internal interface IService<T>
{
    public List<T> GetAll();
    public T Get(int id);
    public void Add(T item);
    public void Update(T item);
    public void Delete(T item);
}
