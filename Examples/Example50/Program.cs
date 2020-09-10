using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example50
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    struct Edge
    {
        Length _l;
        public Coordinate a, b;
        public int length {
            get
            {
                return _l.length;
            }
        }

        struct Length
        {
            public int length;
        }

        public Edge(int aX, int aY, int bX, int bY)
        {
            this.a.x = aX;
            this.a.y = aY;
            this.b.x = bX;
            this.b.y = bY;
            this._l.length = a.distanceBetween(b);
        }

        public void update()
        {
            this._l.length = a.distanceBetween(b);
        }

    }

    struct Coordinate
    {
        public int x;
        public int y;

        public int distanceBetween(Coordinate point)
        {
            return (int)Math.Sqrt(Math.Pow((point.x - this.x), 2) + Math.Pow((point.y - this.y), 2));
        }

    }

  
}
