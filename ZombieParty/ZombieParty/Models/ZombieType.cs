using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using ZombieParty.Models;



namespace ZombieParty.Models
{
    public class ZombieType
    {

        public int Id { get; set; }
        [Display(Name = "Type Name")]
        [Required(ErrorMessage = "Type Name has to be filled.")]
        public string TypeName { get; set; }



    }
}
