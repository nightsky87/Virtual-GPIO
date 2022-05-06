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
        PictureBox[] swArr;
        private bool inputEnabled = false;

        public Form1()
        {
            InitializeComponent();
            swArr = new PictureBox[] { sw0, sw1, sw2, sw3, sw4, sw5, sw6, sw7 };
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            boardId = (byte)(comboBoard.SelectedIndex + 1);
            await websockDisconnect();
            await websockConnect();
        }

        private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //await websockDisconnect();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textStatus.Text = "Disconnected";
            textStatus.BackColor = Color.DarkGray;
            ws = new System.Net.WebSockets.ClientWebSocket();
            disableInputs();
            findControllers();
        }

        public class DisabledTextBox : System.Windows.Forms.TextBox
        {
            private const int WM_SETFOCUS = 0x07;
            private const int WM_ENABLE = 0x0A;
            private const int WM_SETCURSOR = 0x20;

            protected override void WndProc(ref System.Windows.Forms.Message m)
            {
                if (!(m.Msg == WM_SETFOCUS || m.Msg == WM_ENABLE || m.Msg == WM_SETCURSOR))
                    base.WndProc(ref m);
            }
        }

        private void disableInputs()
        {
            btnUpL.Enabled = false;
            btnDownL.Enabled = false;
            btnLeftL.Enabled = false;
            btnRightL.Enabled = false;
            btnUpR.Enabled = false;
            btnDownR.Enabled = false;
            btnLeftR.Enabled = false;
            btnRightR.Enabled = false;
            sw7.Enabled = false;
            sw6.Enabled = false;
            sw5.Enabled = false;
            sw4.Enabled = false;
            sw3.Enabled = false;
            sw2.Enabled = false;
            sw1.Enabled = false;
            sw0.Enabled = false;
            inputEnabled = false;
        }

        private void enableInputs()
        {
            btnUpL.Enabled = true;
            btnDownL.Enabled = true;
            btnLeftL.Enabled = true;
            btnRightL.Enabled = true;
            btnUpR.Enabled = true;
            btnDownR.Enabled = true;
            btnLeftR.Enabled = true;
            btnRightR.Enabled = true;
            sw7.Enabled = true;
            sw6.Enabled = true;
            sw5.Enabled = true;
            sw4.Enabled = true;
            sw3.Enabled = true;
            sw2.Enabled = true;
            sw1.Enabled = true;
            sw0.Enabled = true;
            inputEnabled = true;
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                e.IsInputKey = true;
        }

    }
}
