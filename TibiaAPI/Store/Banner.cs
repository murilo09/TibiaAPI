﻿namespace OXGaming.TibiaAPI.Store
{
    public class Banner
    {
        public string Category { get; set; }
        public string Collection { get; set; }
        public string Image { get; set; }

        public uint OfferId { get; set; }

        public ushort Unknown { get; set; }

        public byte Type { get; set; }
    }
}
