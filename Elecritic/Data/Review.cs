using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;



namespace Elecritic.Data
{ 
	public class Review
    { 
		public string AuthorId { get; set; }

		[Required (ErrorMessage = "Este campo no puede estar vacío")]
		public string ReviewText {get; set;}

		[Required]
		[Range(1,5, ErrorMessage = "Rating sale del rango permitido")]
		public int RatingProduct { get; set; }

		public string ProductId { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacío")]
        public string Recommended { get; set; }
	
	
    public Review()
    {

    }

    public Review(string authorId, string reviewText, int ratingProduct, string productId, string recommended)
    {
        AuthorId = authorId;
        ReviewText = reviewText;
        RatingProduct = ratingProduct;
        ProductId = productId;
        Recommended = recommended;


    }

    public void clear()
    {
        AuthorId = "";
        ReviewText = "";
        RatingProduct = 0;
        ProductId = "";
        Recommended = "";


    }
   }
}