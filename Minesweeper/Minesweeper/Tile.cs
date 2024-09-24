using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    internal class Tile
    {
        Button m_b;
        private Boolean m_flag;
        private Boolean m_dug;
        private Boolean m_mine;
        private Image m_FlagImage;
        private Image m_MineImage;
        int m_nearby;
        public Tile(Button b)
        {
            m_b = b;
            m_b.BackColor = Color.Green;
        }
        public void SetNearby(int n) { m_nearby = n; }
        public void SetFlagImage(Image FlagImage) { m_FlagImage = FlagImage; }
        public void SetMineImage(Image MineImage) { m_MineImage = MineImage; }
        public void SetMine(Boolean b)
        {
            m_mine = b;
            //m_b.BackColor = Color.Red;

        }
        public Boolean GetMine() { return m_mine; }
        public void SetDug()
        {
            m_dug = true;
            if (m_mine)
                m_b.BackgroundImage = m_MineImage;

        }
        public void SetFlag()
        {
            m_flag = !m_flag;
            if (m_flag)
            {
                m_b.BackgroundImage = m_FlagImage;
            }
            else
                m_b.BackgroundImage = null;
        }
    }
}
