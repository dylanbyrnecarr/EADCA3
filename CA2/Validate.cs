using System;
using System.ComponentModel.DataAnnotations;

namespace ValidateSearch
{
    public class ValidSearch
    {
        [Required(ErrorMessage = "Search cannot be empty")]
        [StringLength(30, ErrorMessage = "Search query too large, enter less than 2,000 characters.")]

        public string SearchInput { get; set; }

        public override string ToString()
        {
            return $"{SearchInput}";
        }
    }
}