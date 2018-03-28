using System.ComponentModel;
namespace BindToCodeBehind
{
    public class MyClass : INotifyPropertyChanged
    {
        private string _myText = "text my MyClass";

        public string MyText
        {
            get { return _myText; }
            set
            {
                _myText = value;
                RaisePropertyChanged("MyText");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}