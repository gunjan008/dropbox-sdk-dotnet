// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Linked an app for team member.</para>
    /// </summary>
    public class AppLinkUserDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<AppLinkUserDetails> Encoder = new AppLinkUserDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<AppLinkUserDetails> Decoder = new AppLinkUserDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="AppLinkUserDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="appInfo">Relevant application details.</param>
        public AppLinkUserDetails(AppLogInfo appInfo)
        {
            if (appInfo == null)
            {
                throw new sys.ArgumentNullException("appInfo");
            }

            this.AppInfo = appInfo;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="AppLinkUserDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public AppLinkUserDetails()
        {
        }

        /// <summary>
        /// <para>Relevant application details.</para>
        /// </summary>
        public AppLogInfo AppInfo { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="AppLinkUserDetails" />.</para>
        /// </summary>
        private class AppLinkUserDetailsEncoder : enc.StructEncoder<AppLinkUserDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(AppLinkUserDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("app_info", value.AppInfo, writer, global::Dropbox.Api.TeamLog.AppLogInfo.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="AppLinkUserDetails" />.</para>
        /// </summary>
        private class AppLinkUserDetailsDecoder : enc.StructDecoder<AppLinkUserDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="AppLinkUserDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override AppLinkUserDetails Create()
            {
                return new AppLinkUserDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(AppLinkUserDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "app_info":
                        value.AppInfo = global::Dropbox.Api.TeamLog.AppLogInfo.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
