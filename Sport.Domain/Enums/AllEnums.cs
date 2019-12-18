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
            [Display(Name = "Zayıflama")]
            Weakening = 0,
            [Display(Name = "Koruma")]
            Protection = 1,
            [Display(Name = "Gelişme")]
            Development = 2
        }
        public enum EnumFoodType
        {
            [Display(Name = "Kırmızı Et")]
            RedMeat = 0,
            [Display(Name = "Beyaz Et")]
            WhiteMeat = 1,
            [Display(Name = "Meyve")]
            Fruit = 2,
            [Display(Name = "Sebze")]
            Vegetables = 3,
            [Display(Name = "Bakliyat")]
            Legumes = 4,
            [Display(Name = "Çerez")]
            Nuts = 5,
            [Display(Name = "Sıvı")]
            Liquid = 6
        }
        public enum EnumNutritionType
        {
            [Display(Name = "Kırmızı Et")]
            WhiteMeat = 0,
            [Display(Name = "Beyaz Et")]
            RedMeat = 1,
            [Display(Name = "Vejeteryan")]
            Vegetarian = 2
        }
        public enum EnumNutritionKind
        {
            [Display(Name = "Diyet")]
            Diet = 0,
            [Display(Name = "Koruma")]
            Protection = 1,
            [Display(Name = "Gelişme")]
            Development = 2
        }
        public enum EnumGenderType
        {
            [Display(Name = "Erkek")]
            Male = 0,
            [Display(Name = "Kadın")]
            Female = 1
        }
        public enum EnumActivityType
        {
            [Display(Name = "Ofis Çalışması")]
            OfficeWorker = 0,
            [Display(Name = "Hafif Egzersiz")]
            LightExercise = 1,
            [Display(Name = "Orta Egzersiz")]
            MediumExercise = 2,
            [Display(Name = "Ağır Egzersiz")]
            HeavyExercise = 3,
            [Display(Name = "Atlet")]
            Athlete = 4
        }
        public enum EnumMealType
        {
            [Display(Name = "Sabah")]
            Morning = 0,
            [Display(Name = "Ara Öğun1")]
            Snacks1 = 1,
            [Display(Name = "Öğle")]
            Noon = 2,
            [Display(Name = "Ara Öğün2")]
            Snacks2 = 3,
            [Display(Name = "Akşam")]
            Evening = 4
        }
    }
}
