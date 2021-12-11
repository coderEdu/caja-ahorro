using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;

namespace CajaDeAhorro
{
    internal class Nota
    {
        static int c = 0;   // increse in 1 note-name
        public Button CreateNewNoteWithAttrib(string note_title)
        {
            return new Button
            {
                //BackgroundImageLayout = ImageLayout.Center,
                //FlatStyle = FlatStyle.Flat,
                //Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                //Image = CajaDeAhorro.Properties.Resources.padlock_unlock_icon_48,
                //Name = "Session" + ++c,
                //Size = new Size(141, 90),
                //Text = userName,
                //TextImageRelation = TextImageRelation.ImageAboveText,
                //UseVisualStyleBackColor = true

                //this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
                FlatStyle = FlatStyle.Flat,
                Image = global::CajaDeAhorro.Properties.Resources._2620509_employee_job_note_seeker_unemployee_icon,
                Name = "Note" + ++c,
                Size = new Size(82, 96),
                Text = note_title,
                TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText,
                UseVisualStyleBackColor = true
            };
        }
    }
}
