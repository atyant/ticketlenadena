using Facebook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ticketlenadena.Social
{
    public class PostToFacebook
    {
        public static string PostFacebookWall(string accessToken, string message)
        {
            var responsePost = "";
            try
            {
                //create the facebook account object
                var objFacebookClient = new FacebookClient(accessToken);
                objFacebookClient.AppId = "870310786347347";
                objFacebookClient.AppSecret = "135720785caa2309fca03bc4490b52eb";
                var parameters = new Dictionary<string, object>();
                parameters["message"] = message;
                responsePost = objFacebookClient.Post("feed", parameters).ToString();
            }
            catch (Exception ex)
            {
                responsePost = "Facebook Posting Error Message: " + ex.Message;
            }
            return responsePost;
        }
    }
}