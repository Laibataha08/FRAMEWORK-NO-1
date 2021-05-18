using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace WindowsFormsApp4
{
    class GameObject
    {

        PictureBox pictureBox;

        public GameObject(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
        }

        public void updateposition(int speed)
        {
            pictureBox.Left += speed;
            
        }
       

    }
}
