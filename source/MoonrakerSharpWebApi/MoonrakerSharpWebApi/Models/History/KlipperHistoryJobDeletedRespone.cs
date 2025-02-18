﻿using Newtonsoft.Json;

namespace AndreasReitberger.API.Moonraker.Models
{
    public partial class KlipperHistoryJobDeletedRespone
    {
        #region Properties
        [JsonProperty("result")]
        public KlipperHistoryJobDeletedResult Result { get; set; }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
        #endregion
    }
}
