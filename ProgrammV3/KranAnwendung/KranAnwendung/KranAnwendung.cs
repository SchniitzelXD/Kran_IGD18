using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KranAnwendung
{
    public partial class frm_Kran : Form
    {
        bool oben = false;
        bool unten = false;
        bool links = false;
        bool rechts = false;
        bool griff = false;

        // Formulareigenschaften
        int borderTop = 268;
        int borderBottom = 561;
        int borderLeft = 289;
        int borderRight = 578;
        int borderBottomLast = 490;

        public frm_Kran()
        {
            InitializeComponent();
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timKran_Tick(object sender, EventArgs e)
        {
            if (oben == true)
            {
                if (pBoxHaken.Location.Y >= this.borderTop)
                { if (griff == true)
                    {
                        pBoxKranHaken.Size = new Size(pBoxKranHaken.Size.Width, pBoxKranHaken.Size.Height - 3);
                        pBoxHaken.Location = new Point(pBoxHaken.Location.X, pBoxHaken.Location.Y - 3);
                        pBoxKiste.Location = new Point(pBoxKiste.Location.X, pBoxKiste.Location.Y - 3);
                    }
                    else
                    {
                        pBoxKranHaken.Size = new Size(pBoxKranHaken.Size.Width, pBoxKranHaken.Size.Height - 3);
                        pBoxHaken.Location = new Point(pBoxHaken.Location.X, pBoxHaken.Location.Y - 3);
                    }
                }
            }
            else if (unten == true)
            {
                if (griff == true)
                {
                    if (pBoxKiste.Location.Y <= this.borderBottomLast)
                    {
                        if (griff == true)
                        {
                            pBoxKranHaken.Size = new Size(pBoxKranHaken.Size.Width, pBoxKranHaken.Size.Height + 3);
                            pBoxHaken.Location = new Point(pBoxHaken.Location.X, pBoxHaken.Location.Y + 3);
                            pBoxKiste.Location = new Point(pBoxKiste.Location.X, pBoxKiste.Location.Y + 3);
                        }
                        else
                        {
                            pBoxKranHaken.Size = new Size(pBoxKranHaken.Size.Width, pBoxKranHaken.Size.Height + 3);
                            pBoxHaken.Location = new Point(pBoxHaken.Location.X, pBoxHaken.Location.Y + 3);
                        }
                    }
                }
                else
                {
                    if (pBoxHaken.Location.Y + pBoxHaken.Size.Height <= this.borderBottom)
                    {
                        if (griff == true)
                        {
                            pBoxKranHaken.Size = new Size(pBoxKranHaken.Size.Width, pBoxKranHaken.Size.Height + 3);
                            pBoxHaken.Location = new Point(pBoxHaken.Location.X, pBoxHaken.Location.Y + 3);
                            pBoxKiste.Location = new Point(pBoxKiste.Location.X, pBoxKiste.Location.Y + 3);
                        }
                        else
                        {
                            pBoxKranHaken.Size = new Size(pBoxKranHaken.Size.Width, pBoxKranHaken.Size.Height + 3);
                            pBoxHaken.Location = new Point(pBoxHaken.Location.X, pBoxHaken.Location.Y + 3);
                        }
                    }
                }
            }
            else if (links == true)
            { if (pBoxKranHaken.Location.X >= this.borderLeft)
                {
                    if (griff == true)
                    {
                        pBoxKranHaken.Location = new Point(pBoxKranHaken.Location.X - 3, pBoxKranHaken.Location.Y);
                        pBoxHaken.Location = new Point(pBoxHaken.Location.X - 3, pBoxHaken.Location.Y);
                        pBoxKiste.Location = new Point(pBoxKiste.Location.X - 3, pBoxKiste.Location.Y);
                    }
                    else
                    {
                        pBoxKranHaken.Location = new Point(pBoxKranHaken.Location.X - 3, pBoxKranHaken.Location.Y);
                        pBoxHaken.Location = new Point(pBoxHaken.Location.X - 3, pBoxHaken.Location.Y);
                    }
                }
            }
            else if (rechts == true)
            { if (pBoxKranHaken.Location.X + pBoxKranHaken.Size.Width <= this.borderRight)
                {
                    if (griff == true)
                    {
                        pBoxKranHaken.Location = new Point(pBoxKranHaken.Location.X + 3, pBoxKranHaken.Location.Y);
                        pBoxHaken.Location = new Point(pBoxHaken.Location.X + 3, pBoxHaken.Location.Y);
                        pBoxKiste.Location = new Point(pBoxKiste.Location.X + 3, pBoxKiste.Location.Y);
                    } else {
                        pBoxKranHaken.Location = new Point(pBoxKranHaken.Location.X + 3, pBoxKranHaken.Location.Y);
                        pBoxHaken.Location = new Point(pBoxHaken.Location.X + 3, pBoxHaken.Location.Y);
                    }
                }
            }
        }

        private void btnHoch_MouseDown(object sender, MouseEventArgs e)
        {
            oben = true;
            timKran.Enabled = true;
        }

        private void btnHoch_MouseUp(object sender, MouseEventArgs e)
        {
            oben = false;
            timKran.Enabled = false;
        }

        private void btnRunter_MouseDown(object sender, MouseEventArgs e)
        {
            unten = true;
            timKran.Enabled = true;
        }

        private void btnRunter_MouseUp(object sender, MouseEventArgs e)
        {
            unten = false;
            timKran.Enabled = false;
        }

        private void btnLinks_MouseDown(object sender, MouseEventArgs e)
        {
            links = true;
            timKran.Enabled = true;
        }

        private void btnLinks_MouseUp(object sender, MouseEventArgs e)
        {
            links = false;
            timKran.Enabled = false;
        }

        private void btnRechts_MouseDown(object sender, MouseEventArgs e)
        {
            rechts = true;
            timKran.Enabled = true;
        }

        private void btnRechts_MouseUp(object sender, MouseEventArgs e)
        {
            rechts = false;
            timKran.Enabled = false;
        }

        private void btn_greifen_Click(object sender, EventArgs e)
        {
            if (griff == true)
            {
                if (pBoxKiste.Location.Y >= 490)
                {
                griff = false;
                }
            }
            else
            {
                if (pBoxKiste.Location.X + 48 <= pBoxHaken.Location.X + 23)
                {
                } if (pBoxHaken.Location.X + 23 >= pBoxKiste.Location.X + 59)
                {
                } if (pBoxHaken.Location.Y + 79 >= pBoxKiste.Location.Y)
                {
                    griff = true;
                }
            }
        }

        private void btnAllesAufAnfang_Click(object sender, EventArgs e)
        {
            pBoxKranHaken.Size = new Size(85, 203);
            pBoxKranHaken.Location = new Point(439, 178);
            pBoxHaken.Location = new Point(445, 370);
            pBoxKiste.Location = new Point(329, 490);
            griff = false;
        }

        private void btnHilfe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Du benötigst Hilfe? Dann schau dir doch nochmal die Bedienungsanleitung an!",
                            "Hilfeanzeige",
                            MessageBoxButtons.OK);
        }

    }
}
