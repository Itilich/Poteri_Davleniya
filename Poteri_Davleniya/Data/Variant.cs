using System.ComponentModel.DataAnnotations;

namespace Poteri_Davleniya.Data
{
    public class Variant
    {
        [Key]
        public int ID { get; set; }
        public double pipe_lenght { get; set; }
        public int pipe_quantity { get; set; }
        public int rows_along { get; set; }
        public int rows_across { get; set; }
        public double step_along { get; set; }
        public double step_across { get; set; }
        public double pipe_diameter { get; set; }
        public double pipe_thickness { get; set; }
        public double smoke_temp { get; set; }
        public double heating_air_temp { get; set; }
        public double air_temp { get; set; }
        public double heating_air_outgo { get; set; }
        public double space_air_pass { get; set; }
        public double smoke_outgo { get; set; }
    }
}
