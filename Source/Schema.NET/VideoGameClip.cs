namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A short segment/part of a video game.
    /// </summary>
    [DataContract]
    public class VideoGameClip : Clip
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "VideoGameClip";
    }
}