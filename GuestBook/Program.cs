using GuestLibrary.Models;

public class GuestBook
{
    public static List<Guest> guests = new List<Guest>();

    public static void Main(string[] args)
    {
        GetGuestInfo();
        Console.Clear();
        DisplayUserInfo();
        Console.ReadLine(); 
    }

    private static void DisplayUserInfo()
    {

        foreach (Guest guest in guests)
        {
            Console.WriteLine(guest.UserInfo);
        }
    }
    private static void GetGuestInfo()
    {
        string moreGuestToAdd = "";
        do
        {
            Guest guest = new Guest();
            guest.FirstName = GetUserResponse("Enter your FirstName: ");
            guest.LastName = GetUserResponse("Enter your LastName: ");
            guest.MessageToHost = GetUserResponse("Enter the message to host: ");
            guests.Add(guest);
            moreGuestToAdd = GetUserResponse("Do you have more guest to add: ");
        } while (moreGuestToAdd.ToLower() == "yes");
    }

    private static string GetUserResponse(string question)
    {
        Console.Write(question);
        string output = Console.ReadLine();
        return output;
    }

}