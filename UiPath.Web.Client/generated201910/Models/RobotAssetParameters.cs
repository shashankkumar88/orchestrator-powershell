// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class RobotAssetParameters
    {
        /// <summary>
        /// Initializes a new instance of the RobotAssetParameters class.
        /// </summary>
        public RobotAssetParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RobotAssetParameters class.
        /// </summary>
        public RobotAssetParameters(string robotKey = default(string), string assetName = default(string))
        {
            RobotKey = robotKey;
            AssetName = assetName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "robotKey")]
        public string RobotKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "assetName")]
        public string AssetName { get; set; }

    }
}