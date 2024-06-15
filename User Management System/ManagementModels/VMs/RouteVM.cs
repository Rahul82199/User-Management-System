﻿using System.ComponentModel.DataAnnotations;
using User_Management_System.ManagementModels.EnumModels;

namespace User_Management_System.ManagementModels.VMs
{
    public class RouteVM
    {
        public string RouteId { get; set; }

        [Required]
        public string RoutePath { get; set; }

        [Required]
        public string RouteName { get; set; }

        [Required]
        public TrueFalse Status { get; set; }
    }
}
