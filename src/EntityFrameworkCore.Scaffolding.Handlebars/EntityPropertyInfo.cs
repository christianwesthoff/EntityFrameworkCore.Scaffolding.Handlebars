namespace EntityFrameworkCore.Scaffolding.Handlebars
{
    /// <summary>
    /// Entity property info.
    /// </summary>
    public class EntityPropertyInfo
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public EntityPropertyInfo() { }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="propertyType">Property type.</param>
        /// <param name="propertyName">Property name.</param>
        public EntityPropertyInfo(string propertyType, string propertyName)
        {
            PropertyType = propertyType;
            PropertyName = propertyName;
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="propertyType">Property type.</param>
        /// <param name="propertyName">Property name.</param>
        /// <param name="declaringType">Declaring type.</param>
        public EntityPropertyInfo(string propertyType, string propertyName, string declaringType)
        {
            PropertyType = propertyType;
            PropertyName = propertyName;
            DeclaringType = declaringType;
        }

        /// <summary>
        /// Property type.
        /// </summary>
        public string PropertyType { get; set; }

        /// <summary>
        /// Property name.
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// Declaring type.
        /// </summary>
        public string DeclaringType { get; set; }
    }
}