﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SearchEngineFile
{
    [XmlRoot("Category")]
    public class Category
    {
        [XmlAttribute("Name")]
        public String name { set; get; }

        public List<String> keywords { set; get; }
        public Category() { keywords = new List<string>(); }


    }
}
