using System;

namespace Almostengr.ThermometerPi.Worker.DataTransfer
{
    public class HaApiResponse
    {
        public string Entity_Id {get;set;}
        public string State { get; set; }
        public string Last_Updated { get; set; }        
    }
}