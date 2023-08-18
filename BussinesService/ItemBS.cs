using AutoMapper;
using SProject.BussinessService.Interfaces;
using SProject.DataService.Interfaces;
using SProject.Models;
using SProject.Models.ViewModels;

namespace SProject.BussinessService{
    public class ItemBS:IItemBS{
        private IItemDS _itemDS;
        private IMapper _mapper;
        public ItemBS(IItemDS itemDS, IMapper mapper)
        {
            _itemDS = itemDS;
            _mapper = mapper;
        }
        public List<VMItem> GetItems()
        {
            return _mapper.Map<List<VMItem>>(_itemDS.GetItems());
        }
        public VMItem GetItemById(int id)
        {
            return _mapper.Map<VMItem>(_itemDS.GetItemById(id));
        }
        public VMItem PostItem(VMItem item)
        {
            var itemAux = _mapper.Map<Item>(item);
            return _mapper.Map<VMItem>(_itemDS.PostItem(itemAux));
        }
        public VMItem PutItem(int id, VMItem item)
        {
            var itemAux = _mapper.Map<Item>(item);
            return _mapper.Map<VMItem>(_itemDS.PutItem(id, itemAux));
        }
        public int DeleteItem(int id)
        {
            return _itemDS.DeleteItem(id);
        }
    }
}