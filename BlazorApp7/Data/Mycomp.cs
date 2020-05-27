using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorApp7.Data
{
    public class Mycomp: ComponentBase
    {
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<span> BuildRenderTree  使用 AddMarkupContent 输出 Html 。</span>");
            //base.BuildRenderTree(builder);//加断点
         
        }
    }
}
