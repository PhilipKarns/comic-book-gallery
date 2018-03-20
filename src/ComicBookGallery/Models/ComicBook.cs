using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {

        //will be used to uniquely identify a comic book
        public int ID { get; set; }

        //the title of the series this comic book is part of
        public string SeriesTitle { get; set; }

        //comic book's issue number
        public int IssueNumber { get; set; }

        //comic book's description
        public string DescriptionHtml { get; set; }

        //object array that lists the artist who created the comic book
        public Artist[] Artists { get; set; }

        //indicates whether this comic book is a favorite of ours or not
        public bool Favorite { get; set; }

        //string that uniquely identifies a comic book for our users
        public string DisplayText
        {
            get
            {
                return SeriesTitle + " # " + IssueNumber;
            }
        }
            //series-title-issuenumber.jpg
        public string CoverImageFileName
        {
            get
            {
                return SeriesTitle.Replace(" ", "-")
                    .ToLower() + "-" + IssueNumber + ".jpg";                    
            }
        }
    }
}