using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace History
{
    public class Info
    {
        public string Title { get; set; }
        public string LBText { get; set; }
        public Info(string Title, string LBText)
        {
            this.Title = Title;
            this.LBText = LBText;
        }

        //public pic LBText { get; set; }

    }
}
