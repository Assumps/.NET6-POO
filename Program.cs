
namespace OO.ContentContext
{
    public class Program
    {
          static void Main(String[] Args){
              var articles = new List<Article>();
              articles.Add(new Article("Artigo sobre OOP","Orientacao-Objetos"));

              foreach( var article in articles){
                  Console.WriteLine(article.Id);
                  Console.WriteLine(article.Title);
                  Console.WriteLine(article.Url);
              }

              var courses = new List<Course>();  
              var course = new Course("Fundamentos OOP","Fundamentos-OOP");

              courses.Add(course);

              var careers = new List<Career>();  
              var career = new Career("Especialista .NET","especialista-dotnet");
              var careerItem = new CareerItem(1, "Comece por Aqui", "", course);
              career.Items.Add(careerItem);
              careers.Add(career);

              foreach (var item in careers)
              {
                  Console.WriteLine(item.Title);
                  foreach (var subItem in item.Items.OrderBy(x => x.Order))
                  {
                      Console.WriteLine($"{subItem.Order} - {subItem.Title}");
                      Console.WriteLine(subItem.Course?.Title);
                      Console.WriteLine(subItem.Course?.Level);
                      foreach (var notification in subItem.Notifications)
                      {
                          System.Console.WriteLine($"{notification.Property} - {notification.Message}");
                      }
                  }
              }
          }
    }
  
    
}
