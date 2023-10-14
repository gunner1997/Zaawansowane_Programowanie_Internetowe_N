using WebStore.DAL.EF;
namespace WebStore.Tests.UnitTests {
    public abstract class BaseUnitTests {
        protected readonly ApplicationDbContext DbContext;
         BaseUnitTests (ApplicationDbContext dbContext) {
            DbContext = dbContext;;
        }
    }
}