// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20191.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for LicenseStatsModelRobotType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LicenseStatsModelRobotType
    {
        [EnumMember(Value = "NonProduction")]
        NonProduction,
        [EnumMember(Value = "Attended")]
        Attended,
        [EnumMember(Value = "Unattended")]
        Unattended,
        [EnumMember(Value = "Development")]
        Development
    }
    internal static class LicenseStatsModelRobotTypeEnumExtension
    {
        internal static string ToSerializedValue(this LicenseStatsModelRobotType? value)
        {
            return value == null ? null : ((LicenseStatsModelRobotType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this LicenseStatsModelRobotType value)
        {
            switch( value )
            {
                case LicenseStatsModelRobotType.NonProduction:
                    return "NonProduction";
                case LicenseStatsModelRobotType.Attended:
                    return "Attended";
                case LicenseStatsModelRobotType.Unattended:
                    return "Unattended";
                case LicenseStatsModelRobotType.Development:
                    return "Development";
            }
            return null;
        }

        internal static LicenseStatsModelRobotType? ParseLicenseStatsModelRobotType(this string value)
        {
            switch( value )
            {
                case "NonProduction":
                    return LicenseStatsModelRobotType.NonProduction;
                case "Attended":
                    return LicenseStatsModelRobotType.Attended;
                case "Unattended":
                    return LicenseStatsModelRobotType.Unattended;
                case "Development":
                    return LicenseStatsModelRobotType.Development;
            }
            return null;
        }
    }
}