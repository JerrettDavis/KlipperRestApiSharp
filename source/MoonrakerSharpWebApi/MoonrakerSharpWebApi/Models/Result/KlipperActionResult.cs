﻿using Newtonsoft.Json;

namespace AndreasReitberger.API.Moonraker.Models
{
    public partial class KlipperActionResult
    {
        #region Properties
        [JsonProperty("result")]
        public string Result { get; set; }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
        #endregion
    }
}
