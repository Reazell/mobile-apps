using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Media.Imaging;
using System.Windows.Controls;

namespace ListBoxImages
{
    public class CustomItem : INotifyPropertyChanged
    {
        public CustomItem(string uriSource)
        {
            BitmapImage source = new BitmapImage();
            source.BeginInit();
            source.UriSource = new Uri(uriSource, UriKind.Relative);
            source.EndInit();

            ThumbnailImage = new Image();
            ThumbnailImage.Source = source;
        }
        private Image m_thumbnailImage;
        public Image ThumbnailImage
        {
            get
            {
                return m_thumbnailImage;
            }
            set
            {
                m_thumbnailImage = value;
                OnPropertyChanged("ThumbnailImage");
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
