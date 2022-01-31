using System;
namespace Generic{
    public interface IGeneric<T> where T: class{
        Task<List<T>> GetAll(string search = null);
        Task Add(T Object);
        Task Get(Guid id);
        Task Remove(Guid id);
        Task Details(Guid id);
    }
}