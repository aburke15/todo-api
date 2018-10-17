using System;
using TodoData.Infrastructure;

namespace TodoData.Models
{
    public class Entity
    {
        public Entity()
        {
            Id = GuidComb.GenerateComb();
            CreatedOn = DateTime.Now;
        }

        public Guid Id { get; private set; }

        public DateTime CreatedOn { get; private set; }

        public DateTime? LastUpdatedOn { get; set; }

        public DateTime? DeprecatedOn { get; set; }
    }
}