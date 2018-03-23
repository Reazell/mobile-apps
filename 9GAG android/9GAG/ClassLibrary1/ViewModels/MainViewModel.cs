using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace ClassLibrary1.ViewModels
{
    public class MainViewModel : MvxViewModel {
        public MainViewModel() {
            Photos = new MvxObservableCollection<Photo>() {
                new Photo {
                    Url = "https://vignette.wikia.nocookie.net/azure-mines/images/8/81/Kappa.png/revision/latest?cb=20160725015648"
                }
            };
        }
        
        public override Task Initialize()
        {
            //TODO: Add starting logic here
		    
            return base.Initialize();
        }
        
        public IMvxCommand ResetTextCommand => new MvxCommand(ResetText);
        private void ResetText()
        {
            Text = "Hello MvvmCross";
        }

        private string _text = "Hello MvvmCross";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        public MvxObservableCollection<Photo> Photos { get; set; }
        
    }
}