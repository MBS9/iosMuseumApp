using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace museumApp;

public class announceScrollable : TriggerAction<VisualElement>
{
    /*
     A class which can be used to announce that a page is scrollable.
     To be linked to the page as a Trigger in XAML.
     */
    protected override async void Invoke(VisualElement element)
    {
        await Task.Delay(2000); // 2-secs delay to wait for page to finish loading.
        SemanticScreenReader.Announce("This is a scrollable page. By scrolling, you can find more text.");
    }
}
