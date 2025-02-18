﻿using Newtonsoft.Json;

namespace AndreasReitberger.API.Moonraker.Models
{
    public partial class KlipperDirectoryInfoRespone
    {
        #region Properties
        [JsonProperty("result")]
        public KlipperDirectoryInfoResult Result { get; set; }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
        #endregion
    }
}
