namespace eShopSolution.Data.EntityModels
{
    public class ProductInCategory
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CaterogyId { get; set; }
        public Category Category { get; set; }
    }
}
