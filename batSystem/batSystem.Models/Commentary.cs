using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batSystem.Models
{
    public class Commentary
    {
        public long CommentaryID { get; set; }
        public string Text { get; set; }
        public User Sender { get; set; }
        public File PinnedFile { get; set; }
        public Commentary AnswerTo { get; set; }
    }
}
