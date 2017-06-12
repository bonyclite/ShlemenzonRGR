﻿using Model.UserTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace NewsForum.View.Converters
{
    class IsModeratorAccessConverter : IValueConverter
    {
        string nonModerator = "";
        string moderator = "";

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if ((UserAccessLevel)value == UserAccessLevel.Admin)
                return moderator;

            return nonModerator;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}