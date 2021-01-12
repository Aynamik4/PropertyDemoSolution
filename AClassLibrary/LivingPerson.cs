// Document your code with XML comments:
//      https://docs.microsoft.com/en-us/dotnet/csharp/codedoc

/* 
 * If you are developing an application using Visual Studio, right-click on
 * the project and select Properties. In the properties dialog, select the
 * Build tab, and check XML documentation file. You can also change the
 * location to which the compiler writes the file.
 * 
 * When distributing the .dll file, the .xml file should be placed in the
 * same folder.
 */

namespace AClassLibrary
{
    public class LivingPerson
    {
        private int age;

        /// <summary>
        /// Returns a new instance of the class LivingPerson<br/>and initializes its Age property to 0.
        /// </summary>
        public LivingPerson()
        {
            Age = 0;
        }

        /// <summary>
        /// Returns a new instance of the class LivingPerson.<br/>AgeException thrown if Age is set to a value below 0 or a value above 120.
        /// </summary>
        /// <param name="age">Initial age of the LivingPerson instance</param>
        /// <exception cref="AgeException"></exception>
        public LivingPerson(int age)
        {
            Age = age;
        }

        /// <summary>
        /// Gets or sets the age of the LivingPerson instance.<br/>AgeException thrown if Age is set to a value below 0 or a value above 120.
        /// </summary>
        /// <exception cref="AgeException"></exception>
        public int Age
        {
            get => age;
            set
            {
                if (value < 0 || value > 120)
                    //throw new Exception("ERROR: Age must be between 0 and 120.");
                    throw new AgeException("ERROR: Age cannot be below 0 or exceed 120.");

                age = value;
            }
        }
    }
}