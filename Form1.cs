using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Virtual_GPIO
{
    public partial class Form1 : Form
    {
        private byte boardId;
        private byte swState = 0x00;

        PictureBox[] swArr;

        public Form1()
        {
            InitializeComponent();
            swArr = new PictureBox[] { sw0, sw1, sw2, sw3, sw4, sw5, sw6, sw7 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            websockConnect();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            boardId = (byte)(comboBoard.SelectedIndex + 1);
            pollTimer.Enabled = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 49 && e.KeyChar <= 56)
            {
                int n = 7 - (e.KeyChar - 49);
                swState = (byte)(swState ^ (1 << n));
                if ((swState & (1 << n)) == 0)
                    swArr[n].Image = Properties.Resources.sw_off;
                else
                    swArr[n].Image = Properties.Resources.sw_on;

                sendData();
            }
        }

        private void sw7_Click(object sender, EventArgs e)
        {
            swState ^= 0x80;

            if ((swState & 0x80) == 0)
                sw7.Image = Properties.Resources.sw_off;
            else
                sw7.Image = Properties.Resources.sw_on;

            sendData();
        }

        private void sw6_Click(object sender, EventArgs e)
        {
            swState ^= 0x40;

            if ((swState & 0x40) == 0)
                sw6.Image = Properties.Resources.sw_off;
            else
                sw6.Image = Properties.Resources.sw_on;

            sendData();
        }

        private void sw5_Click(object sender, EventArgs e)
        {
            swState ^= 0x20;

            if ((swState & 0x20) == 0)
                sw5.Image = Properties.Resources.sw_off;
            else
                sw5.Image = Properties.Resources.sw_on;

            sendData();
        }

        private void sw4_Click(object sender, EventArgs e)
        {
            swState ^= 0x10;

            if ((swState & 0x10) == 0)
                sw4.Image = Properties.Resources.sw_off;
            else
                sw4.Image = Properties.Resources.sw_on;

            sendData();
        }

        private void sw3_Click(object sender, EventArgs e)
        {
            swState ^= 0x08;

            if ((swState & 0x08) == 0)
                sw3.Image = Properties.Resources.sw_off;
            else
                sw3.Image = Properties.Resources.sw_on;

            sendData();
        }

        private void sw2_Click(object sender, EventArgs e)
        {
            swState ^= 0x04;

            if ((swState & 0x04) == 0)
                sw2.Image = Properties.Resources.sw_off;
            else
                sw2.Image = Properties.Resources.sw_on;

            sendData();
        }

        private void sw1_Click(object sender, EventArgs e)
        {
            swState ^= 0x02;

            if ((swState & 0x02) == 0)
                sw1.Image = Properties.Resources.sw_off;
            else
                sw1.Image = Properties.Resources.sw_on;

            sendData();
        }

        private void sw0_Click(object sender, EventArgs e)
        {
            swState ^= 0x01;

            if ((swState & 0x01) == 0)
                sw0.Image = Properties.Resources.sw_off;
            else
                sw0.Image = Properties.Resources.sw_on;

            sendData();
        }

        private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                await websockDisconnect();
            }
            finally
            {
            }
        }
    }
}
