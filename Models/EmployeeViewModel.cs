using System.ComponentModel;

namespace EmployeeData.Models
{
	public class EmployeeViewModel
	{
		public int Id { get; set; }

		[DisplayName("First Name")]
		public string FirstName { get; set; }

		[DisplayName("Last Name")]
		public string LastName { get; set; }

		[DisplayName("Date Of Birth")]

		public DateTime DateOfBirth { get; set; }


		[DisplayName("E-mail")]
		public string Email { get; set; }

		public double Salary { get; set; }

		[DisplayName("Name")]
		public string FullName
		{
			get { return FirstName + " " + LastName; }

		}
	}

}