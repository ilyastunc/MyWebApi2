using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApi2.Entitites
{
    public class Station
    {
        public Guid Id { get; set; }
        public string Adi { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public decimal Puan { get; set; }
        public bool Fav { get; set; }
        public bool Kupon { get; set; }
        public int Durum { get; set; }
    }

    public class StationResponse
    {
        public int Code { get; set; }
        public List<Station> Data { get; set; }
    }
}