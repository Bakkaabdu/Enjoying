namespace Enjoying
{
    public class Properties
    {
        /*
         * ──────────────
         * C# Properties 
         * ──────────────
         *
         * Why Use Properties?
         * - To encapsulate internal class fields (data hiding).
         * - To apply logic when getting or setting a value.
         * - To protect data from invalid inputs.
         * - To provide a controlled interface to access internal fields.
         *
         * What is Encapsulation?
         * - The practice of keeping fields private and exposing them through public properties or methods.
         * - Protects the integrity of the object’s data.
         *
         * Basic Property with a Backing Field:
         * - A private field stores the data.
         * - A public property allows controlled access.
         *
         * Example:
         */

        private decimal _amount;

        public decimal Amount
        {
            get => _amount;
            set => _amount = ProcessValue(value); // value is a keyword
        }

        // Constructor with initial value
        public Properties(decimal amount)
        {
            _amount = ProcessValue(amount); // use the same logic for initialization
        }

        // Validation logic for setting value
        private decimal ProcessValue(decimal value)
        {
            return value <= 0 ? 0 : value;
        }

        /*
         * Automatic Properties:
         * - The compiler automatically creates a backing field.
         * - Used when no logic is needed in get/set.
         *
         * Example:
         */

        public string Name { get; set; }

        /*
         * Read-Only Property:
         * - Only has a getter.
         * - Useful for calculated values or constants.
         *
         * Example:
         */

        public string Description => $"Amount: {Amount}, Name: {Name}";

        /*
         * Write-Only Property:
         * - Only has a setter.
         * - Rarely used, but useful in some secure data inputs.
         *
         * Example:
         */

        private string _secret;

        public string Secret
        {
            set => _secret = value;
        }

        /*
         * Accessibility Modifiers:
         * - You can change access levels on getters or setters.
         *
         * Example:
         */

        public int Age { get; private set; }  // Can be read publicly, but set only inside the class

        /*
         * Expression-Bodied Properties:
         * - Short-hand for simple getters or setters.
         *
         * Example:
         */

        public bool IsValid => Amount > 0;

        /*
         * Init-Only Properties (C# 9.0+):
         * - Can be set only during object initialization.
         *
         * Example:
         * public string Email { get; init; }
         *
         * var p = new Properties(10) { Email = "test@example.com" };
         */

        /*
         * Summary:
         * - Use properties to protect fields and add logic when needed.
         * - Prefer automatic properties when no custom logic is required.
         * - Use `init` if values should only be set during initialization.
         */
    }
}
