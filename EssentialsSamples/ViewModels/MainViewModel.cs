using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace EssentialsSamples.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {

        #region Fields

        private string _deviceBrand;
        private string _deviceModel;
        private string _deviceName;
        private string _devicePlatform;
        private string _connectivityText;
        private string _textToSpeak;

        private int _connectivity;

        private double _heading;

        private Command _speakCommand;

        public event PropertyChangedEventHandler PropertyChanged;


        #endregion

        #region Properties

        public string DeviceBrandText
        {
            get
            {
                return $"Brand: {_deviceBrand}";
            }
        }

        public string DeviceNameText
        {
            get
            {
                return $"Name: {_deviceName}";
            }
        }

        public string DeviceModelText
        {
            get
            {
                return $"Model: {_deviceModel}";
            }
        }

        public string DevicePlatformText
        {
            get
            {
                return $"Platform: {_devicePlatform}";
            }
        }

        public string ConnectivityText
        {
            get { return _connectivityText; }
            set
            {
                _connectivityText = value;
                OnPropertyChanged();
            }
        }

        public string TextToSpeak
        {
            get { return _textToSpeak; }
            set
            {
                _textToSpeak = value;
                OnPropertyChanged();
            }
        }

        public int Connectivity
        {
            get { return _connectivity; }
            set
            {
                _connectivity = value;
                OnPropertyChanged();
            }
        }

        public double Heading
        {
            get { return _heading; }
            set
            {
                _heading = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Commands

        public Command SpeakCommand
        {
            get { return _speakCommand; }
            set
            {
                _speakCommand = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Constructor

        public MainViewModel()
        {
            _deviceBrand = string.Empty;
            _deviceModel = string.Empty;
            _deviceName = string.Empty;
            _devicePlatform = string.Empty;
            _textToSpeak = string.Empty;

            _connectivity = 0;
            _connectivityText = "Unknown";
            _speakCommand = new Command(speak);
        }

        #endregion

        #region Methods

        private void speak()
        {
            if (!string.IsNullOrEmpty(TextToSpeak))
            {
            }
        }


        protected void OnPropertyChanged([CallerMemberName]string name = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        #endregion

    }
}