﻿using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prism.Infrastucture
{
    public interface IView
    {
        IViewModel ViewModel { get; set; }
    }
}