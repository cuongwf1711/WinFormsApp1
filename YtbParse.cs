using System.Text.RegularExpressions;
using YoutubeExplode;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;

namespace WinFormsApp1
{
    public class YtbParse
    {
        public string UrlOfVideo { get; set; }
        private readonly YoutubeClient youtube = new YoutubeClient();
        public async Task<string> GetName()
        {
            try
            {
                var videoId = YoutubeExplode.Videos.VideoId.Parse(UrlOfVideo);
                var video = await youtube.Videos.GetAsync(videoId);
                string s =  Regex.Replace(video.Title, "[^a-zA-Z0-9]+", "", RegexOptions.Compiled);
                return s.Substring(0, Math.Min(s.Length, 200));
            }
            catch
            {
                return string.Empty;
            }
        }
        public async Task<string> GetUrlDownloadMp4()
        {
            try
            {
                var videoId = YoutubeExplode.Videos.VideoId.Parse(UrlOfVideo);
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoId);
                var videoStreamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
                return videoStreamInfo.Url;
            }
            catch
            {
                return string.Empty;
            }
        }
        public async Task<string> GetUrlDownloadMp3()
        {
            try
            {
                var videoId = YoutubeExplode.Videos.VideoId.Parse(UrlOfVideo);
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoId);
                var audioStreamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
                return audioStreamInfo.Url;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
