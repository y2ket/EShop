using System;
using Volo.Abp.ObjectExtending;

namespace EasyAbp.EShop.Products.ProductInventories.Dtos
{
    [Serializable]
    public class UpdateProductInventoryDto : ExtensibleObject
    {
        public Guid ProductId { get; set; }
        
        public Guid ProductSkuId { get; set; }
        
        public Guid? StoreId { get; set; }
        
        /// <summary>
        /// Reduce inventory if the value is less than 0
        /// </summary>
        public int ChangedInventory { get; set; }
    }
}