using System;

namespace Assignment
{
    // 1
    //#region IShape interface
    //public interface IShape
    //{
    //    double Area { get; }
    //    void DisplayShapeInfo();
    //}
    //#endregion
    //#region Circle interface
    //public interface ICircle : IShape
    //{
    //    double Radius { get; set; }
    //}
    //#endregion
    //#region Rectangle interface
    //public interface IRectangle : IShape
    //{
    //    double Width { get; set; }
    //    double Height { get; set; }
    //}
    //#endregion
    //#region class Circle 
    //public class Circle : ICircle
    //{
    //    public double Radius { get; set; }

    //    public double Area => Math.PI * Radius * Radius;

    //    public Circle(double radius)
    //    {
    //        Radius = radius;
    //    }

    //    public void DisplayShapeInfo()
    //    {
    //        Console.WriteLine($"Circle: Radius = {Radius}, Area = {Area:F2}");
    //    }
    //}
    //#endregion
    //#region class Rectangle 
    //public class Rectangle : IRectangle
    //{
    //    public double Width { get; set; }
    //    public double Height { get; set; }

    //    public double Area => Width * Height;

    //    public Rectangle(double width, double height)
    //    {
    //        Width = width;
    //        Height = height;
    //    }

    //    public void DisplayShapeInfo()
    //    {
    //        Console.WriteLine($"Rectangle: Width = {Width}, Height = {Height}, Area = {Area:F2}");
    //    }
    //}
    // #endregion

    // 2
    //#region IAuthenticationService interface
    //public interface IAuthenticationService
    //{
    //    bool AuthenticateUser(string username, string password);
    //    bool AuthorizeUser(string username, string role);
    //}
    //#endregion
    //#region class BasicAuthenticationService
    //public class BasicAuthenticationService : IAuthenticationService
    //{
    //    private readonly Dictionary<string, (string Password, string Role)> _users =
    //        new Dictionary<string, (string Password, string Role)>
    //        {
    //            { "user1", ("password1", "Admin") },
    //            { "user2", ("password2", "User") }
    //        };
    //    #endregion
    // #region AuthenticateUser checks username and password are valid
    //    public bool AuthenticateUser(string username, string password)
    //    {
    //        if (_users.TryGetValue(username, out var userInfo))
    //        {
    //            return userInfo.Password == password;
    //        }
    //        return false;
    //    }
    //    #endregion
    //    #region AuthorizeUser checks if the authenticated user has the specified role
    //    public bool AuthorizeUser(string username, string role)
    //    {
    //        if (_users.TryGetValue(username, out var userInfo))
    //        {
    //            return userInfo.Role == role;
    //        }
    //        return false;
    //    }
    //}
    //#endregion
    // 3
    //#region INotificationService interface
    //public interface INotificationService
    //{
    //    void SendNotification(string recipient, string message);
    //}
    //#endregion
    //#region class EmailNotificationService 
    //public class EmailNotificationService : INotificationService
    //{
    //    public void SendNotification(string recipient, string message)
    //    {
    //        Console.WriteLine($"Sending Email to {recipient}: {message}");
    //    }
    //}
    //#endregion
    //#region class SmsNotificationService
    //public class SmsNotificationService : INotificationService
    //{
    //    public void SendNotification(string recipient, string message)
    //    {
    //        Console.WriteLine($"Sending SMS to {recipient}: {message}");
    //    }
    //}
    //#endregion
    //#region class PushNotificationService
    //public class PushNotificationService : INotificationService
    //{
    //    public void SendNotification(string recipient, string message)
    //    {
    //        Console.WriteLine($"Sending Push Notification to {recipient}: {message}");
    //    }
    //}
    //#endregion
    class Program
    {
        static void Main(string[] args)
        {
            #region 1- Define an interface named IShape with a property Area and a method DisplayShapeInfo. Create two interfaces, ICircle and IRectangle, that inherit from IShape. Implement these interfaces in classes Circle and Rectangle. Test your implementation by creating instances of both classes and displaying their shape information.
            //// circle instance
            //ICircle circle = new Circle(5.0);
            //circle.DisplayShapeInfo();

            //// Rectangle instance
            //IRectangle rectangle = new Rectangle(4.0, 6.0);
            //rectangle.DisplayShapeInfo();
            #endregion

            #region Q2: 1- We start by defining the IAuthenticationService interface with two methods: AuthenticateUser and AuthorizeUser. The BasicAuthenticationService class implements this interface and provides the specific implementation for these methods.
            //IAuthenticationService authService = new BasicAuthenticationService();

            //string username = "user1";
            //string password = "password1";
            //string role = "Admin";

            //// Authenticate the user
            //if (authService.AuthenticateUser(username, password))
            //{
            //    Console.WriteLine($"{username} is authenticated.");

            //    // Authorize the user
            //    if (authService.AuthorizeUser(username, role))
            //    {
            //        Console.WriteLine($"{username} is authorized as {role}.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{username} is not authorized as {role}.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{username} failed authentication.");
            //}
            #endregion

            #region Q3: 1- we define the INotificationService interface with a method SendNotification that takes a recipient and a message as parameters.
            ////instances notification service
            //INotificationService emailService = new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();

            //// Send notifications to service
            //emailService.SendNotification("email@example.com", "This is an email notification.");
            //smsService.SendNotification("+1234567890", "This is an SMS notification.");
            //pushService.SendNotification("user123", "This is a push notification.");
            #endregion

        }
    }
}
