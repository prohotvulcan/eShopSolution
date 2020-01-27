namespace eShopSolution.Data.EntityModels
{
    public class CategoryTranslation
    {
        public int Id { get; set; }
        public int CaterogyId { get; set; }
        public string Name { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }
        public string LanguageId { get; set; }
        public string SeoAlias { get; set; }

        public Category Category { get; set; }
        public Language Language { get; set; }
    }
}
