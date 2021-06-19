using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HariOmImpex_LMS
{
    class MenuColorTable : ProfessionalColorTable
    {
        public MenuColorTable()
        {
            // see notes
            base.UseSystemColors = false;
        }
        //public override System.Drawing.Color MenuBorder
        //{
        //    get { return Color.Black; }
        //}
        public override System.Drawing.Color MenuItemBorder
        {
            get { return Color.Black; }
        }
        //public override Color MenuItemSelected
        //{
        //    get { return Color.Cornsilk; }
        //}

        //public override Color MenuItemSelectedGradientBegin
        //{
        //    get { return Color.SteelBlue; }
        //}
        //public override Color MenuItemSelectedGradientEnd
        //{
        //    get { return Color.LightSteelBlue; }
        //}
        public override Color MenuStripGradientBegin
        {
            get { return Color.LightGray; }
        }
        public override Color MenuStripGradientEnd
        {
            get { return Color.Gainsboro; }
        }

    }
}
