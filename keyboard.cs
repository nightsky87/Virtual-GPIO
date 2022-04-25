using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtual_GPIO
{
    partial class Form1
    {
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            byte prevBtnState = btnState;

            if (e.KeyCode == Keys.W)
            {
                btnState |= 0x80;
                btnUpL.Image = Properties.Resources.btn_on;
            }
            else if (e.KeyCode == Keys.S)
            {
                btnState |= 0x40;
                btnDownL.Image = Properties.Resources.btn_on;
            }
            else if (e.KeyCode == Keys.A)
            {
                btnState |= 0x20;
                btnLeftL.Image = Properties.Resources.btn_on;
            }
            else if (e.KeyCode == Keys.D)
            {
                btnState |= 0x10;
                btnRightL.Image = Properties.Resources.btn_on;
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.NumPad8)
            {
                btnState |= 0x08;
                btnUpR.Image = Properties.Resources.btn_on;
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.NumPad5)
            {
                btnState |= 0x04;
                btnDownR.Image = Properties.Resources.btn_on;
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.NumPad4)
            {
                btnState |= 0x02;
                btnLeftR.Image = Properties.Resources.btn_on;
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.NumPad6)
            {
                btnState |= 0x01;
                btnRightR.Image = Properties.Resources.btn_on;
            }

            if (prevBtnState != btnState)
                sendData();
            e.Handled = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            byte prevBtnState = btnState;

            if (e.KeyCode == Keys.W)
            {
                btnState &= unchecked((byte)~0x80);
                btnUpL.Image = Properties.Resources.btn_off;
            }
            else if (e.KeyCode == Keys.S)
            {
                btnState &= unchecked((byte)~0x40);
                btnDownL.Image = Properties.Resources.btn_off;
            }
            else if (e.KeyCode == Keys.A)
            {
                btnState &= unchecked((byte)~0x20);
                btnLeftL.Image = Properties.Resources.btn_off;
            }
            else if (e.KeyCode == Keys.D)
            {
                btnState &= unchecked((byte)~0x10);
                btnRightL.Image = Properties.Resources.btn_off;
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.NumPad8)
            {
                btnState &= unchecked((byte)~0x08);
                btnUpR.Image = Properties.Resources.btn_off;
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.NumPad5)
            {
                btnState &= unchecked((byte)~0x04);
                btnDownR.Image = Properties.Resources.btn_off;
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.NumPad4)
            {
                btnState &= unchecked((byte)~0x02);
                btnLeftR.Image = Properties.Resources.btn_off;
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.NumPad6)
            {
                btnState &= unchecked((byte)~0x01);
                btnRightR.Image = Properties.Resources.btn_off;
            }

            if (prevBtnState != btnState)
                sendData();

            e.Handled = true;
        }
    }
}
