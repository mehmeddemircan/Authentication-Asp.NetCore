using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Abstract
{
    public interface ICreatedEntity
    {
        public int CreatedUserId { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
