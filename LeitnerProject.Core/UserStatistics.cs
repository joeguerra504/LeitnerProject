using System.Collections.Generic;

namespace LeitnerProject.Core
{
    public class UserStatistics
    {
        public int Id { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }
        public List<Test>  Tests { get; set; }



   }
}
