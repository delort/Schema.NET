namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A music venue.
    /// </summary>
    [DataContract]
    public class MusicVenue : CivicStructure
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MusicVenue";
    }
}