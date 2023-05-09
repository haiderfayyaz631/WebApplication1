using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{
	[Keyless]
	public class Superdata
	{
		
		public string Carbrand { get; set; }
		public int model { get; set; }
		public string CarName { get; set; }
		public int cardriven { get; set; }



	}
}
