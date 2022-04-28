using System;
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
        System.Timers.Timer pollTimer = null;
        private ClientWebSocket ws = null;
        CancellationToken ct = new CancellationToken();

        private async Task websockConnect()
        {
            ws = new ClientWebSocket();
            Uri uri = new Uri("ws://192.168.30.5:3120");

            do
            {
                try
                {
                    await ws.ConnectAsync(uri, ct);
                }
                catch
                {
                    var result = MessageBox.Show("Cannot connect to MicroEskimo.\nPlease ensure that both the device and the VPN are on.", "Connection Error", MessageBoxButtons.RetryCancel);
                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit();
                        break;
                    }
                }
            } while (ws.State != WebSocketState.Open);
            
            pollTimer = new System.Timers.Timer(10);
            pollTimer.Interval = 10;
            pollTimer.Elapsed += getData;
            pollTimer.AutoReset = true;
            pollTimer.Enabled = false;
        }
        private async Task websockDisconnect()
        {
            await ws.CloseAsync(WebSocketCloseStatus.NormalClosure, "Exit program", ct);
        }

        private async Task sendData()
        {
            var array = new byte[] { 0xFF, boardId, btnState, swState };
            ArraySegment<byte> payload = new ArraySegment<byte>(array);
            await ws.SendAsync(payload, WebSocketMessageType.Binary, true, ct);
        }
        private async void getData(Object source, ElapsedEventArgs e)
        {
            var array = new byte[] { 0x00, boardId, 0x00, 0x00 };
            ArraySegment<byte> payload = new ArraySegment<byte>(array);
            await ws.SendAsync(payload, WebSocketMessageType.Binary, true, ct);
            pollTimer.Stop();
            await ws.ReceiveAsync(payload, ct);

            byte[] data = payload.ToArray();
            updateLed(data[0]);
            pollTimer.Start();
        }
    }
}
