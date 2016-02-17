// Task 4 - Change Password
// Input - two passwords
// Output - password changed OR password not changed
// Process
// 1. inform user their password has expired and needs to be changed
// 2. prompt user to enter a new password
// 3. prompt user to confirm their password
// 4. if the two passwords match change the password
// 5. else don't change the password
// 6. Inform the user of their password status with a message

class Password
{
    string password;

    public string updatePassword()
    {
        string pass1, pass2, message;
        System.Console.Write("Enter your new password: ");
        pass1 = System.Console.ReadLine();
        System.Console.Write("Re-enter your password to confirm: ");
        pass2 = System.Console.ReadLine();

        if (pass1 == pass2)
        {
            this.password = pass1;
            message = "Password update successfully.";
        }
        else
        {
            message = "Passwords do not match. Password is unchanged";
        }
        return message;

    }
    
    public static void Main(string [] args)
{
    string message;
    System.Console.WriteLine("Your password has expired and you need to enter a new one");

    Password pass = new Password();
    message = pass.updatePassword();
    System.Console.WriteLine(message);

}
}