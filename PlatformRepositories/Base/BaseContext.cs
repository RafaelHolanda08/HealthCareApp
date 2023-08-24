using Microsoft.EntityFrameworkCore;


namespace Platform.Repositories.Base{
    public class BaseContext : DbContext {

        public BaseContext() {

        }

        public BaseContext(DbContextOptions<BaseContext> options) : base(options){

        }
        
    }
}
