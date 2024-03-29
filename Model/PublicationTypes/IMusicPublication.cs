﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.PublicationTypes
{
    public interface IMusicPublication
    { 
        /// <summary>
        /// Форматы песни или альбома (wav, mp3 и т.д.)
        /// </summary>
        string Formats { get; set; }

        /// <summary>
        /// Исполнитель
        /// </summary>
        string Performer { get; set; }

        /// <summary>
        /// Страна исполнителя
        /// </summary>
        string CountryPerformer { get; set; }

        /// <summary>
        /// Наименование альбома
        /// </summary>
        string Album { get; set; }

        DateTime? ReleaseYear { get; set; }
    }
}