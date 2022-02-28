using System;
using System.Collections.Generic;

namespace DatingApp.API.Models
{
    public class Episode
    {
      public int Id { get; set; }   
      public string Url { get; set; }
      public int EpisodeNumber { get; set; }
      public string EpisodeTitle { get; set; }
      public DateTime DateAdded { get; set; }
      public string Description { get; set; }
      public virtual Screenplay Screenplay { get; set; }
      public int ScreenplayId { get; set; }  
      public ICollection<EpisodeConcept> EpisodeConcepts { get; set; }
      public ICollection<EpisodeWriter> EpisodeWriters { get; set; }
    }
}