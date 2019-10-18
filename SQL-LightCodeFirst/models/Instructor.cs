using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SQL_LightCodeFirst.models
{
    public class Instructor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string InstructorId { get; set; }
        public string Name { get; set; }
        public List<Class> Classes { get; } = new List<Class>();
    }

}
