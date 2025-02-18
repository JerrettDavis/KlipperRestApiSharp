﻿using Newtonsoft.Json;

namespace AndreasReitberger.API.Moonraker.Models
{
    public class KlipperActiveJobStateChangedEventArgs : KlipperEventArgs
    {
        #region Properties
        public string NewJobState { get; set; }
        //public KlipperStatusJob NewJobState { get; set; }
        public string PreviousJobState { get; set; }
        //public KlipperStatusJob PreviousJobState { get; set; }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
        #endregion
    }
}
