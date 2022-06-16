﻿using Android.Content;
using System;
using Olive;

namespace Zebble.Device
{
    public partial class Sharing
    {
        public partial class Twitter
        {
            public static void Tweet(string text)
                => TweetLink(text, string.Empty);

            //TODO implement Twitter sharing photo
            public static void TweetPhoto(string text, byte[] photo)
                => throw new NotImplementedException();

            public static void TweetLink(string text, string url)
            {
                text = text.OrEmpty().KeepReplacing("  ", " ").Replace(" ", "+");

                var twitterUrl = $"http://www.twitter.com/intent/tweet?url={url}&text={text}";
                var intent = new Intent(Intent.ActionView);
                intent.SetData(Android.Net.Uri.Parse(twitterUrl));
                UIRuntime.CurrentActivity.StartActivity(intent);
            }

            public static void Retweet(string tweetId)
            {
                var retweetUrl = $"https://twitter.com/intent/retweet?tweet_id={tweetId}";
                var intent = new Intent(Intent.ActionView);
                intent.SetData(Android.Net.Uri.Parse(retweetUrl));
                UIRuntime.CurrentActivity.StartActivity(intent);
            }
        }
    }
}