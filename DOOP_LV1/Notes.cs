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
        public string getText(){
            return this.text;
        }
        public string getAuthor() {
            return this.Author;
        }
        public int getPertinence()
        {
            return this.pertinence;
        }
        public void setName(string text){
            this.text = text;
        }
       
        public void setPertinence(int pertinence)
        {
            this.pertinence = pertinence;
        }
     

        public Notes()
        {
            this.text = string.Empty;
            this.author = string.Empty;
            this.pertinence = 0;
        }


        public Notes(string text,string author, int pertinence)
        {
            this.text = text;
            this.author = author;
            this.pertinence = pertinence;

        }

        public Notes(string text,string author)
        {
            this.text = text;
            this.author = author;

        }
        public override string ToString()
        {
            return this.text + this.author + this.pertinence;
           
        }



    }
}
