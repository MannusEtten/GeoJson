﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoJsonLibrary.Tests
{
    [GeoJsonProperty(PropertyName = "Value")]
    public class TestEntity3
    {
        [GeoJsonGeometry("Geometry")]
        public DbGeography Geometry { get; set; }

        [GeoJsonProperty]
        public string Name { get; set; }

        public int NotInUse { get; set; }

        [GeoJsonProperty]
        public TestEntity2 SubEntity { get; set; }

        [GeoJsonProperty]
        public List<TestEntity4> SubGeometries { get; set; }

        public int Value { get; set; }

        [GeoJsonProperty]
        public List<string> Values { get; set; }
    }
}