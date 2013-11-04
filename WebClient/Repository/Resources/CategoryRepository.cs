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

        public Category GetCategoryByTitle(string value)
        {
            return db.Categories.FirstOrDefault(x => x.Title == value);
        }

        public void InsertCategory(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public void DisableCategory(Category category)
        {
            db.Categories.Add(category).Active = false;
            db.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            db.Categories.Remove(category);
            db.SaveChanges();
        }
    }
}