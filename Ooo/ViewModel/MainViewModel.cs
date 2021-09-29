using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Ooo
{
    public class MainViewModel : NotifyViewModel
    {
        private Page currentPage;

        public Page CurrentPage
        {
            get => currentPage;
            set
            {
                currentPage = value;
                SignalChange("CurrentPage");
            }
        }
        public CommandBinding OknoClient { get; set; }

        public MainViewModel()
        {
            Pager.ChangePage += (o, e) => CurrentPage = e;
            OknoClient = new CommandBinding(() =>
            {
                Pager.ChangedPageTo(new OknoClient());

            });
        }

    }

}
