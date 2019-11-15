using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRades.Web
{

    public class BladeHost : ComponentBase
    {
        public IEnumerable<Blaze> Blades { get; private set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "blade-host");
            builder.AddAttribute(1, "class", "blade-host-element");
            builder.OpenElement(2, "blade-stack");
            builder.AddAttribute(3, "id", "stack1");
            builder.AddAttribute(4, "class", "blade-stack-element");
            int i = 3;
            foreach (var blade in Blades)
            {
                i++;

                CreateComponent(Blades);
            }

            //builder.AddAttribute(, "ChildContent", (RenderFragment)((builder2) => {
            //    builder2.AddContent(3, "Home");
            //}));
            builder.CloseElement();
        }

        private RenderFragment CreateComponent(IEnumerable<Blaze> j) => builder =>
        {
            var a = j;
            foreach (var item in j)
            {
               // builder.
            }

            for (var i = 0; i < 3; i++)
            {
                builder.OpenComponent(0, typeof(Blaze));
                builder.AddAttribute(1, "PetDetailsQuote", "Someone's best friend!");
                builder.CloseComponent();
            }
        };


    }

    public class Blaze :ComponentBase
    {
        public Blaze(string title, string subtitle)
        {
            Title = title;
            Subtitle = subtitle;
        }

        public string Title { get; }
        public string Subtitle { get; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {

            base.BuildRenderTree(builder);
            builder.OpenElement(0, "blade-blade");
            builder.AddAttribute(1, "class", "blade-blade-element");
            builder.AddAttribute(2, "id", "blade1");
            builder.CloseElement();
            builder.OpenElement(3,"header");
            builder.CloseElement();

        }
    }
}
