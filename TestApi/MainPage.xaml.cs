using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Logger;
using InstagramApiSharp;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TestApi
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            Task();
        }

        public async void Task()
        {
            IInstaApi api = InstaApiBuilder.CreateBuilder().SetUser(new UserSessionData()
            {
                UserName = "the_shichko.exe",
                Password = "puzahainsta"
            }).UseLogger(new DebugLogger(LogLevel.Exceptions)).Build();

            api.LoadStateDataFromString("{\"DeviceInfo\":{\"PhoneGuid\":\"5a61abd5-439d-46d9-87d8-12eb34f83f83\",\"DeviceGuid\":\"522df03a-f190-411a-8002-6387ce68b1d9\",\"GoogleAdId\":\"f3515bbd-bdab-4011-87d1-b5cc24339395\",\"RankToken\":\"49cd61ee-7238-462f-ba64-e20bc81aad32\",\"AdId\":\"c18d8ee6-6810-4cfa-ba3f-8036b94dd68f\",\"PigeonSessionId\":\"f2194902-5065-4b5d-bc8e-e21bce8dbee6\",\"PushDeviceGuid\":\"51ed147a-8064-4c7e-9cd7-8f5ef5ea1ec6\",\"FamilyDeviceGuid\":\"e03f6991-61ee-4d27-ba6e-fcec639ede00\",\"AndroidVer\":{\"Codename\":\"Jelly Bean\",\"VersionNumber\":\"4.3\",\"APILevel\":\"18\"},\"AndroidBoardName\":\"f6t\",\"AndroidBootloader\":\"1.0.0.0000\",\"DeviceBrand\":\"lge\",\"DeviceId\":\"android-368ed3e31e42adbd\",\"DeviceModel\":\"LG-D500\",\"DeviceModelBoot\":\"qcom\",\"DeviceModelIdentifier\":\"f6_tmo_us\",\"FirmwareBrand\":\"f6_tmo_us\",\"FirmwareFingerprint\":\"lge/f6_tmo_us/f6:4.1.2/JZO54K/D50010h.1384764249:user/release-keys\",\"FirmwareTags\":\"release-keys\",\"FirmwareType\":\"user\",\"HardwareManufacturer\":\"LGE\",\"HardwareModel\":\"LG-D500\",\"Resolution\":\"1440x2560\",\"Dpi\":\"640dpi\",\"IGBandwidthSpeedKbps\":\"1427.424\",\"IGBandwidthTotalBytesB\":\"1255092\",\"IGBandwidthTotalTimeMS\":\"879\"},\"UserSession\":{\"UserName\":\"the_shichko.exe\",\"Password\":\"puzahainsta\",\"PublicKey\":\"LS0tLS1CRUdJTiBQVUJMSUMgS0VZLS0tLS0KTUlJQklqQU5CZ2txaGtpRzl3MEJBUUVGQUFPQ0FROEFNSUlCQ2dLQ0FRRUF4SVovcFhtWkt2NWwyaXRaV1VSTgovdThCUS90V1NvanRDYmVSdm1sNmV4NHJPVFB4WHc4cDZEV0FjbHQvZktqWng4ek9VczlDRkRmVlp1d1oybm9jCjd6MUtxWlE4UXpDVHFsd0kyNWZEMTVTOFdxSEV3YS9IYjBZNEpvbmtlVlFVQkZiU1FPZmp4UnZkcksyODR1N0oKM1FyWEoySVYzck9XTTU2WkJmZ29ZVTJnV3drNHVQYTNoTWVJelV3c1RBY1dtRU1qOW05WFdhZ2J2bEpJM3NoUAp1ci9vbCs4SEpOdFhROWJYOEU0KzBrOFBCZU5rTk5OSUZIM3k3ajRGZ0JqbXJWWS9ZU1VQMHMzS1ZqSlZSN3o3CjFDNzZCaXVYK0RTakRMbGx3UTQySmlMNVdSbDVjTktNalA0dHZZWE9Qa2QxTG81UzJqVURJYmo0N1Rud0pTejYKclFJREFRQUIKLS0tLS1FTkQgUFVCTElDIEtFWS0tLS0tCg==\",\"PublicKeyId\":\"223\",\"WwwClaim\":null,\"FbTripId\":null,\"Authorization\":null,\"LoggedInUser\":{\"IsVerified\":false,\"IsPrivate\":true,\"Pk\":1762195401,\"ProfilePicture\":\"https://instagram.fmsq1-1.fna.fbcdn.net/v/t51.2885-19/s150x150/87433407_523396181891831_2478325150609571840_n.jpg?_nc_ht=instagram.fmsq1-1.fna.fbcdn.net&_nc_ohc=b-K9Py8i9kEAX8Lt3M-&oh=947abf4f0998372d44d9858897b36acc&oe=5EAFB3AA\",\"ProfilePicUrl\":\"https://instagram.fmsq1-1.fna.fbcdn.net/v/t51.2885-19/s150x150/87433407_523396181891831_2478325150609571840_n.jpg?_nc_ht=instagram.fmsq1-1.fna.fbcdn.net&_nc_ohc=b-K9Py8i9kEAX8Lt3M-&oh=947abf4f0998372d44d9858897b36acc&oe=5EAFB3AA\",\"ProfilePictureId\":\"2249670442686493167_1762195401\",\"UserName\":\"the_shichko.exe\",\"FullName\":\"s h i c h o k\"},\"RankToken\":\"1762195401_5a61abd5-439d-46d9-87d8-12eb34f83f83\",\"CsrfToken\":\"xWXnIWDDfzcOsgvlxEO8zN0k1BlhEClU\",\"FacebookUserId\":\"\",\"FacebookAccessToken\":\"\"},\"IsAuthenticated\":true,\"Cookies\":{\"Capacity\":300,\"Count\":9,\"MaxCookieSize\":4096,\"PerDomainCapacity\":20},\"RawCookies\":[{\"IsQuotedDomain\":false,\"IsQuotedVersion\":false,\"Comment\":\"\",\"CommentUri\":null,\"HttpOnly\":false,\"Discard\":false,\"Domain\":\".instagram.com\",\"Expired\":false,\"Expires\":\"2021-04-02T10:27:09+03:00\",\"Name\":\"csrftoken\",\"Path\":\"/\",\"Port\":\"\",\"Secure\":true,\"TimeStamp\":\"2020-04-03T10:27:09.341723+03:00\",\"Value\":\"H3CKefqIhIg8alGxaXOq6eBOqYqkzH1i\",\"Variant\":1,\"Version\":0},{\"IsQuotedDomain\":false,\"IsQuotedVersion\":false,\"Comment\":\"\",\"CommentUri\":null,\"HttpOnly\":true,\"Discard\":false,\"Domain\":\".instagram.com\",\"Expired\":false,\"Expires\":\"0001-01-01T00:00:00\",\"Name\":\"rur\",\"Path\":\"/\",\"Port\":\"\",\"Secure\":true,\"TimeStamp\":\"2020-04-03T10:27:09.3417668+03:00\",\"Value\":\"FRC\",\"Variant\":1,\"Version\":0},{\"IsQuotedDomain\":false,\"IsQuotedVersion\":false,\"Comment\":\"\",\"CommentUri\":null,\"HttpOnly\":false,\"Discard\":false,\"Domain\":\".instagram.com\",\"Expired\":false,\"Expires\":\"2030-04-01T10:26:29+03:00\",\"Name\":\"mid\",\"Path\":\"/\",\"Port\":\"\",\"Secure\":true,\"TimeStamp\":\"2020-04-03T10:26:30.9639816+03:00\",\"Value\":\"XoblJQABAAGHRR41FGJkczpCLNZk\",\"Variant\":1,\"Version\":0},{\"IsQuotedDomain\":false,\"IsQuotedVersion\":false,\"Comment\":\"\",\"CommentUri\":null,\"HttpOnly\":true,\"Discard\":false,\"Domain\":\".instagram.com\",\"Expired\":false,\"Expires\":\"2020-07-02T10:27:09+03:00\",\"Name\":\"ds_user\",\"Path\":\"/\",\"Port\":\"\",\"Secure\":true,\"TimeStamp\":\"2020-04-03T10:27:09.3416717+03:00\",\"Value\":\"the_shichko.exe\",\"Variant\":1,\"Version\":0},{\"IsQuotedDomain\":false,\"IsQuotedVersion\":false,\"Comment\":\"\",\"CommentUri\":null,\"HttpOnly\":true,\"Discard\":false,\"Domain\":\".instagram.com\",\"Expired\":false,\"Expires\":\"2020-04-10T10:27:09+03:00\",\"Name\":\"shbid\",\"Path\":\"/\",\"Port\":\"\",\"Secure\":true,\"TimeStamp\":\"2020-04-03T10:27:09.3417409+03:00\",\"Value\":\"7957\",\"Variant\":1,\"Version\":0},{\"IsQuotedDomain\":false,\"IsQuotedVersion\":false,\"Comment\":\"\",\"CommentUri\":null,\"HttpOnly\":true,\"Discard\":false,\"Domain\":\".instagram.com\",\"Expired\":false,\"Expires\":\"2020-04-10T10:27:09+03:00\",\"Name\":\"shbts\",\"Path\":\"/\",\"Port\":\"\",\"Secure\":true,\"TimeStamp\":\"2020-04-03T10:27:09.3417544+03:00\",\"Value\":\"1585898829.3089757\",\"Variant\":1,\"Version\":0},{\"IsQuotedDomain\":false,\"IsQuotedVersion\":false,\"Comment\":\"\",\"CommentUri\":null,\"HttpOnly\":false,\"Discard\":false,\"Domain\":\".instagram.com\",\"Expired\":false,\"Expires\":\"2020-07-02T10:27:09+03:00\",\"Name\":\"ds_user_id\",\"Path\":\"/\",\"Port\":\"\",\"Secure\":true,\"TimeStamp\":\"2020-04-03T10:27:09.3417759+03:00\",\"Value\":\"1762195401\",\"Variant\":1,\"Version\":0},{\"IsQuotedDomain\":false,\"IsQuotedVersion\":false,\"Comment\":\"\",\"CommentUri\":null,\"HttpOnly\":true,\"Discard\":false,\"Domain\":\".instagram.com\",\"Expired\":false,\"Expires\":\"0001-01-01T00:00:00\",\"Name\":\"urlgen\",\"Path\":\"/\",\"Port\":\"\",\"Secure\":true,\"TimeStamp\":\"2020-04-03T10:27:09.3417896+03:00\",\"Value\":\"\\\"{\\\\\\\"46.216.66.54\\\\\\\": 25106}:1jKGjN:02IQ0iIkQsfUdc4mukgarllFVDc\\\"\",\"Variant\":1,\"Version\":0},{\"IsQuotedDomain\":false,\"IsQuotedVersion\":false,\"Comment\":\"\",\"CommentUri\":null,\"HttpOnly\":true,\"Discard\":false,\"Domain\":\".instagram.com\",\"Expired\":false,\"Expires\":\"2021-04-03T10:27:09+03:00\",\"Name\":\"sessionid\",\"Path\":\"/\",\"Port\":\"\",\"Secure\":true,\"TimeStamp\":\"2020-04-03T10:27:09.3417978+03:00\",\"Value\":\"1762195401%3Aop7jnRQaOx88F1%3A6\",\"Variant\":1,\"Version\":0}],\"InstaApiVersion\":22}");

            IResult<InstaCommentList> comments = await api.CommentProcessor.GetMediaCommentsAsync("2303279398725811943",
                PaginationParameters.MaxPagesToLoad(5));
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Task();
        }
    }
}
