using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtual_GPIO
{
    public partial class Form1
    {
        private byte btnState = 0x00;

        #region lPad_Down
        private void btnUpL_MouseDown(object sender, MouseEventArgs e)
        {
            btnState |= 0x80;
            btnUpL.Image = Properties.Resources.btn_on;

            sendData();
        }
        private void btnDownL_MouseDown(object sender, MouseEventArgs e)
        {
            btnState |= 0x40;
            btnDownL.Image = Properties.Resources.btn_on;

            sendData();
        }
        private void btnLeftL_MouseDown(object sender, MouseEventArgs e)
        {
            btnState |= 0x20;
            btnLeftL.Image = Properties.Resources.btn_on;

            sendData();
        }
        private void btnRightL_MouseDown(object sender, MouseEventArgs e)
        {
            btnState |= 0x10;
            btnRightL.Image = Properties.Resources.btn_on;

            sendData();
        }
        #endregion

        #region lPad_Up
        private void btnUpL_MouseUp(object sender, MouseEventArgs e)
        {
            btnState &= unchecked((byte)~0x80);
            btnUpL.Image = Properties.Resources.btn_off;

            sendData();
        }
        private void btnDownL_MouseUp(object sender, MouseEventArgs e)
        {
            btnState &= unchecked((byte)~0x40);
            btnDownL.Image = Properties.Resources.btn_off;

            sendData();
        }
        private void btnLeftL_MouseUp(object sender, MouseEventArgs e)
        {
            btnState &= unchecked((byte)~0x20);
            btnLeftL.Image = Properties.Resources.btn_off;

            sendData();
        }
        private void btnRightL_MouseUp(object sender, MouseEventArgs e)
        {
            btnState &= unchecked((byte)~0x10);
            btnRightL.Image = Properties.Resources.btn_off;

            sendData();
        }
        #endregion

        #region rPad_Down
        private void btnUpR_MouseDown(object sender, MouseEventArgs e)
        {
            btnState |= 0x08;
            btnUpR.Image = Properties.Resources.btn_on;

            sendData();
        }
        private void btnDownR_MouseDown(object sender, MouseEventArgs e)
        {
            btnState |= 0x04;
            btnDownR.Image = Properties.Resources.btn_on;

            sendData();
        }
        private void btnLeftR_MouseDown(object sender, MouseEventArgs e)
        {
            btnState |= 0x02;
            btnLeftR.Image = Properties.Resources.btn_on;

            sendData();
        }
        private void btnRightR_MouseDown(object sender, MouseEventArgs e)
        {
            btnState |= 0x01;
            btnRightR.Image = Properties.Resources.btn_on;

            sendData();
        }
        #endregion

        #region rPad_Up
        private void btnUpR_MouseUp(object sender, MouseEventArgs e)
        {
            btnState &= unchecked((byte)~0x08);
            btnUpR.Image = Properties.Resources.btn_off;

            sendData();
        }
        private void btnDownR_MouseUp(object sender, MouseEventArgs e)
        {
            btnState &= unchecked((byte)~0x04);
            btnDownR.Image = Properties.Resources.btn_off;

            sendData();
        }
        private void btnLeftR_MouseUp(object sender, MouseEventArgs e)
        {
            btnState &= unchecked((byte)~0x02);
            btnLeftR.Image = Properties.Resources.btn_off;

            sendData();
        }
        private void btnRightR_MouseUp(object sender, MouseEventArgs e)
        {
            btnState &= unchecked((byte)~0x01);
            btnRightR.Image = Properties.Resources.btn_off;

            sendData();
        }
        #endregion
    }
}
