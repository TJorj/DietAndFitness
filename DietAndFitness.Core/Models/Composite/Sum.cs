﻿using DietAndFitness.Core.Models.Base;
using System;

namespace DietAndFitness.Core.Models.Composite
{
    public class Sum : ModelBase, ICloneable
    {
        private double? calories;
        private double? proteins;
        private double? carbohydrates;
        private double? fats;
        private string caloriesText;
        public string CaloriesText
        {
            get
            {
                return caloriesText;
            }
            set
            {
                if (caloriesText == value)
                    return;
                caloriesText = value;
                OnPropertyChanged();
            }
        }
        public string Prefix { get; set; }
      
        #region Properties
        public double? Calories
        {
            get
            {
                return calories;
            }
            set
            {
                if (calories == value)
                    return;
                calories = value;
                OnPropertyChanged();
                CaloriesText = Prefix + (int)calories;
            }
        }
        public double? Proteins
        {
            get
            {
                return proteins;
            }
            set
            {
                if (proteins == value)
                    return;
                proteins = value;
                OnPropertyChanged();
            }
        }

        public double? Carbohydrates
        {
            get
            {
                return carbohydrates;
            }
            set
            {
                if (carbohydrates == value)
                    return;
                carbohydrates = value;
                OnPropertyChanged();
            }
        }
        public double? Fats
        {
            get
            {
                return fats;
            }
            set
            {
                if (fats == value)
                    return;
                fats = value;
                OnPropertyChanged();
            }
        }
        #endregion
        public Sum(string prefix = "")
        {
            //WARNING: must be > 0 else LinearGauge will crash
            Calories = 1;
            Proteins = 0;
            Carbohydrates = 0;
            Fats = 0;
            Prefix = prefix;
        }

        public Sum(Profile activeProfile)
        {
        }

        public void Add(CompleteFoodItem item)
        {
            Calories += item.Calories;
            Proteins = Math.Round((Proteins ?? 0 ) + item.Proteins );
            Carbohydrates = Math.Round((Carbohydrates ?? 0) + item.Carbohydrates);
            Fats = Math.Round((Fats ?? 0) + item.Fats);
        }
        public void Remove(CompleteFoodItem item)
        {
            Calories -= item.Calories;
            Proteins -= item.Proteins;
            Carbohydrates -= item.Carbohydrates;
            Fats -= item.Fats;
        }
        public void Reset()
        {
            Calories = 0;
            Proteins = 0;
            Carbohydrates = 0;
            Fats = 0;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

}
