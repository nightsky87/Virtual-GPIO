using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DXNET.XInput;

namespace Virtual_GPIO
{
    partial class Form1
    {

        private async Task findControllers()
        {
            var controllers = new[] { new Controller(UserIndex.One), new Controller(UserIndex.Two), new Controller(UserIndex.Three), new Controller(UserIndex.Four) };

            // Check each controller slot if available
            Controller controller = null;
            while (true)
            {
                if (controllers[0].IsConnected)
                {
                    controller = controllers[0];
                    break;
                }
                if (controllers[1].IsConnected)
                {
                    controller = controllers[1];
                    break;
                }
                if (controllers[2].IsConnected)
                {
                    controller = controllers[2];
                    break;
                }
                if (controllers[3].IsConnected)
                {
                    controller = controllers[3];
                    break;
                }
            }
            // Get inputs from the controller
            await pollController(controller);
        }

        private async Task pollController(Controller controller)
        {
            while (true)
            {
                var state = controller.GetState();
                double leftAngle = Math.Atan2(state.Gamepad.LeftThumbY, state.Gamepad.LeftThumbX) / Math.PI * 180;
                double leftRad = Math.Sqrt(state.Gamepad.LeftThumbX * state.Gamepad.LeftThumbX + state.Gamepad.LeftThumbY * state.Gamepad.LeftThumbY);
                double rightAngle = Math.Atan2(state.Gamepad.RightThumbY, state.Gamepad.RightThumbX) / Math.PI * 180;
                double rightRad = Math.Sqrt(state.Gamepad.RightThumbX * state.Gamepad.RightThumbX + state.Gamepad.RightThumbY * state.Gamepad.RightThumbY);

                if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadUp) || (leftRad >= 10000 && (leftAngle >= 22.5 && leftAngle <= 157.5)))
                    btnState |= 0x80;
                else
                    btnState &= unchecked((byte)~0x80);

                if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadDown) || (leftRad >= 10000 && (leftAngle <= -22.5 && leftAngle >= -157.5)))
                    btnState |= 0x40;
                else
                    btnState &= unchecked((byte)~0x40);

                if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadLeft) || (leftRad >= 10000 && (leftAngle >= 112.5 || leftAngle <= -112.5)))
                    btnState |= 0x20;
                else
                    btnState &= unchecked((byte)~0x20);

                if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadRight) || (leftRad >= 10000 && (leftAngle >= -67.5 && leftAngle <= 67.5)))
                    btnState |= 0x10;
                else
                    btnState &= unchecked((byte)~0x10);

                if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Y) || (rightRad >= 10000 && (rightAngle >= 22.5 && rightAngle <= 157.5)))
                    btnState |= 0x08;
                else
                    btnState &= unchecked((byte)~0x08);

                if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.A) || (rightRad >= 10000 && (rightAngle <= -22.5 && rightAngle >= -157.5)))
                    btnState |= 0x04;
                else
                    btnState &= unchecked((byte)~0x04);

                if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.X) || (rightRad >= 10000 && (rightAngle >= 112.5 || rightAngle <= -112.5)))
                    btnState |= 0x02;
                else
                    btnState &= unchecked((byte)~0x02);

                if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.B) || (rightRad >= 10000 && (rightAngle >= -67.5 && rightAngle <= 67.5)))
                    btnState |= 0x01;
                else
                    btnState &= unchecked((byte)~0x01);

                updateButtonImages();
                await Task.Delay(10);
            }
        }

        //XInput x = new XInput();
        //x.GetState()
       
        //EnvironmentVariableTarget x
    }
}
