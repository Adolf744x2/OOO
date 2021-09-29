using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Ooo
{
   public class OknoClientViewModel : NotifyViewModel
    {

        private Page currentPage;
        private Client edit;

        public OknoClientViewModel(Client edit)
        {
            this.edit = edit;
        }

        public OknoClientViewModel()
        {

        }

        public Page CurrentPage
        {
            get => currentPage;
            set
            {
                currentPage = value;
                SignalChange("CurrentPage");
            }
        }


        public CommandBinding AddClient { get; set; }
        public CommandBinding Redaction { get; set; }
        public CommandBinding Delete { get; set; }
    }
}
