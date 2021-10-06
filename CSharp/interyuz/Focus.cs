using System;

namespace interyuz
{

    public class Focus : ICars
    {
        public Marka MarkasiNe()
        {
            return Marka.Ford;
        }

        public Renk RengiNe()
        {
            return Renk.Beyaz;
        }

        public int TekerSayisi()
        {
            return 4;
        }
    }
}