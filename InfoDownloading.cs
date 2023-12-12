using System.ComponentModel;

namespace WinFormsApp1
{
    public class InfoDownloading
    {
        public string FileName { get; set; }
        public long TotalBytesSegment { get; set; }
        public long _bytesSegmentDownloaded;
        public long BytesSegmentDownloaded 
        { 
            get 
            { 
                return _bytesSegmentDownloaded; 
            } 
            set 
            { 
                _bytesSegmentDownloaded = value; 
            } 
        }
        public string Status { get; set; }
        [Browsable(false)]
        public long TotalBytesDownloaded { get; set; }
        [Browsable(false)]
        public long FileSize { get; set; }
    }
}
