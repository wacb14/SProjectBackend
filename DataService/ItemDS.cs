using SProject.DataService.Interfaces;
using SProject.Models;

namespace SProject.DataService
{
    public class ItemDS : IItemDS
    {
        private GeneralContext _generalContext;
        public ItemDS(GeneralContext generalContext)
        {
            _generalContext = generalContext;
        }
        public List<Item> GetItems()
        {
            return _generalContext.Item.ToList();
        }
        public Item GetItemById(int id)
        {
            return _generalContext.Item.Find(id);
        }
        public Item PostItem(Item item)
        {

            _generalContext.Item.Add(item);
            _generalContext.SaveChanges();
            return _generalContext.Item.FirstOrDefault(i => i.id == item.id);
        }
        public Item PutItem(int id, Item item)
        {
            if (item != null)
            {
                _generalContext.Item.Update(item);
                _generalContext.SaveChanges();
            }
            return _generalContext.Item.FirstOrDefault(i => i.id == item.id);
        }
        public int DeleteItem(int id)
        {
            Item item = _generalContext.Item.FirstOrDefault(i => i.id == id);
            if (item != null)
            {
                _generalContext.Item.Remove(item);
                _generalContext.SaveChanges();
            }
            return id;
        }
    }
}