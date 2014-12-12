using System;
using ticketlenadena.Social;
using Facebook;
using System.Collections.Generic;

namespace ticketlenadena
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        string message = "";
        protected void Twittwerbutton_Click(object sender, EventArgs e)
        {
            try
            {
                message = "Developing new website. API used..";
                PostToTwitter.PostMessageToTwitter(message);
            }
            catch (Exception ex)
            {

            }
        }

        protected void FacebookButton_Click(object sender, EventArgs e)
        {
            message = "Developing new website.Testing facebook, posting through code..";
            PostToFacebook.PostFacebookWall("CAACEdEose0cBABAdjWwWnJabi0bMSaIdepWYrRlfgPyrLLyOwRoI85krzXeNKtXMKRMuvDXJJJnZCqb66JEAY9wOjK8YfY2s4n2FcYiVHBXHZAKr1B4ZAU7u5NZBxjZBZC6rMrJoQnCrnYE1o8q4u9FS87idprSSIZBvVKhaiyhebREjQlC3rbsFQqNclyqMT12eetGiUT1XL9733yQZBKWB", message);
        }


       
    }
}