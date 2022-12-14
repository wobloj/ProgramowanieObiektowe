using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_LAB.Context;

namespace MVC_LAB.Models.Person
{
    public class CreatePersonModelViewModel
    {
        public string Name { get; set; }
        public List<SelectListItem> Gender { get; set; }
        public string City { get; set; }

    }
}
