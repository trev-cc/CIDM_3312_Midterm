using System;
using System.ComponentModel.DataAnnotations;
namespace Converter.Models{

    public class LoginViewModel
    {
        [Required(ErrorMessage = "please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="please enter a VALID email address")]
        public string Username {get;set;}
        public string Password {get;set;}
        public bool Login {get;set;}
        public bool UserCorr {get;set;}
        public bool PassCorr {get;set;}


























        /* 
        //this one holds what type of operation this will be
        public string ToConvert{ get; set; }

        //this one holds the result
        public double Result { get; set; }

        //this one holds the input number
        public float Cnum { get; set; }

        //this one does not do anything                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   Idrk stand for I don't really know :)
        public string Idrk { get; set; }

        */

       
        
    }
}