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
        private async void btnUpL_MouseDown(object sender, MouseEventArgs e)
        {
            btnState |= 0x80;
            btnUpL.Image = Properties.Resources.btn_on;

            await sendData();
        }
        private async void btnDownL_MouseDown(object sender, MouseEventArgs e)
        {
            btnState |= 0x40;
            btnDownL.Image = Properties.Resources.btn_on;

            await sendData();
        }
        private async void btnLeftL_MouseDown(object sender, MouseEventArgs e)
        {
            btnState |= 0x20;
            btnLeftL.Image = Properties.Resources.btn_on;

            await sendData();
        }
        private async void btnRightL_MouseDown(object sender, MouseEventArgs e)
        {
            btnState |= 0x10;
            btnRightL.Image = Properties.Resources.btn_on;

            await sendData();
        }
        #endregion

        #region lPad_Up
        private async void btnUpL_MouseUp(object sender, MouseEventArgs e)
        {
            btnState &= unchecked((byte)~0x80);
            btnUpL.Image = Properties.Resources.btn_off;

            await sendData();
        }
        private async void btnDownL_MouseUp(object sender, MouseEventArgs e)
        {
            btnState &= unchecked((byte)~0x40);
            btnDownL.Image = Properties.Resources.btn_off;

            await sendData();
        }
        private async void btnLeftL_MouseUp(object sender, MouseEventArgs e)
        {
            btnState &= unchecked((byte)~0x20);
            btnLeftL.Image = Properties.Resources.btn_off;

            await sendData();
        }
        private async void btnRightL_MouseUp(object sender, MouseEventArgs e)
        {
            btnState &= unchecked((byte)~0x10);
            btnRightL.Image = Properties.Resources.btn_off;

            await sendData();
        }
        #endregion

        #region rPad_Down
        private async void btnUpR_MouseDown(object sender, MouseEventArgs e)
        {
            btnState |= 0x08;
            btnUpR.Image = Properties.Resources.btn_on;

            await sendData();
        }
        private async void btnDownR_MouseDown(object sender, MouseEventArgs e)
        {
            btnState |= 0x04;
            btnDownR.Image = Properties.Resources.btn_on;

            await sendData();
        }
        private async void btnLeftR_MouseDown(object sender, MouseEventArgs e)
        {
            btnState |= 0x02;
            btnLeftR.Image = Properties.Resources.btn_on;

            await sendData();
        }
        private async void btnRightR_MouseDown(object sender, MouseEventArgs e)
        {
            btnState |= 0x01;
            btnRightR.Image = Properties.Resources.btn_on;

            await sendData();
        }
        #endregion

        #region rPad_Up
        private async void btnUpR_MouseUp(object sender, MouseEventArgs e)
        {
            btnState &= unchecked((byte)~0x08);
            btnUpR.Image = Properties.Resources.btn_off;

            await sendData();
        }
        private async void btnDownR_MouseUp(object sender, MouseEventArgs e)
        {
            btnState &= unchecked((byte)~0x04);
            btnDownR.Image = Properties.Resources.btn_off;

            await sendData();
        }
        private async void btnLeftR_MouseUp(object sender, MouseEventArgs e)
        {
            btnState &= unchecked((byte)~0x02);
            btnLeftR.Image = Properties.Resources.btn_off;

            await sendData();
        }
        private async void btnRightR_MouseUp(object sender, MouseEventArgs e)
        {
            btnState &= unchecked((byte)~0x01);
            btnRightR.Image = Properties.Resources.btn_off;

            await sendData();
        }
        #endregion


        private void updateButtonImages()
        {
            if ((btnState & 0x80) == 0)
                btnUpL.Image = Properties.Resources.btn_off;
            else
                btnUpL.Image = Properties.Resources.btn_on;

            if ((btnState & 0x40) == 0)
                btnDownL.Image = Properties.Resources.btn_off;
            else
                btnDownL.Image = Properties.Resources.btn_on;

            if ((btnState & 0x20) == 0)
                btnLeftL.Image = Properties.Resources.btn_off;
            else
                btnLeftL.Image = Properties.Resources.btn_on;

            if ((btnState & 0x10) == 0)
                btnRightL.Image = Properties.Resources.btn_off;
            else
                btnRightL.Image = Properties.Resources.btn_on;

            if ((btnState & 0x08) == 0)
                btnUpR.Image = Properties.Resources.btn_off;
            else
                btnUpR.Image = Properties.Resources.btn_on;

            if ((btnState & 0x04) == 0)
                btnDownR.Image = Properties.Resources.btn_off;
            else
                btnDownR.Image = Properties.Resources.btn_on;

            if ((btnState & 0x02) == 0)
                btnLeftR.Image = Properties.Resources.btn_off;
            else
                btnLeftR.Image = Properties.Resources.btn_on;

            if ((btnState & 0x01) == 0)
                btnRightR.Image = Properties.Resources.btn_off;
            else
                btnRightR.Image = Properties.Resources.btn_on;
        }
    }
}
