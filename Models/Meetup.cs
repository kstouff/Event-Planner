using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Belt.Models;

namespace Belt.Models
{
    public class Meetup
    {
    [Key]
    public int MeetupId { get; set; }
    
    
    [Required]
    [Display( Name= "Title")]
    public string Title {get;set;}

    [Required]
    [FutureDate]
    [Display( Name= "Date")]
    public DateTime Date { get; set; }
    
    public int DurationLength { get; set; }
    public string DurationDenom { get; set; }

    [Required]
    [Display( Name= "Description")]
    public string Description {get;set;}

    public DateTime CreatedAt {get;set;} = DateTime.Now;

    

    public List<RSVP> Attendees {get; set;}
    
    public int CreatorId {get; set;}
    public User Creator { get; set; }

    

    }


}