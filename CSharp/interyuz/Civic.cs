using System;

namespace interyuz
{
    public class Civic : ICars
    {
        public Marka MarkasiNe()
        {
            return Marka.Honda;
        }

        public Renk RengiNe()
        {
            return Renk.Gri;
        }

        public int TekerSayisi()
        {
            return 4;
        }
    }

}