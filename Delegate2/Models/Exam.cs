using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Delegate2.Models
{
    internal class Exam
    {
        private byte _point;
        public Student Student { get; set; }
        public byte Point 
        {
            get => _point;
            set 
            {
                if (value<=100 && value >= 0)
                {
                    _point = value;
                }
            }
        }
        public string Subject { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Exam(Student student,byte point,string subject,DateTime startdate,DateTime enddate)
        {
            Student = student;
            Point = point;
            Subject = subject;
            StartDate = startdate;
            EndDate = enddate;
        }
    }
}
