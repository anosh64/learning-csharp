using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionmethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var post =
                "this is supposed to be a very very very very very very very very very very long blog post blah blah blah blah balh ablha blah lasdhfpokahs do;fihawa.kuef ghlqkjwe gflkuewr y fliu wgrlroug h q3rliuig hlkjerr hg.ljk ajshlfj aselkf hjalruh gkd hgiuhgkjh aerough qeru gygoqueurh gtoqhwrgj wnekjbh dilufhv bksjdr hgiusdf fhkgjjse ygiu 3roiughiruh gkajbmnamfbb kbjduga hrogh alkjrgh ouser htlkjehr gouoiyadfoughskjrjrhgsueuf b8sd ydf fog8 eeoig hljrgh aku sh gkueh giuer hgkj hdfiuvh hdfukgh sdfkfugybi7e r gkurgjkrhkg halkejlkrgh kjah fuheiguh sdfkjgh isudfyiu shtrtlghtrug hieu5hgiu4y giuerh gkusdhiug hdfkug gor hglsdhgksdh fkghsdfkfjghkjdfhgusdhfgkjshdfiguiksdjghfksud gksdhfkgjserkuyg ker hgiusdh gkjhs lrgh sadlkjflasdjflajsl;fkjas;fj;alsjkdf;a sf; jaso fhoej fow herfljhroug wo hgoq y340igqj[weqoiueryoiquuyewtokqh erl ti yerlkgjh a,jdg ,ms dbv.";
            // so it's long, and we want a preview, so we create an extension method
            var shortenedpost = post.Shorten(17); // this is not a built-in string function, we create it ourselves.

            Console.WriteLine(shortenedpost);
        }
    }
}
