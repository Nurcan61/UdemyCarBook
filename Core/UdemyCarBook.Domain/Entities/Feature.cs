﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class Feature
    {
        public int FeatureId {  get; set; }
        public string FeatureName { get; set; }
        public List<Feature> CarFeatures { get; set; }
    }
}
