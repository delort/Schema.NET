namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A middle school (typically for children aged around 11-14, although this varies somewhat).
    /// </summary>
    [DataContract]
    public class MiddleSchool : EducationalOrganization
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MiddleSchool";
    }
}