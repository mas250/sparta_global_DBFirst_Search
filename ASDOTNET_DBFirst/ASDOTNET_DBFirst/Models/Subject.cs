using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASDOTNET_DBFirst.Models
{
    public class Subject
    {
        private int id;
        private string topic;
        private DateTime startDate;
        private int duration;

        
        public int Id { get => id; set => id = value; }
        public string Topic { get => topic; set => topic = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public int Duration { get => duration; set => duration = value; }
    }
}