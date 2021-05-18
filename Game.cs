using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
using System.IO;

namespace WindowsFormsApp4
{
    class Game
    {
        public int speed;
        public static ArrayList allObjects = new ArrayList();

        public Game(int speed)
        {
            this.speed = speed;
        }

        public void AddObjects(GameObject G)
        {
            allObjects.Add(G);
        }

        public void update()
        {
            for (int idx = 0 ; idx < allObjects.Count; idx++)
            {
                GameObject g = (GameObject)allObjects[idx];
                g.updateposition(speed);
            }
            
        }
    }
}
