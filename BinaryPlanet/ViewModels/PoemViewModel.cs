﻿using BinaryPlanet.Models;
using System.Collections.Generic;
using System.Linq;


namespace BinaryPlanet.ViewModels
{
    public class PoemViewModel
    {
        private readonly Poem _poem;
        private readonly string _fileName;
        private readonly int _minSeq;
        private readonly int _maxSeq;
        private readonly ApplicationDbContext _context;
        private readonly List<int?> _sequenceNumbers;

        public PoemViewModel(int Id)
        {
            _context = new ApplicationDbContext();

            _poem = _context.Poems.Where(p => p.Id == Id).FirstOrDefault();

            _fileName = string.IsNullOrEmpty(_poem.SpecialName) ? _poem.Name.ToLower().Replace(" ", "_") : _poem.SpecialName;

            _minSeq = (int) _context.Poems.Select(p => p.Sequence).Min();
            _maxSeq = (int) _context.Poems.Select(p => p.Sequence).Max();

            _sequenceNumbers = _context.Poems.Where(p => p.Sequence != null).OrderBy(p => p.Sequence).Select(p => p.Sequence).ToList();

        }


        public string Name
        {
            get
            {
                return _poem.Name;
            }
        }

        public string FileNameJpg
        {
            get
            {
                return "../../Content/images/away/" + _fileName + ".jpg";
            }
        }

        public string FileNameMP3
        {
            get
            {
                return "../../Content/audio/" + _fileName + ".mp3";
            }
        }

        public string FileNameView
        {
            get
            {
                return _fileName;
            }
        }

        public int NextPoemId
        {
            get
            {
                if (_poem.Sequence == _maxSeq)
                {
                    return _context.Poems.Where(p => p.Sequence == _minSeq).Select(p => p.Id).Single();
                }
                else
                {
                    int index = _sequenceNumbers.IndexOf(_poem.Sequence);
                    int nextSequenceNum = (int) _sequenceNumbers[index + 1];
                    return _context.Poems.Where(p => p.Sequence == nextSequenceNum).Select(p => p.Id).FirstOrDefault();
                }
            }
        }

        public int PrevPoemId
        {
            get
            {
                if (_poem.Sequence == _minSeq)
                {
                    return _context.Poems.Where(p => p.Sequence == _maxSeq).Select(p => p.Id).Single();
                }
                else
                {
                    int index = _sequenceNumbers.IndexOf(_poem.Sequence);
                    int prevSequenceNum = (int) _sequenceNumbers[index - 1];
                    return _context.Poems.Where(p => p.Sequence == prevSequenceNum).Select(p => p.Id).FirstOrDefault();
                }
            }

        }

        public string GetPoemName(int Id)
        {
            return _context.Poems.Where(p => p.Id == Id).Select(p => p.Name).FirstOrDefault().ToString();
        }


    }
}