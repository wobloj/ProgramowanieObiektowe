using MVC_LAB.Models.Person;

namespace MVC_LAB.Services
{
    public interface IPersonService
    {
        public List<PersonModel> GetPersons();
        public PersonModel GetPerson(int id);
        public void CreatePerson(string name, string city, GenderEnum gender);
        public void EditPerson(long id,string name,string city, GenderEnum gender);
    }
}
