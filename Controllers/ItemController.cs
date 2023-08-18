using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SProject.BussinessService.Interfaces;
using SProject.Models.ViewModels;

namespace Backend.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [EnableCors("_myAllowSpecificOrigins")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private IItemBS _itemBS;

        public ItemController(IItemBS itemBS)
        {
            _itemBS = itemBS;
        }

        [AllowAnonymous]
        [HttpGet("[action]")]
        public List<VMItem> GetItems()
        {
            return _itemBS.GetItems();
        }
        [AllowAnonymous]
        [HttpGet("[action]")]
        public VMItem GetItemById(int id)
        {
            return _itemBS.GetItemById(id);
        }
        [AllowAnonymous]
        [HttpPost("[action]")]
        public VMItem PostItem(VMItem item)
        {
            return _itemBS.PostItem(item);
        }
        [AllowAnonymous]
        [HttpPut("[action]")]
        public VMItem PutItem(int id, VMItem item)
        {
            return _itemBS.PutItem(id, item);
        }
        [AllowAnonymous]
        [HttpDelete("[action]")]
        public int DeleteItem(int id)
        {
            return _itemBS.DeleteItem(id);
        }
    }
}