namespace ODataApp.Models
{
    public class Employee
    {
        public Employee()
        {
        }
        public Employee(int id, string fullName, string role, string city)
        {
            this.Id = id;
            this.FullName = fullName;
            this.Role = role;
            this.City = city;
        }
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public string City { get; set; }
    }
}
