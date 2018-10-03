using Microsoft.Azure.Mobile.Server;

namespace IonHeartHealthService.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }

        public string Heartrate { get; set; }
        //public string HeartrateComment { get; set; }
        //public string Weight { get; set; }
        //public string WeightComment { get; set; }
        //public string Height { get; set; }
        //public string HeightComment { get; set; }
        //public string WellBeing { get; set; }
        //public string WellBeingComment { get; set; }
        //public string Notes { get; set; }
        //public string BreathFrequency { get; set; }
        //public string BreathFrequencyComment { get; set; }
        //public string EKG { get; set; }
        //public string FluidBody { get; set; }
        //public string FluidLungs { get; set; }
        //public string BloodPressure { get; set; }
        //public string BloodOxygen { get; set; }
    }
}