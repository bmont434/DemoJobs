using static System.Console;
class DemoJobs2
{
   static void Main()
   {
      Job job1 = new Job();
      Job job2 = new Job();
      Job job3 = new Job();
      job1.Description = "painting";
      job1.Time = 10 ;
      job1.Hourly = 100.00;
      job2.Description = "dog walking";
      job2.Time = 1;
      job2.Hourly = 10.00;
      job3 = job1 + job2;
      Display(job1);
      Display(job2);
      Display(job3);
   }
   internal static void Display(Job j)
   {
       WriteLine("Job : {0} is {1} per hour for {2} hours.\n    Total = {3}",
          j.Description, j.Hourly.ToString("C"), j.Time, j.Total.ToString("C"));
   }
}

class Job
{
   private string description;
   private double time;
   private double hourly;
   private double total;
   public string Description
   {
      get
      {
         return description;
      }
      set
      {
         description = value;
      }
   }
   public double Time
   {
      get
      {
         return time;
      }
      set
      {
         time = value;
         CalcTotal();
      }
   }
   public double Hourly
   {
      get
      {
         return hourly;
      }
      set
      {
         hourly = value;
         CalcTotal();
      }
   }
   public double Total
   {
      get
      {
         return total;
      }
   }
   private void CalcTotal()
   {
      total = Time * Hourly;
   }
   public static Job operator+(Job j1, Job j2)
   {
      Job temp = new Job();
      temp.Description = j1.Description + " and " + j2.Description;
      temp.Time = j1.Time + j2.Time;
      double ttl = (j1.Time * j1.Hourly) + (j2.Time * j2.Hourly);
      temp.Hourly = ttl / temp.Time;
      return temp;
   }
}
