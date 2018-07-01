using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Web;

namespace BinaryPlanet.Models
{
    public class Poem
    {
        private List<PoemFileNames> poems = new List<PoemFileNames>();

        public string Name { get; set; }
        public string FileName { get; set; }
        public string NextPoemFileName { get; set; }    

        public Poem ()
        {
            poems.Add(new PoemFileNames { FileName = "fugue_before_lunch", NextPoemFileName = "santa_clara_server_room" });

            poems.Add(new PoemFileNames { FileName = "santa_clara_server_room", NextPoemFileName = "sketch_of_a_poem_in_10_broken_lines" });

            poems.Add(new PoemFileNames { FileName = "sketch_of_a_poem_in_10_broken_lines", NextPoemFileName = "brain_imaging" });

            poems.Add(new PoemFileNames { FileName = "brain_imaging", NextPoemFileName = "portrait_of_a_family_as_four_discrete_stanzas" });

            poems.Add(new PoemFileNames { FileName = "portrait_of_a_family_as_four_discrete_stanzas", NextPoemFileName = "", IsLast = true });
            
        }

        public string getNextPoemFileName(string fileName)
        {
            try
            {
                return poems.Where(s => s.FileName.ToLower() == fileName.ToLower()).Select(s => s.NextPoemFileName).FirstOrDefault();
            }
            catch
            {
                return string.Empty;
            }
        }

        public PoemFileNames getPoem(string fileName)
        {
            return poems.Where(s => s.FileName.ToLower() == fileName.ToLower()).FirstOrDefault();
        }

    }

    public class PoemFileNames
    {
        private bool islast = false;

        public string Name
        {
            get
            {
                TextInfo UsaTextInfo = new CultureInfo("en-US", false).TextInfo;
                return UsaTextInfo.ToTitleCase(this.FileName.Replace("_", " "));
            }
        }

        public string FileName { get; set; }
        public string NextPoemFileName { get; set; }
        public bool IsLast
        {
            get { return islast; }
            set { islast = value; }
        }
    }
}