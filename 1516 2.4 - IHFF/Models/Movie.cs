﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IHFF.Models
{
    [Table("Movie")]
    public class Movie : Event
    {
        public Movie() { }

        public Movie(string title, string director, Int16 yearOfRelease, byte rating, string actors, string description, string url,
            string image, string extra, TimeSpan duration, string description_NL, decimal price, string youtubeLink)
        {
            this.Title = title;
            this.Director = director;
            this.YearOfRelease = yearOfRelease;
            this.IMDBRating = rating;
            this.Actors = actors;
            this.Description = description;
            this.IMDBUrl = url;
            this.Image = image;
            this.ExtraInfo = extra;
            this.Duration = duration;
            this.Description_NL = description_NL;
            this.Price = price;
            this.YoutubeLink = youtubeLink;
        }
        
        public string Title { get; set; }
        public string Director { get; set; }
        public Int16 YearOfRelease { get; set; }
        public byte IMDBRating { get; set; }
        public string Actors { get; set; }
        public string Description { get; set; }
        public string IMDBUrl { get; set; }
        public string Image { get; set; }
        public override string ExtraInfo { get; set; }
        public override TimeSpan Duration { get; set; }
        public string Description_NL { get; set; }
        public decimal Price { get; set; }
        public string YoutubeLink { get; set; }

        [NotMapped]
        public IEnumerable<Event> Airings { get; set; }

        public override string GetName()
        {
            return this.Title;
        }

        public override string GetImage()
        {
            return this.Image;
        }
    }
}