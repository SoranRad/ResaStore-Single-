using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.Xazane.Model.Models
{
   public class PrintCheck
    {
        public int              id          { get; set; }
        [Required]
        [StringLength(100)]
        public string           title       { get; set; }
        public int              size_x      { get; set; }
        public int              size_y      { get; set; }
        public int              date_h_x    { get; set; }
        public int              date_h_y    { get; set; }
        public int              date_a_x    { get; set; }
        public int              date_a_y    { get; set; }
        public int              mab_h_x     { get; set; }
        public int              mab_h_y     { get; set; }
        public int              mab_a_x     { get; set; }
        public int              mab_a_y     { get; set; }
        public int              vajh_x      { get; set; }
        public int              vajh_y      { get; set; }
        public int              emz_1_x     { get; set; }
        public int              emz_1_y     { get; set; }
        public int              emz_2_x     { get; set; }
        public int              emz_2_y     { get; set; }
        public int              emz_3_x     { get; set; }
        public int              emz_3_y     { get; set; }
        [Required]
        [StringLength(100)]
        public string           emz_1_txt   { get; set; }
        [Required]
        [StringLength(100)]
        public string           emz_2_txt   { get; set; }
        [Required]
        [StringLength(100)]
        public string           emz_3_txt   { get; set; }
        [Required]
        [StringLength(100)]
        public string           date_h_o    { get; set; }
        [Required]
        [StringLength(100)]
        public string           date_h_c    { get; set; }
        [Required]
        [StringLength(100)]
        public string           date_a_o    { get; set; }
        [Required]
        [StringLength(100)]
        public string           date_a_c    { get; set; }
        [Required]
        [StringLength(100)]
        public string           mab_h_o     { get; set; }
        [Required]
        [StringLength(100)]
        public string           mab_h_c     { get; set; }
        [Required]      
        [StringLength(100)]
        public string           mab_a_o     { get; set; }
        [Required]
        [StringLength(100)]
        public string           mab_a_c     { get; set; }
        [Required]
        [StringLength(100)]
        public string           vajh_o      { get; set; }
        [Required]
        [StringLength(100)]
        public string           vajh_c      { get; set; }
        [Required]
        [StringLength(100)]
        public string           emz_1_o     { get; set; }
        [Required]
        [StringLength(100)]
        public string           emz_1_c     { get; set; }
        [Required]
        [StringLength(100)]
        public string           emz_2_o     { get; set; }
        [Required]
        [StringLength(100)]
        public string           emz_2_c     { get; set; }
        [Required]
        [StringLength(100)]
        public string           emz_3_o     { get; set; }
        [Required]
        [StringLength(100)]
        public string           emz_3_c     { get; set; }
        [Required]
        public byte[]           Tasvir      { get; set; }
    }
}
