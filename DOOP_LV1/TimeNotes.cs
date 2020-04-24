using System;
using System.Collections.Generic;
using System.Text;

namespace DOOP_LV1
{
    class TimeNotes : Notes 
    {
        DateTime TimeOfNote;
        public TimeNotes() : base ()
        {
            this.TimeOfNote = DateTime.Now;
            
        }
        public TimeNotes(string text, string author, int pertinence) : base( text,  author, pertinence)
        {
            this.TimeOfNote = DateTime.Now;
        }
        public override string ToString()
        {
            return base.ToString()+TimeOfNote.ToString();

        }

    }
}
