﻿﻿using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using Refit;
using System.Threading.Tasks;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

namespace RefitInternalGenerated
{
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {
#pragma warning disable 0649
        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
#pragma warning restore 0649
    }
}

namespace XamarinEvolve.Core.Models
{
    using RefitInternalGenerated;

    [Preserve]
    public partial class AutoGeneratedISlackApi : ISlackApi
    {
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedISlackApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        public virtual Task<AvailableTeamList> GetTeamsForUserRaw(Dictionary<string, string> form)
        {
            var arguments = new object[] { form };
            return (Task<AvailableTeamList>) methodImpls["GetTeamsForUserRaw"](Client, arguments);
        }

        public virtual Task<AuthenticationResult> LoginRaw(Dictionary<string, string> form)
        {
            var arguments = new object[] { form };
            return (Task<AuthenticationResult>) methodImpls["LoginRaw"](Client, arguments);
        }

        public virtual Task<ChannelList> GetChannelsRaw(Dictionary<string, string> form)
        {
            var arguments = new object[] { form };
            return (Task<ChannelList>) methodImpls["GetChannelsRaw"](Client, arguments);
        }

        public virtual Task<MessageListForRoom> GetMessagesForChannelRaw(Dictionary<string, string> form)
        {
            var arguments = new object[] { form };
            return (Task<MessageListForRoom>) methodImpls["GetMessagesForChannelRaw"](Client, arguments);
        }

    }
}


