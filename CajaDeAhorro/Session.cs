using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;

namespace CajaDeAhorro
{
    class Session
    {
        static int c = 0; // increase name in one
        //static int counter = 0;

        public Button CreateNewEnemyWAttribs(string userName)
        {
            return new Button
            {
                BackgroundImageLayout = ImageLayout.Center,
                FlatStyle = FlatStyle.Flat,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Image = CajaDeAhorro.Properties.Resources.padlock_unlock_icon_48,
                Name = "Session" + ++c,
                Size = new Size(141, 90),
                Text = userName,
                TextImageRelation = TextImageRelation.ImageAboveText,
                UseVisualStyleBackColor = true
            };
        }

    }
}
