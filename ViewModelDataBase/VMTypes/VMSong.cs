﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModelDataBase.VMInterfaces;
using Windows.Storage;
using Windows.Storage.Streams;

namespace ViewModelDataBase.VMTypes
{
    public class VMSong : IFileVM
    {
        public string Type { get; set; }
        public byte[] Bytes { get; set; }
    }
}