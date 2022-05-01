using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading;
using System.Threading.Tasks;
using System.Net.WebSockets;
using System.Windows.Forms;

namespace Virtual_GPIO
{
    partial class Form1
    {
        private int numInput;
        private int numOutput;

        private ClientWebSocket ws = null;

        static CancellationTokenSource cts = new CancellationTokenSource();
        static CancellationToken ct = cts.Token;

        private async Task websockConnect()
        {
            Uri uri = new Uri("ws://192.168.30.5:3120");

            comboBoard.Enabled = false;
            do
            {
                try
                {
                    ws = new ClientWebSocket();
                    await ws.ConnectAsync(uri, ct);
                }
                catch
                {
                    var result = MessageBox.Show("Cannot connect to MicroEskimo.\nPlease ensure that both the device and the VPN are on.", "Connection Error", MessageBoxButtons.RetryCancel);
                    if (result == DialogResult.Cancel)
                    {
                        comboBoard.Enabled = true;
                        return;
                    }
                }
            } while (ws.State != WebSocketState.Open);
            comboBoard.Enabled = true;

            // Send the board number
            var array = new byte[] { boardId };
            ArraySegment<byte> buffer = new ArraySegment<byte>(array);
            await ws.SendAsync(buffer, WebSocketMessageType.Binary, true, ct);

            // Query the device counts
            buffer = new ArraySegment<byte>(new byte[2]);
            await ws.ReceiveAsync(buffer, ct);
            numInput = buffer.Array[0];
            numOutput = buffer.Array[1];

            // Check if the board is valid
            if (numInput == 255 || numOutput == 255)
            {
                textStatus.Text = "Board Error";
                textStatus.BackColor = Color.Red;
                await websockDisconnect();
                return;
            }
            enableInputs();

            textStatus.Text = "Connected";
            textStatus.BackColor = Color.LightGreen;

            // Wait for periodic updates for the virtual output devices
            await getData();
        }

        private async Task websockDisconnect()
        {
            disableInputs();
            if (ws.State == WebSocketState.Open)
            {
                await ws.CloseOutputAsync(WebSocketCloseStatus.NormalClosure, "Exit program", ct);
            }
        }

        private async Task sendData()
        {
            if (ws.State == WebSocketState.Open)
            {
                var array = new byte[] { btnState, swState };
                ArraySegment<byte> payload = new ArraySegment<byte>(array);
                await ws.SendAsync(payload, WebSocketMessageType.Binary, true, ct);
            }
        }

        private async Task getData()
        {
            ArraySegment<byte> buffer = new ArraySegment<byte>(new byte[numOutput + numInput + 1]);
            while (true)
            {
                if (ws.State == WebSocketState.Open)
                {
                    await ws.ReceiveAsync(buffer, ct);

                    int msgType = buffer.Array[0];
                    if (msgType == 0)
                    {
                        byte ledVal = buffer.Array[1];
                        updateLed(ledVal);
                    }
                    else
                    {

                        btnState = buffer.Array[1];
                        updateButtonImages();

                        swState = buffer.Array[2];
                        updateSwitchImages();
                    }
                }
                else
                {
                    return;
                }
            }
        }
    }
}
