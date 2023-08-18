using SProject.Models;

namespace SProject.DataService.Interfaces
{
    public interface IItemDS{
        public List<Item> GetItems();
        public Item GetItemById(int id);
        public Item PostItem(Item item);
        public Item PutItem(int id, Item item);
        public int DeleteItem(int id);
    }
}