﻿using LearningExperience.Models;
using LearningExperience.Models.Enums;
using System;

namespace LearningExperience.DTO
{
    public class PatientDTO
    {
        public string? Id { get; set;}
        public string Name { get; set; }
        public int Age { get; set; }
        public DiseaseLevel DiseaseLevel { get; set; }
        public bool ColorsIssue { get; set; }
        public string? FavoriteObject { get; set; }
        public string? FavoriteJoke { get; set; }
        public string? FavoritePastTime { get; set; }
        public string? Observation { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}
