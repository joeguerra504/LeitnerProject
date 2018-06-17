namespace LeitnerProject.Core
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }

      // need to find out how to securly add password
      public UserStatistics UserStatistics  { get; set; }
      public int UserStatisticsId { get; set; }

   }
}
