﻿using App.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities
{
    public class Person : BaseEntity
    {
        public string Age { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }

    }
}
