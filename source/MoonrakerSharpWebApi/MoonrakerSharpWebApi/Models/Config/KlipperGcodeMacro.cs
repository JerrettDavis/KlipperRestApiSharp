﻿using Newtonsoft.Json;

namespace AndreasReitberger.API.Moonraker.Models
{
    public partial class KlipperGcodeMacro
    {
        #region Properties
        [JsonIgnore]
        public string Name { get; set; }

        [JsonProperty("rename_existing")]
        public string RenameExisting { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("gcode")]
        public string Gcode { get; set; }

        [JsonProperty("variable_extrude", NullValueHandling = NullValueHandling.Ignore)]
        public string VariableExtrude { get; set; }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
        #endregion
    }
}
