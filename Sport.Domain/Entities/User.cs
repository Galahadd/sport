using Sport.Domain.Entities.MMRelation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static Sport.Domain.Enums.AllEnums;

namespace Sport.Domain.Entities
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Password2 { get; set; }

        public double Size { get; set; }

        public double Weight { get; set; }

        public EnumGenderType EnumGenderType { get; set; }

        public virtual ICollection<UserNutritionLists> NutritionLists { get; set; }
        public virtual ICollection<UserSportLists> UserSportLists { get; set; }
    }
}
