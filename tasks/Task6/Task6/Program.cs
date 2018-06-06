using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;
using static System.Console;

namespace Task6
{
    class Program
    {

        static void Main(string[] args)
        {
            var source = new Subject<PC>();

            source
                .Sample(TimeSpan.FromSeconds(1.0))
                .Subscribe(x => WriteLine($"received "+ x.Name + " Preis: " + x.Price))
                ;

            var t = new Thread(() =>
            {
                var i = 0;
                while (true)
                {
                    PC pc = new PC("Need for Speed", "Racing", "Electronic Arts", "PS4", 30 + i);
                    Thread.Sleep(2500);
                    source.OnNext(pc);
                    WriteLine($"sent");
                    i++;
                }
            });
            t.Start();
        }
    }
}
