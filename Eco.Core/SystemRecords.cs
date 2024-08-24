using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eco.Core
{
     public class SystemRecords
    {
        
        
            public int Id { get; set; }
            public string? UserFullName { get; set; }
            public string? DevicName { get; set; }
            public string? MachinId { get; set; }
            public string? Title { get; set; }
            public string? Description { get; set; }
            public DateTime CreatedDate { get; set; }
            //navigation
            public int UsersId { get; set; }
            public Users? Users { get; set; }
        
    }
}
