namespace Proxy.Models;

/// <summary>
///     Represents a user.
/// </summary>
public class User {
    /// <summary>
    ///     Initializes a new <c>User</c> with the specified name, and age.
    /// </summary>
    /// <param name="name">
    ///     The name of the <c>User</c>.
    /// </param>
    /// <param name="age">
    ///     The age of the <c>User</c>.
    /// </param>
    public User(string name, byte age){
        Name = name;
        Age = age;
    }

    /// <summary>
    ///     The name of the user.
    /// </summary>
    /// <remarks>
    ///     Gets or sets the name of the current <c>User</c> instance.
    /// </remarks>
    public string Name { get; set; }

    private byte _Age;

    /// <summary>
    ///     The age of the user.
    /// </summary>
    /// <remarks>
    ///     Gets or sets the age of the current <c>User</c> instance.
    /// </remarks>
    /// <exception cref="System.ArgumentOutOfRangeException">
    ///     Thrown when the age is out of range.
    /// </exception>
    public byte Age {
        get {
            return _Age;
        }
        set {
            if(value >= 0 && value <= 120){
                _Age = value;
            }
            else{
                throw new ArgumentOutOfRangeException("The age must be between 0 and 120.");
            }
        }
    }

    public override string ToString()
    {
        return this.Name + ", " + this.Age + ".";
    }
}