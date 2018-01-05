using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project.Models.WeatherModels
{
    public class LatLngModel
    {
        [Required(ErrorMessage = "Please enter a Lattitude Value")]
        public double lat { get; set; }

        [Required(ErrorMessage = "Please enter a Longitude Value")]
        public double lng { get; set; }
    }
}