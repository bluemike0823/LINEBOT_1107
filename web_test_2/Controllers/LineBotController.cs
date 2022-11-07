using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace web_test_2.Controllers
{
    public class LineBotController : ApiController
    {
        [HttpPost]
        public IHttpActionResult POST()
        {

            string ChannelAccessToken = "a4edwdIAeqc5uu7/msDVPnsTrpm/oYudOhqKjqLaHgcGyEU54rlntw3YBM2Moi02TLzqgEksmdlf5hEkjGXZ+S2mwlOEoVWOTjArjw3OFQR5oPEvvRuwsirbCLMnWVgzKAm3Jw/BXxZGBFwPfbpMYwdB04t89/1O/w1cDnyilFU=";

            try
            {
                string postData = Request.Content.ReadAsStringAsync().Result;

                var ReceivedMessage = isRock.LineBot.Utility.Parsing(postData);
                string Message;
                Message = "return : " + ReceivedMessage.events[0].message.text;


                isRock.LineBot.Utility.ReplyMessage(ReceivedMessage.events[0].replyToken, Message, ChannelAccessToken);

                // https://webtest220220804005546.azurewebsites.net/api/LineBot

                return Ok();
            }catch(Exception ex)
            {
                return Ok();
            }
        }

    }
}
