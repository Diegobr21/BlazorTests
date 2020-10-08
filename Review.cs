using System;

public class Review
{
	public string AuthorId { get; set; }

	[Required]
	public string ReviewText {get; set;}

	public float RatingProduct { get; set; }

	public string ProductId { get; set; }
	
}
