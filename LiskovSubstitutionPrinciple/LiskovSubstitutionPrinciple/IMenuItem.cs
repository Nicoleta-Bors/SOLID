﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public interface IMenuItem
    {
        string Name { get; }
        decimal Price { get; }
        string Description { get; }
    }
}
