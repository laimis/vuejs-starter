using System.Collections.Generic;
using System.Threading.Tasks;
using vuetest.Models;

namespace vuetest.Services
{
    public interface ITodoItemService
    {
        Task<IEnumerable<TodoItemModel>> GetItems(string userId);

        Task AddItem(string userId, string text);

        Task UpdateItem(string userId, string id, TodoItemModel updatedData);

        Task DeleteItem(string userId, string id);
    }
}