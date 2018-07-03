using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Web;

namespace BinaryPlanet.Models
{
    public class Poems
    {
        private List<Poem> poems = new List<Poem>();

        public Poems ()
        {
            poems.Add(new Poem(1, "Fugue Before Lunch", 1, 0, 2, true));
            poems.Add(new Poem(2, "Santa Clara Server Room", 1, 1, 3));
            poems.Add(new Poem(3, "Sketch of a Poem in 10 Broken Lines", 1, 2, 4));
            poems.Add(new Poem(4, "Brain Imaging", 1, 3, 5));
            poems.Add(new Poem(5, "Portrait of a Family as Four Discrete Stanzas", 1, 4, 6));
            poems.Add(new Poem(6, "One Night in the Dharma Lounge", 1, 5, 7, false, true));
        }

        public Poem getPoem(string name)
        {
            return poems.Where(s => s.Name.ToLower() == name.ToLower()).FirstOrDefault();
        }

        public Poem getPoem (int Id)
        {
            return poems.Where(s => s.Id == Id).FirstOrDefault();
        }

    }


    public class Poem
    {
        private string _name;
        private int _id { get; set; }
        private int _section { get; set; }
        private int _prevPoemId { get; set; }
        private int _nextPoemId { get; set; }


        private bool _isLast = false;
        private bool _isFirst = false;

        public int Id { get { return _id; } }
        public int Section { get { return _section; } }
        public int PrevPoemId { get { return _prevPoemId; } }
        public int NextPoemId { get { return _nextPoemId; } }

        public Poem(int id, string name, int section, int prevPoemId, int nextPoemId, bool IsFirst = false, bool IsLast = false)
        {
            _id = id;
            _name = name;
            _section = section;
            _prevPoemId = prevPoemId;
            _nextPoemId = nextPoemId;

            _isFirst = IsFirst;
            _isLast = IsLast;
        }

        public string Name
        {
            get
            {
                TextInfo UsaTextInfo = new CultureInfo("en-US", false).TextInfo;
                return UsaTextInfo.ToTitleCase(_name);
            }
        }

        public string FileNameJpg
        {
            get
            {
                return _name.ToLower().Replace(" ", "_") + ".jpg";
            }
        }

        public string FileName
        {
            get
            {
                return _name.ToLower().Replace(" ", "_");
            }
        }
               
        public bool IsLast
        {
            get { return _isLast; }
            set { _isLast = value; }
        }

        public bool IsFirst
        {
            get { return _isFirst; }
            set { _isLast = value; }
        }
    }

}