using week_3_assignment.Data.Models;


namespace week_3_assignment.Data.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {

      /*  IEnumerable<Person> IPersonRepository.GetAdultPersons()
        {
            return context.Person.Where(pers => pers.Age >= 18).ToList();
        }*/

    }
}
