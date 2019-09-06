//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebGUI.App_Data
{
    using System.ComponentModel.DataAnnotations;

    public partial class Contact
    {
        public int ContactId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please add your name")]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please add your Email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "You have entered an invalidet Email. You should enter a valid one.")]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please add Message Supject")]
        public string Subject { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please add your Phone")]
        [RegularExpression(@"(01)(0|1|2|5)[0-9]{8}", ErrorMessage = "It is not a correct phone")]
        public string Phone { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please add message content")]
        public string Massage { get; set; }
    }
}
