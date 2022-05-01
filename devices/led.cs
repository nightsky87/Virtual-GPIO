using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_GPIO
{
    partial class Form1
    {
        private void updateLed(byte ledVal)
        {
            if ((ledVal & 0x80) == 0)
                led7.Image = Properties.Resources.led_off;
            else
                led7.Image = Properties.Resources.led_on;

            if ((ledVal & 0x40) == 0)
                led6.Image = Properties.Resources.led_off;
            else
                led6.Image = Properties.Resources.led_on;

            if ((ledVal & 0x20) == 0)
                led5.Image = Properties.Resources.led_off;
            else
                led5.Image = Properties.Resources.led_on;

            if ((ledVal & 0x10) == 0)
                led4.Image = Properties.Resources.led_off;
            else
                led4.Image = Properties.Resources.led_on;

            if ((ledVal & 0x08) == 0)
                led3.Image = Properties.Resources.led_off;
            else
                led3.Image = Properties.Resources.led_on;

            if ((ledVal & 0x04) == 0)
                led2.Image = Properties.Resources.led_off;
            else
                led2.Image = Properties.Resources.led_on;

            if ((ledVal & 0x02) == 0)
                led1.Image = Properties.Resources.led_off;
            else
                led1.Image = Properties.Resources.led_on;

            if ((ledVal & 0x01) == 0)
                led0.Image = Properties.Resources.led_off;
            else
                led0.Image = Properties.Resources.led_on;
        }
    }
}
