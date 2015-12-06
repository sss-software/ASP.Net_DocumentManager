﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IBC_Forms.Model
{
    public class Form
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Field[] Fields { get; set; }
        public string HTMLTemplate { get; set; }
        public string DocXTemplatePath { get; set; }
    }
}