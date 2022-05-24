﻿using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpCommunityTalks;

[Dependency(ReplaceServices = true)]
public class AbpCommunityTalksBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpCommunityTalks";
}
