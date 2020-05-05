using System.Runtime.Serialization;

namespace DotnetForum.Payloads
{
    [DataContract]
    public enum WeatherSummary
    {
        [EnumMember]
        Freezing,

        [EnumMember]
        Bracing,

        [EnumMember]
        Chilly,

        [EnumMember]
        Cool,

        [EnumMember]
        Mild,

        [EnumMember]
        Warm,

        [EnumMember]
        Balmy,

        [EnumMember]
        Hot,

        [EnumMember]
        Sweltering,

        [EnumMember]
        Scorching
    }
}
