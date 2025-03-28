// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary> A content filter result for an image generation operation's input request content. </summary>
    public partial class RequestImageContentFilterResult : ResponseImageContentFilterResult
    {
        internal RequestImageContentFilterResult(ContentFilterDetectionResult jailbreak)
        {
            Jailbreak = jailbreak;
        }

        internal RequestImageContentFilterResult(ContentFilterSeverityResult sexual, ContentFilterSeverityResult violence, ContentFilterSeverityResult hate, ContentFilterSeverityResult selfHarm, IDictionary<string, BinaryData> additionalBinaryDataProperties, ContentFilterDetectionResult profanity, ContentFilterBlocklistResult customBlocklists, ContentFilterDetectionResult jailbreak) : base(sexual, violence, hate, selfHarm, additionalBinaryDataProperties)
        {
            Profanity = profanity;
            CustomBlocklists = customBlocklists;
            Jailbreak = jailbreak;
        }

        /// <summary>
        /// A detection result that identifies whether crude, vulgar, or otherwise objection language is present in the
        /// content.
        /// </summary>
        public ContentFilterDetectionResult Profanity { get; }

        /// <summary> A collection of binary filtering outcomes for configured custom blocklists. </summary>
        public ContentFilterBlocklistResult CustomBlocklists { get; }

        /// <summary>
        /// A detection result that describes user prompt injection attacks, where malicious users deliberately exploit
        /// system vulnerabilities to elicit unauthorized behavior from the LLM. This could lead to inappropriate content
        /// generation or violations of system-imposed restrictions.
        /// </summary>
        public ContentFilterDetectionResult Jailbreak { get; }
    }
}
