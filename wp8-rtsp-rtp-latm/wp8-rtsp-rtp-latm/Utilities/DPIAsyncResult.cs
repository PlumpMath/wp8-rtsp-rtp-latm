using System;
using System.Net;
using System.Threading;

namespace wp8_rtsp_rtp
{
    public class DPIAsyncResult : IAsyncResult
    {
        private int PortNo;
        private WaitHandle wh;

        public DPIAsyncResult(int p)
        {
            PortNo = p;
        }

        public object AsyncState
        {
            get { return PortNo; }
        }

        public WaitHandle AsyncWaitHandle
        {
            get { return wh; }
        }

        public bool CompletedSynchronously
        {
            get { return false; }
        }

        public bool IsCompleted
        {
            get { return true; }
        }
    }
}
