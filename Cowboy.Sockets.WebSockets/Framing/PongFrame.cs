﻿using System.Text;

namespace Cowboy.Sockets.WebSockets
{
    public sealed class PongFrame : ControlFrame
    {
        public PongFrame()
        {
        }

        public PongFrame(string applicationData)
            : this()
        {
            this.ApplicationData = applicationData;
        }

        public string ApplicationData { get; private set; }

        public override FrameOpCode OpCode
        {
            get { return FrameOpCode.Pong; }
        }

        public byte[] ToArray()
        {
            var data = Encoding.UTF8.GetBytes(ApplicationData);
            return Encode(OpCode, data, 0, data.Length);
        }
    }
}
