﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsForum.Model
{
    interface IFileSettings
    {
        string Name { get; set; }
        string FullPath { get; set; }
    }
}