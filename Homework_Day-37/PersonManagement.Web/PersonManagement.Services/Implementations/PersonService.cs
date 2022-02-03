using PersonManagement.Services.Abstractions;
using PersonManagement.Services.Exceptions;
using PersonManagement.Services.Localisations;
using PersonManagement.Services.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonManagement.Services.Implementations
{
    public class PersonService : IPersonService
    {

        #region PersonData

        private readonly List<PersonServiceModel> _people = new List<PersonServiceModel>
        {
            new PersonServiceModel
            {
                Id = 1,PersonalNumber="12341234123", FirstName="დავით", LastName="ჯიმშიაშვილი",
                Age=18,Email="DavitJ@gmail.com",PhoneNumber="593002293",BankCard="1234567887654321",PersonalWebsite="Davitjim.gmail.com"
            },
            new PersonServiceModel
            {
                Id = 2,PersonalNumber="22340797900", FirstName="გიორგი", LastName="ფერაძე",
                Age=15,Email="giorgifer@gmail.com",PhoneNumber="593003393",BankCard="2234567887654321",PersonalWebsite="giorgifer.com"
            },
            new PersonServiceModel
            {
                Id = 3,PersonalNumber="32309090756", FirstName="მარიამ", LastName="მგალობლიშვილი",
                Age=16,Email="mariammgal@yahoo.com",PhoneNumber="593007793",BankCard="1234567887654321",PersonalWebsite="mariammgal.com"
            }
        };

        #endregion

        public async Task<PersonServiceModel> GetAsync(int id)
        {
            var person= await Task.FromResult(_people.SingleOrDefault(p => p.Id == id));
            if (person==null)
            {
                throw new PersonNotFoundException(ErrorMessages.NotFound);
            }
            return person;
        }

        public async Task<List<PersonServiceModel>> GetAllAsync()
        {
            return await Task.FromResult(_people);
        }

        public async Task<int> CreateAsync(PersonServiceModel person)
        {
            var tmpPerson = _people.FirstOrDefault(p => p.PersonalNumber == person.PersonalNumber);
            if (tmpPerson!=null)
            {
                throw new PersonAlreadyExsistsException(ErrorMessages.Conflict);
            }
            person.Id = _people.Max(x => x.Id) + 1;
            _people.Add(person);
            return await Task.FromResult(person.Id);
        }
    }
}
