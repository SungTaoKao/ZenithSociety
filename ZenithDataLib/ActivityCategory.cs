﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenithDataLib;

namespace ZenithDataLib

{
    public class ActivityCategory
    {
        [Key]
        public int ActivityCategoryId { get; set; }
        [DisplayName("Activity Description")]
        public string ActivityDescription { get; set; }
        [DisplayName("Created on")]
        public DateTime CreationDate { get; set; }

        public List<Event> Events { get; set; }
    }
}
