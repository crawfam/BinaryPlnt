
using BinaryPlanet.Models;
using System.Collections.Generic;
using System.Linq;



namespace BinaryPlanet.ViewModels
{


    public class HomePageViewModel
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        private List<string> _imageFileNames = new List<string>();

        public List<string> ImageFileNames
        {
            get
            {
                return _imageFileNames;
            }

        }

        public HomePageViewModel()
        {
            _context = new ApplicationDbContext();

            List<Poem> poems = _context.Poems.ToList();
            
            foreach (Poem poem in poems)
            {
                if (string.IsNullOrEmpty(poem.SpecialName))
                {
                    _imageFileNames.Add("/Content/images/away/" + poem.Name.Replace(" ", "_").ToLower() + ".jpg");
                }
                else
                {
                    _imageFileNames.Add("/Content/images/away/" + poem.SpecialName + ".jpg");
                }

            }

        }


    }
}