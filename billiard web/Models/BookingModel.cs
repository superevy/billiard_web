using System;

namespace billiard_web.Models
{
    public class BookingModel
    {
        public string Meja { get; set; }
        public TimeSpan Jam { get; set; }
        public int LamaSewa { get; set; }
        public int HargaPerJam => 30000;

        public int TotalHarga => HargaPerJam * LamaSewa;
    }
}
