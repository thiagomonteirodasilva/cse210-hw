public class Resume
{
  public string _name;
  public List<Job> _jobs = new List<Job>();
  public void Display()
  {
    Console.WriteLine($"Name: {_name}");
    Console.WriteLine("Jobs:");
    if (_jobs != null)
    {
      foreach (Job job in _jobs)
      {
        job.Display();
      }
    }
  }
}