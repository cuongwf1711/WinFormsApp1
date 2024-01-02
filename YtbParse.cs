using System.Text.RegularExpressions;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace WinFormsApp1
{
    public class YtbParse
    {
        private readonly YoutubeClient youtube = new YoutubeClient();

        public string UrlOfVideo { get;  }

        public YtbParse(string urlOfVideo)
        {
            UrlOfVideo = urlOfVideo;
        }

        private string VideoId
        {
            get
            {
                return YoutubeExplode.Videos.VideoId.Parse(UrlOfVideo);
            }
        }

        public async Task<string> GetName()
        {
            try
            {
                YoutubeExplode.Videos.Video video = await youtube.Videos.GetAsync(VideoId);
                string nameVideo =  Regex.Replace(video.Title, "[^a-zA-Z0-9]+", "", RegexOptions.Compiled);
                return nameVideo.Substring(0, Math.Min(nameVideo.Length, 50));
            }
            catch
            {
                return string.Empty;
            }
        }

        public async Task<string> GetUrlDownload(string extensionFile)
        {
            try
            {
                StreamManifest streamManifest = await youtube.Videos.Streams.GetManifestAsync(VideoId);

                if(extensionFile == ".mp3")
                {
                    YoutubeExplode.Videos.Streams.IStreamInfo audioStreamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
                    return audioStreamInfo.Url;
                }
                else if(extensionFile == ".mp4")
                {
                    YoutubeExplode.Videos.Streams.IVideoStreamInfo videoStreamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
                    return videoStreamInfo.Url;
                }

                return string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
