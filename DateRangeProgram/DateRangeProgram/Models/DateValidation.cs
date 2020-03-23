﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DateRangeProgram.Models
{
    public class DateValidation
    {
        private const string DEFAULT_CULTURE = "eu";
        private const string EU_CULTURE = "dd'.'MM'.'yyyy";
        private const string US_CULTURE = "MM'.'dd'.'yyyy";

        private readonly string _format;
        public DateValidation()
        {
            _format = DEFAULT_CULTURE;
        }


        public DateValidation(string culture)
        {
            if (culture != null)
            {
                _format = culture;
            }
            else _format = DEFAULT_CULTURE;
        }
        public bool ValidateDate(string dateString)
        {
            if (_format == "eu")
            {
                return ValidateDateForCertainFormat(dateString, EU_CULTURE);
            }
            if (_format == "us")
            {
                return ValidateDateForCertainFormat(dateString, US_CULTURE);
            }
            Console.WriteLine("Unrecognised format");
            return false;
        }
        private bool ValidateDateForCertainFormat(string dateString, string cultureType)
        {
            DateTime dateTime;
            return (DateTime.TryParseExact(dateString,
                cultureType,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out dateTime));
        }
    }
}