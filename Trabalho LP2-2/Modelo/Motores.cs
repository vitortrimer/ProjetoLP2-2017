using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_LP2_2
{
    public class Motores
    {
        int id;
        private bool m10 = false, m13 = false, m16 = false, m10t = false, m20 = false, m20t = false;
        private double p10, p13, p16, p10t, p20, p20t;


        public Motores()
        {

        }

        public Motores(int id, bool m10, bool m13, bool m16, bool m10t, bool m20, bool m20t, double p10, double p13, double p16, double p10t, double p20, double p20t)
        {
            this.Id = id;
            this.M10 = m10;
            this.M13 = m13;
            this.M16 = m16;
            this.M10t = m10t;
            this.M20 = m20;
            this.M20t = m20t;
            this.P10 = p10;
            this.P13 = p13;
            this.P16 = p16;
            this.P10t = p10t;
            this.P20 = p20;
            this.P20t = p20t;
        }

        public bool M10
        {
            get
            {
                return m10;
            }

            set
            {
                m10 = value;
            }
        }

        public bool M10t
        {
            get
            {
                return m10t;
            }

            set
            {
                m10t = value;
            }
        }

        public bool M13
        {
            get
            {
                return m13;
            }

            set
            {
                m13 = value;
            }
        }
        
        public bool M16
        {
            get
            {
                return m16;
            }

            set
            {
                m16 = value;
            }
        }

        public bool M20
        {
            get
            {
                return m20;
            }

            set
            {
                m20 = value;
            }
        }

        public bool M20t
        {
            get
            {
                return m20t;
            }

            set
            {
                m20t = value;
            }
        }

        public double P10
        {
            get
            {
                return p10;
            }

            set
            {
                p10 = value;
            }
        }

        public double P13
        {
            get
            {
                return p13;
            }

            set
            {
                p13 = value;
            }
        }

        public double P16
        {
            get
            {
                return p16;
            }

            set
            {
                p16 = value;
            }
        }

        public double P10t
        {
            get
            {
                return p10t;
            }

            set
            {
                p10t = value;
            }
        }

        public double P20
        {
            get
            {
                return p20;
            }

            set
            {
                p20 = value;
            }
        }

        public double P20t
        {
            get
            {
                return p20t;
            }

            set
            {
                p20t = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }
}
