using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Quotes
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private int _index = 0;
        private string[] _quotes = new string[]
        {
            "Life is like riding a bicycle. To keep your balance, you must keep moving.",
            "You can't blame gravity for falling in love.",
            "Look deep into nature, and then you will understand everything better."
        };

        public MainPage()
        {
            InitializeComponent();
            currentQuote.Text = _quotes[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes.Length)
                _index = 0;

            currentQuote.Text = _quotes[_index];
        }
    }
}
