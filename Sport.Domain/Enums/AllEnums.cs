using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sport.Domain.Enums
{
    public class AllEnums
    {
        public enum EnumSportType
        {
            [Display(Name = "Weakening")]
            Weakening = 0,
            [Display(Name = "Protection")]
            Protection = 1,
            [Display(Name = "Development")]
            Development = 2
        }
        public enum EnumFoodType
        {
            [Display(Name = "Red Meat")]
            RedMeat = 0,
            [Display(Name = "White Meat")]
            WhiteMeat = 1,
            [Display(Name = "Fruit")]
            Fruit = 2,
            [Display(Name = "Vegetables")]
            Vegetables = 3,
            [Display(Name = "Legumes")]
            Legumes = 4,
            [Display(Name = "Nuts")]
            Nuts = 5,
            [Display(Name = "Liquid")]
            Liquid = 6
        }
        public enum EnumNutritionType
        {
            [Display(Name = "White Meat")]
            WhiteMeat = 0,
            [Display(Name = "Red Meat")]
            RedMeat = 1,
            [Display(Name = "Vegetarian")]
            Vegetarian = 2
        }
        public enum EnumNutritionKind
        {
            [Display(Name = "Diet")]
            Diet = 0,
            [Display(Name = "Protection")]
            Protection = 1,
            [Display(Name = "Development")]
            Development = 2
        }
        public enum EnumGenderType
        {
            [Display(Name = "Male")]
            Male = 0,
            [Display(Name = "Female")]
            Female = 1
        }
        public enum EnumActivityType
        {
            [Display(Name = "Office Worker")]
            OfficeWorker = 0,
            [Display(Name = "Light Exercise")]
            LightExercise = 1,
            [Display(Name = "Medium Exercise")]
            MediumExercise = 2,
            [Display(Name = "Heavy Exercise")]
            HeavyExercise = 3,
            [Display(Name = "Athlete")]
            Athlete = 4
        }
        public enum EnumMealType
        {
            [Display(Name = "Morning")]
            Morning = 0,
            [Display(Name = "Snacks1")]
            Snacks1 = 1,
            [Display(Name = "Noon")]
            Noon = 2,
            [Display(Name = "Snacks2")]
            Snacks2 = 3,
            [Display(Name = "Evening")]
            Evening = 4
        }
    }
}
