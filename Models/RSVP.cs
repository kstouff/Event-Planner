using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Belt.Models;

namespace Belt.Models
{
    public class RSVP
    {

    [Key]
    public int RSVPId { get; set; }

    public int MeetupId { get; set; }

    public int UserId { get; set; }

    public User User { get; set; }
    public Meetup Meetup { get; set; }


    }
}