using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13253013_HW03
{

    class Ogrenci
    {
        public string isim;
        public int numara;
        public string bölüm;
        public string ders1;
        public string ders2;
        public string ders3;
        public int not1;
        public int not2;
        public int not3;

        public int Not1
        {
            get
            {
                return not1;

            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                if (value > 100)
                {
                    value = 100;

                }

                not1 = value;

            }


        }
        public int Not2
        {
            get
            {
                return not2;

            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                if (value > 100)
                {
                    value = 100;
                }

                not2 = value;

            }

        }
        public int Not3
        {
            get
            {
                return not3;

            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                if (value > 100)
                {
                    value = 100;
                }

                not3 = value;

            }

        }
        public int Numara
        {
            get
            {
                return numara;

            }
            set
            {
                numara = value;
            }


        }   ///properteyyy
        public Ogrenci(string isim, int numara, string bölüm, string d1, int no1, string d2, int not2, string d3, int not3)  ////constructor
        {
            this.isim = isim;
            Numara = numara;
            this.bölüm = bölüm;
            ders1 = d1;
            Not1 = no1;
            ders2 = d2;
            Not2 = not2;
            ders3 = d3;
            Not3 = not3;

        }
        public override string ToString()
        {
            return this.isim + this.numara + this.bölüm + this.ders1 + this.not1 + this.ders2 + this.not2 + this.ders3 + this.not3;
        }
    }
}
