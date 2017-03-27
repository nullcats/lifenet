using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace NullCatsAccelerometer.classes
{
    public static class TwilioApi
    {
        public static void SendTwilio(string phone, string msgBody)
        {
            var accountSid = "ACf8a13d8e272a89cd8584cf4950c17718";
            var authToken = "fa6a8ac76a18ac30b839e065a70bf82f";
            var fromNum = "+12532851010";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                to: new PhoneNumber("+1" + phone),
                from: new PhoneNumber(fromNum),
                body: msgBody);
        }
    }
}