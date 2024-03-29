﻿using Model.PublicationTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModelDataBase.VMInterfaces;
using System.Collections.ObjectModel;
using ViewModelDataBase.VMTypes;
using Model;
using Newtonsoft.Json;

namespace ViewModelDataBase.VMPublicationTypes
{
    public class VMGamePublication : VMPublication, IGamePublication, IListBitmapImages
    {
        [Property("CompanyDeveloper")]
        public string CompanyDeveloper { get; set; }

        [Property("InterfaceLanguage")]
        public string InterfaceLanguage { get; set; }

        [Property("Platform")]
        public string Platform { get; set; }

        [Property("MultiPlayer")]
        public bool MultiPlayer { get; set; }

        [Property("ReleaseYear")]
        public DateTime? ReleaseYear { get; set; }

        //public List<VMGenre> ListGenres { get; set; }
        private IEnumerable<VMFile> listImages;
        [JsonIgnore]
        public List<VMFile> ListImages
        {
            get
            {
                if (listImages == null)
                {
                    listImages = from f in ListFiles
                                 where FilterTypes.FiltersImage
                                 .Contains(f.Type.First() == '.' ? f.Type.Substring(1) : f.Type)
                                 select f as VMFile;
                }
                return listImages.ToList();
            }
        }

        public VMGamePublication()
        {
            TypePublication = PublicationType.Game;
        }
    }
}