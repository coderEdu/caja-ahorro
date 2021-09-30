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
        static int c = 0;
        //static int counter = 0;

        public Button CreateNewEnemyWAttribs(string userName)
        {
            return new Button
            {
                BackgroundImageLayout = ImageLayout.Center,
                FlatStyle = FlatStyle.Flat,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Image = CajaDeAhorro.Properties.Resources.User_icon_64,
                //Location = new Point(0, 0),
                Name = "Session" + ++c,
                Size = new Size(141, 90),
                Text = userName,
                TextImageRelation = TextImageRelation.ImageAboveText,
                UseVisualStyleBackColor = true
            };

            //this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            //this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            //this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.button1.Image = global::CajaDeAhorro.Properties.Resources.User_icon_64;
            //this.button1.Location = new System.Drawing.Point(150, 3);
            //this.button1.Name = "button1";
            //this.button1.Size = new System.Drawing.Size(141, 90);
            //this.button1.TabIndex = 25;
            //this.button1.Text = "edu";
            //this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            //this.button1.UseVisualStyleBackColor = true;
        }
    }
}
