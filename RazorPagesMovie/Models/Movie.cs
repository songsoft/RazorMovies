using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// The DataAnnotations namespace provides a set of built-in validation attributes that are applied declaratively to a class or property. 
/// DataAnnotations also contains formatting attributes like DataType that help with formatting and don't provide any validation.
/// 
/// Once DataAnnotations were applied to the model, the validation UI was enabled. 
/// 
/// These validation rules are automatically applied to Razor Pages that edit the Movie model.
/// </summary>

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Movie Title is required!")]
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }


        // DataType.Date doesn't specify the format of the date that's displayed. 
        // By default, the data field is displayed according to the default formats based on the server's CultureInfo.
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }


        // NULL will cause the program to fail
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$"), Required, StringLength(30)]
        public string Genre { get; set; }


        // Value types (such as decimal, int, float, DateTime) are inherently required and don't need the [Required] attribute.
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }


        /// <summary>
        /// Running the app without updating the database throws a SqlException:
        /// SqlException: Invalid column name 'Rating'.
        /// 
        /// The SqlException exception is caused by the updated Movie model class being different than the schema of the Movie table of the database. 
        /// (There's no Rating column in the database table.)
        /// 
        /// </summary>

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        public string Rating { get; set; }
    }

}
