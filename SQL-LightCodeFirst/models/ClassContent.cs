using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SQL_LightCodeFirst.models
{
    public class Class
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClassId { get; set; }
        public string Title { get; set; }
        public string InstructorId { get; set; }
        public Instructor Instructor { get; set; }
    }

}
