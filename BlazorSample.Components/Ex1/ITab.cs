using Microsoft.AspNetCore.Components;

namespace BlazorSample.Components.Ex1
{
    public interface ITab
    {
        public RenderFragment ChildContent { get; }
    }
}
