using System.Collections;
using DCL.Components.Video.Plugin;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.TestTools;


public class AvProVideoShould : MonoBehaviour
{

    public void Start()
    {
        AvProVideoTestCases("MP3", "https://www.soundhelix.com/examples/mp3/SoundHelix-Song-1.mp3");
        
        AvProVideoTestCases("loop", "https://player.vimeo.com/external/691621058.m3u8?s=a2aa7b62cd0431537ed53cd699109e46d0de8575");
        AvProVideoTestCases ("HTTPS+HLS 1", "https://player.vimeo.com/external/552481870.m3u8?s=c312c8533f97e808fccc92b0510b085c8122a875");
        AvProVideoTestCases("HTTPS+HLS 2", "https://player.vimeo.com/external/575854261.m3u8?s=d09797037b7f4f1013d337c04836d1e998ad9c80");
        AvProVideoTestCases("HTTP+MP4", "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4");
        AvProVideoTestCases("HTTP+WEBM", "http://techslides.com/demos/sample-videos/small.webm");
        AvProVideoTestCases("HTTP+OGV", "http://techslides.com/demos/sample-videos/small.ogv");
        AvProVideoTestCases("HTTPS+HLS", "https://player.vimeo.com/external/691415562.m3u8?s=65096902279bbd8bb19bf9e2b9391c4c7e510402");
        AvProVideoTestCases("JPEG", "https://ironapeclub.com/wp-content/uploads/2022/01/ironape-club-poster.jpg");
    }
    public IEnumerator AvProVideoTestCases(string id, string url)
    {
        if (Application.platform == RuntimePlatform.LinuxPlayer || Application.platform == RuntimePlatform.LinuxEditor)
        {
            Assert.IsTrue(true, "AVProVideo not supported in Linux for video " + url);
        }
        else
        {
            VideoPluginWrapper_AVPro pluginWrapperAvPro = new VideoPluginWrapper_AVPro();
            pluginWrapperAvPro.Create(id,url,true);

            yield return new WaitUntil(() => pluginWrapperAvPro.GetState(id) == VideoState.READY);

            Texture2D movieTexture = pluginWrapperAvPro.PrepareTexture(id);
            pluginWrapperAvPro.TextureUpdate(id);
            pluginWrapperAvPro.Play(id,0);
            pluginWrapperAvPro.SetVolume(id, 1);

            Assert.IsNotNull(movieTexture);
            Assert.IsNull(pluginWrapperAvPro.GetError(id));

            pluginWrapperAvPro.Remove(id);
        }
    }

}
