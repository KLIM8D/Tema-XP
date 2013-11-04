using System.Linq;
using Repository.Models;

namespace Repository.Resources
{
    public class CategoryRepository
    {
        private BPDbContext db;

        public CategoryRepository()
        {
            db = new BPDbContext();
        }

        public IQueryable<Category> GetAllCategories()
        {
            return db.Categories;
        }

        public Category GetCategoryById(int value)
        {
            return db.Categories.FirstOrDefault(x => x.Id == value);
        }

        public void Insert(Category category)
        {
            db.Categories.Add(category);
        }

        public void Disable(int value)
        {
            Category rCategory = GetCategoryById(value);

            if (rCategory == null)
                return;

            rCategory.Active = false;
            db.SaveChanges();
        }
    }
}