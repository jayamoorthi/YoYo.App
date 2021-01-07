using System;
using System.Collections.Generic;
using System.Text;

namespace YoYo.Application.Features.Person.Queries.GetAll
{
    public class GetAllPersonResponse
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime CreatedBy { get; set; }    

    }
}
