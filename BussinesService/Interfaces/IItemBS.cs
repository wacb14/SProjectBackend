using SProject.Models.ViewModels;

namespace SProject.BussinessService.Interfaces{
    public interface IItemBS{
        public List<VMItem> GetItems();
        public VMItem GetItemById(int id);
        public VMItem PostItem(VMItem item);
        public VMItem PutItem(int id, VMItem item);
        public int DeleteItem(int id);
    }
}