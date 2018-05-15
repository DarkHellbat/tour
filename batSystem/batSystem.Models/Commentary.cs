using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batSystem.Models
{
    class Commentary
    {
        long CommentaryID { get; set; }
        string Text { get; set; }
        User Sender { get; set; }
        File PinnedFile { get; set; }
        Commentary AnswerTo { get; set; }
    }
}
