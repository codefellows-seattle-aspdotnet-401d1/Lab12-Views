using Microsoft.AspNetCore.Mvc;

namespace lab12_brian.Controllers
{
//    [Route("Main")]
    public class HomeController : Controller
    {
//        [Route("Home")]
        public string Index()
        {
            return "Welcome to the home page";
        }

        public string wat()
        {
            return $@"             _            _.,----,
 __  _.-._ / '-.        -  ,._  \) 
|  `-)_   '-.   \       / < _ )/"" }}
/__    '-.   \   '-, ___(c-(6)=(6)
 , `'.    `._ '.  _,'   >\    ""  )
 :;;,,'-._   '---' (  ( ""/`. -='/
;:;;:;;,  '..__    ,`-.`)'- '--'
;';:;;;;;'-._ /'._|   Y/   _/' \
      '''""._ F    |  _/ _.'._   `\
             L    \   \/     '._  \
      .-,-,_ |     `.  `'---,  \_ _|
      //    'L    /  \,   (""--',=`)7
     | `._       : _,  \  /'`-._L,_'-._
     '--' '-.\__/ _L   .`'         './/
                 [ (  /
                  ) `{{
       snd        \__)";
        }

    }
}
