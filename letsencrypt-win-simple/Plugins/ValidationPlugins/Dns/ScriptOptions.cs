﻿using ACMESharp.Authorizations;
using PKISharp.WACS.Plugins.Base.Options;

namespace PKISharp.WACS.Plugins.ValidationPlugins.Dns
{
    class ScriptOptions : ValidationPluginOptions<Script>
    {
        public override string Name => "DnsScript";
        public override string Description => "Run external program/script to create and update records";
        public override string ChallengeType { get => Dns01ChallengeValidationDetails.Dns01ChallengeType; }

        public DnsScriptOptions ScriptConfiguration { get; set; }
    }
}