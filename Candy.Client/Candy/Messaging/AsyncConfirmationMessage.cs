﻿using System.Threading.Tasks;
using System.Windows;
using Livet.Messaging;

namespace Candy.Client.Messaging
{
    /// <summary>
    /// 非同期的に確認メッセージを表示する相互作用メッセージです。
    /// </summary>
    public class AsyncConfirmationMessage : ResponsiveInteractionMessage<Task<bool?>>
    {
        public static readonly DependencyProperty CaptionProperty =
            DependencyProperty.Register("Caption", typeof(string), typeof(AsyncConfirmationMessage), new PropertyMetadata(null));

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(AsyncConfirmationMessage), new PropertyMetadata(null));

        public string Caption
        {
            get { return (string)GetValue(CaptionProperty); }
            set { SetValue(CaptionProperty, value); }
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        protected override Freezable CreateInstanceCore()
        {
            return new AsyncConfirmationMessage
            {
                Caption = Caption,
                Text = Text,
                MessageKey = MessageKey,
                Response = Response
            };
        }
    }
}