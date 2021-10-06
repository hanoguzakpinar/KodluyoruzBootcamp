using System;

namespace interyuz
{
    public class Fxx : ICars
    {
        public Marka MarkasiNe()
        {
            return Marka.Ferrari;
        }

        public Renk RengiNe()
        {
            return Renk.Siyah;
        }

        public int TekerSayisi()
        {
            return 4;
        }
    }
}