using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorWeather.Model
{
    public class Headline : INotifyPropertyChanged
    {
        private DateTime effectiveDate;
        private int effectiveEpochDate;
        private int severity;
        private string text;
        private string category;
        private DateTime endDate;
        private int endEpochDate;
        private string link;

        public DateTime EffectiveDate
        {
            get
            {
                return effectiveDate;
            }
            set
            {
                effectiveDate = value;
                OnPropertyChanged("EffectiveDate");
            }
        }


        public int EffectiveEpochDate
        {
            get
            {
                return effectiveEpochDate;
            }
            set
            {
                effectiveEpochDate = value;
                OnPropertyChanged("EffectiveEpochDate");
            }
        }


        public int Severity
        {
            get
            {
                return severity;
            }
            set
            {
                severity = value;
                OnPropertyChanged("Severity");
            }
        }

        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                OnPropertyChanged("Text");
            }
        }

        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
                OnPropertyChanged("Category");
            }
        }

        public DateTime EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                endDate = value;
                OnPropertyChanged("EndDate");
            }
        }

        public int EndEpochDate
        {
            get
            {
                return endEpochDate;
            }
            set
            {
                endEpochDate = value;
                OnPropertyChanged("EndEpochDate");
            }
        }

        public string Link
        {
            get
            {
                return link;
            }
            set
            {
                link = value;
                OnPropertyChanged("Link");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class Minimum : INotifyPropertyChanged
    {
        private double value;
        private string unit;
        private int unitType;

        public double Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
                OnPropertyChanged("Value");
            }
        }

        public string Unit
        {
            get
            {
                return unit;
            }
            set
            {
                unit = value;
                OnPropertyChanged("Unit");
            }
        }

        public int UnitType
        {
            get
            {
                return unitType;
            }
            set
            {
                unitType = value;
                OnPropertyChanged("UnitType");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class Maximum : INotifyPropertyChanged
    {
        private double value;
        private string unit;
        private int unitType;

        public double Value
        {
            get
            {
                return unitType;
            }
            set
            {
                this.value = value;
                OnPropertyChanged("Value");
            }
        }

        public string Unit
        {
            get
            {
                return unit;
            }
            set
            {
                unit = value;
                OnPropertyChanged("Unit");
            }
        }

        public int UnitType
        {
            get
            {
                return unitType;
            }
            set
            {
                unitType = value;
                OnPropertyChanged("UnitType");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class Temperature : INotifyPropertyChanged
    {
        private Minimum minimum;
        private Maximum maximum;

        public Minimum Minimum
        {
            get
            {
                return minimum;
            }
            set
            {
                minimum = value;
                OnPropertyChanged("Minimum");
            }
        }

        public Maximum Maximum
        {
            get
            {
                return maximum;
            }
            set
            {
                maximum = value;
                OnPropertyChanged("Maximum");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class Day : INotifyPropertyChanged
    {
        private int icon;
        private string iconPhrase;
        private bool hasPrecipitation;
        private string precipitationType;
        private string precipitationIntensity;

        public int Icon
        {
            get
            {
                return icon;
            }
            set
            {
                icon = value;
                OnPropertyChanged("Icon");
            }
        }

        public string IconPhrase
        {
            get
            {
                return iconPhrase;
            }
            set
            {
                iconPhrase = value;
                OnPropertyChanged("IconPhrase");
            }
        }

        public bool HasPrecipitation
        {
            get
            {
                return hasPrecipitation;
            }
            set
            {
                hasPrecipitation = value;
                OnPropertyChanged("HasPrecipitation");
            }
        }

        public string PrecipitationType
        {
            get
            {
                return precipitationType;
            }
            set
            {
                precipitationType = value;
                OnPropertyChanged("PrecipitationType");
            }
        }

        public string PrecipitationIntensity
        {
            get
            {
                return precipitationIntensity;
            }
            set
            {
                precipitationIntensity = value;
                OnPropertyChanged("PrecipitationIntensity");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class Night : INotifyPropertyChanged
    {
        private int icon;
        private string iconPhrase;
        private bool hasPrecipitation;
        private string precipitationType;
        private string precipitationIntensity;

        public int Icon
        {
            get
            {
                return icon;
            }
            set
            {
                icon = value;
                OnPropertyChanged("Icon");
            }
        }

        public string IconPhrase
        {
            get
            {
                return iconPhrase;
            }
            set
            {
                iconPhrase = value;
                OnPropertyChanged("IconPhrase");
            }
        }

        public bool HasPrecipitation
        {
            get
            {
                return hasPrecipitation;
            }
            set
            {
                hasPrecipitation = value;
                OnPropertyChanged("HasPrecipitation");
            }
        }

        public string PrecipitationType
        {
            get
            {
                return precipitationType;
            }
            set
            {
                precipitationType = value;
                OnPropertyChanged("PrecipitationType");
            }
        }

        public string PrecipitationIntensity
        {
            get
            {
                return precipitationIntensity;
            }
            set
            {
                precipitationIntensity = value;
                OnPropertyChanged("PrecipitationIntensity");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class DailyForecast : INotifyPropertyChanged
    {
        private DateTime date;
        private int epochDate;
        private Temperature temperature;
        private Day day;
        private Night night;
        private IList<string> sources;
        private string link;

        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
                OnPropertyChanged("Date");
            }
        }

        public int EpochDate
        {
            get
            {
                return epochDate;
            }
            set
            {
                epochDate = value;
                OnPropertyChanged("EpochDate");
            }
        }

        public Temperature Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                temperature = value;
                OnPropertyChanged("Temperature");
            }
        }

        public Day Day
        {
            get
            {
                return day;
            }
            set
            {
                day = value;
                OnPropertyChanged("Day");
            }
        }

        public Night Night
        {
            get
            {
                return night;
            }
            set
            {
                night = value;
                OnPropertyChanged("Night");
            }
        }

        public IList<string> Sources
        {
            get
            {
                return sources;
            }
            set
            {
                sources = value;
                OnPropertyChanged("Sources");
            }
        }

        public string Link
        {
            get
            {
                return link;
            }
            set
            {
                link = value;
                OnPropertyChanged("Link");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class AccuWeather : INotifyPropertyChanged
    {
        private Headline headline;
        private IList<DailyForecast> dailyForecasts;

        public Headline Headline
        {
            get
            {
                return headline;
            }
            set
            {
                headline = value;
                OnPropertyChanged("Headline");
            }
        }

        public IList<DailyForecast> DailyForecasts
        {
            get
            {
                return dailyForecasts;
            }
            set
            {
                dailyForecasts = value;
                OnPropertyChanged("DailyForecasts");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

}
