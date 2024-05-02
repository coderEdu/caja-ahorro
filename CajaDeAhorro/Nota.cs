using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;

namespace CajaDeAhorro
{
    internal class Nota     // creates note buttos
    {
        static int c = 0;   // increase by 1 note-name
        public Button CreateNewNoteWithAttrib(string note_title)
        {
            return new Button
            {
                FlatStyle = FlatStyle.Flat,
                Image = global::CajaDeAhorro.Properties.Resources._17367_file_icon,
                Name = "Note" + ++c,
                Size = new Size(82, 96),
                Text = note_title,
                TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText,
                UseVisualStyleBackColor = true
            };
        }
    }
}
