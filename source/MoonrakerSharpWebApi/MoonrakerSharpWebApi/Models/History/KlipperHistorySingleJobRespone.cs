﻿using Newtonsoft.Json;

namespace AndreasReitberger.API.Moonraker.Models
{
    public partial class KlipperHistorySingleJobRespone
    {
        #region Properties
        [JsonProperty("result")]
        public KlipperHistorySingleJobResult Result { get; set; }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
        #endregion
    }
}
