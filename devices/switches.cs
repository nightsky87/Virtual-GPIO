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
        private byte swState = 0x00;

        private async void sw7_Click(object sender, EventArgs e)
        {
            swState ^= 0x80;

            if ((swState & 0x80) == 0)
                sw7.Image = Properties.Resources.sw_off;
            else
                sw7.Image = Properties.Resources.sw_on;

            await sendData();
        }

        private async void sw6_Click(object sender, EventArgs e)
        {
            swState ^= 0x40;

            if ((swState & 0x40) == 0)
                sw6.Image = Properties.Resources.sw_off;
            else
                sw6.Image = Properties.Resources.sw_on;

            await sendData();
        }

        private async void sw5_Click(object sender, EventArgs e)
        {
            swState ^= 0x20;

            if ((swState & 0x20) == 0)
                sw5.Image = Properties.Resources.sw_off;
            else
                sw5.Image = Properties.Resources.sw_on;

            await sendData();
        }

        private async void sw4_Click(object sender, EventArgs e)
        {
            swState ^= 0x10;

            if ((swState & 0x10) == 0)
                sw4.Image = Properties.Resources.sw_off;
            else
                sw4.Image = Properties.Resources.sw_on;

            await sendData();
        }

        private async void sw3_Click(object sender, EventArgs e)
        {
            swState ^= 0x08;

            if ((swState & 0x08) == 0)
                sw3.Image = Properties.Resources.sw_off;
            else
                sw3.Image = Properties.Resources.sw_on;

            await sendData();
        }

        private async void sw2_Click(object sender, EventArgs e)
        {
            swState ^= 0x04;

            if ((swState & 0x04) == 0)
                sw2.Image = Properties.Resources.sw_off;
            else
                sw2.Image = Properties.Resources.sw_on;

            await sendData();
        }

        private async void sw1_Click(object sender, EventArgs e)
        {
            swState ^= 0x02;

            if ((swState & 0x02) == 0)
                sw1.Image = Properties.Resources.sw_off;
            else
                sw1.Image = Properties.Resources.sw_on;

            await sendData();
        }

        private async void sw0_Click(object sender, EventArgs e)
        {
            swState ^= 0x01;

            if ((swState & 0x01) == 0)
                sw0.Image = Properties.Resources.sw_off;
            else
                sw0.Image = Properties.Resources.sw_on;

            await sendData();
        }

        private void updateSwitchImages()
        {
            if ((swState & 0x80) == 0)
                sw7.Image = Properties.Resources.sw_off;
            else
                sw7.Image = Properties.Resources.sw_on;

            if ((swState & 0x40) == 0)
                sw6.Image = Properties.Resources.sw_off;
            else
                sw6.Image = Properties.Resources.sw_on;

            if ((swState & 0x20) == 0)
                sw5.Image = Properties.Resources.sw_off;
            else
                sw5.Image = Properties.Resources.sw_on;

            if ((swState & 0x10) == 0)
                sw4.Image = Properties.Resources.sw_off;
            else
                sw4.Image = Properties.Resources.sw_on;

            if ((swState & 0x08) == 0)
                sw3.Image = Properties.Resources.sw_off;
            else
                sw3.Image = Properties.Resources.sw_on;

            if ((swState & 0x04) == 0)
                sw2.Image = Properties.Resources.sw_off;
            else
                sw2.Image = Properties.Resources.sw_on;

            if ((swState & 0x02) == 0)
                sw1.Image = Properties.Resources.sw_off;
            else
                sw1.Image = Properties.Resources.sw_on;

            if ((swState & 0x01) == 0)
                sw0.Image = Properties.Resources.sw_off;
            else
                sw0.Image = Properties.Resources.sw_on;
        }
    }
}
