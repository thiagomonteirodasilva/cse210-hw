public class Person
{
  private string _firstName;
  private string _lastName;
  public string FullName(string firstName, string lastName)
  {
    _firstName = firstName;
    _lastName = lastName;
    return $"{firstName} {lastName}";
  }
}