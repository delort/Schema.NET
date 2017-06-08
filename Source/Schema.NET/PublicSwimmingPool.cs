namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A public swimming pool.
    /// </summary>
    [DataContract]
    public class PublicSwimmingPool : SportsActivityLocation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "PublicSwimmingPool";
    }
}