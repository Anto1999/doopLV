using System;

namespace DOOP_LV1
{
    class Notes
    {
        private String text;
        private String author;
        private int pertinence;

        public string Text
        {
            get { return this.text; }
            set { this.text = value; }
        }
        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }
        public int Pertinence
        {
            get { return this.pertinence; }
            set { this.pertinence = value; }
        }

    }
}
